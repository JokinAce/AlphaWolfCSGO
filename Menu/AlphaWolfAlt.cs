using System.Threading;
using System.Windows.Forms;
using static AlphaWolf.Manager;
using static AlphaWolf.Memory;
using static AlphaWolf.Offsets;
using static AlphaWolf.SOffsets;
using static AlphaWolf.Util;
using static Menu.Menu;

namespace AlphaWolf.Alt {
    public static class Manager {
        private static float OldViewAngleY; // For Strafe

        public static void Start() {
            _ = $"{AntiVac}";
            if (GetModules() && jokin.CheckProcess()) {
                while (true) {
                    if (HitSoundBool && PlayerHits() > 0) {
                        HitSound();
                        WriteInt(LocalPlayer + m_totalHitsOnServer, 0);
                    }

                    if (NoFlash && PlayerFlash() > 0) {
                        WriteFloat(LocalPlayer + m_flFlashMaxAlpha, 0);
                    } else if (!NoFlash && PlayerFlash() == 0) {
                        WriteFloat(LocalPlayer + m_flFlashMaxAlpha, 255);
                    }

                    if (CustomFOVBool && PlayerFOV() != CustomFOVNumber) {
                        WriteInt(LocalPlayer + m_iDefaultFOV, CustomFOVNumber);
                    }

                    if (BHopBool && IsKeyPushedDown(Keys.Space)) {
                        if (StrafeBool) {
                            if (ViewAngles.Y > OldViewAngleY) {
                                PlayerLeft();
                            } else if (ViewAngles.Y < OldViewAngleY) {
                                PlayerRight();
                            }
                            OldViewAngleY = ViewAngles.Y;
                        } else {
                            OldViewAngleY = 0;
                        }

                        if (PlayerFlags() == 257 | PlayerFlags() == 263) {
                            PlayerJump();
                        }
                    }
                    Thread.Sleep(1);
                }
            }
        }
    }
}
