using System.Threading;
using System.Windows.Forms;
using static AlphaWolf.Memory;
using static AlphaWolf.Offsets;
using static AlphaWolf.Util;
using static Menu.Menu;

namespace AlphaWolf {

    public static class Manager {
        private static Keys RealTriggerKey, RealAimbotKey;
        private static Vector LocalPos, Punch, OldPunch, NewRCS, olddist;
        private static Enemy Player, Target;

        public static int LocalPlayer, EC; // Coms between Util and Manager etc.
        public static Vector ViewAngles;

        private struct CTRGB {
            public float r;
            public float g;
            public float b;

            public bool pulse;
        }

        private struct TRGB {
            public float r;
            public float g;
            public float b;

            public bool pulse;
        }

        public static string AntiVac = "Bs5ofHf0zN!*GKnr@lcp4b2e#xFfki1pgGmsqo0Jr1VvS#n2b8nLiom2GN1O6qEigvS*bTlg*%za5l1uaLlnPyQZvET3U0Y1vaMUip9i9q*hq!*%ws6#%h$7NqkymIt326twq7TZrb73^f2ETBx$L2U$tJc%H*lIrB5k92&&isnZqS1@6keivQ#r&&S%YNyKtEqQ*uDK"
            + "Le^RmSuKecBEoS@!^i!n4Mhcf2@dYoSRyP!$OB5C94OhN75%lFHT70dTw6slX4gPZ96Fjb7L8%q&&32vuWHgbJZu8HoHB@e2%uYBh@h8aLsQEBX7#d!!tXsnMzrHxx$ynn16IrcHYoCoNbWRok^poEbhvaXgARaosq#M#WnhRpV^474PAb@Z0V*KdspR*GWbi6CP6XQ"
            + "Ui63*W#TjKkL^9QP*ahZw8pC$RGixzo0rG85ZYHUMUIm#xkKX&&iX$5sIZhUxtRi#RaCPf6UZYn@WFcfaN56EbeGs@FERLZ2$yx$";

        public static void Start() {
            _ = $"{AntiVac}";
            if (GetModules() && jokin.CheckProcess()) {
                while (true) {
                    olddist.X = 111111111111f;
                    olddist.Y = 111111111111f;

                    LocalPlayer = Player();
                    EC = EngineClient();
                    ViewAngles = PlayerViewAngles();
                    LocalPos = PlayerPos();

                    if (TriggerBotBool) {
                        switch (TriggerBotKey) {
                            case "None":
                                RealTriggerKey = 0;
                                break;
                            case "ALT":
                                RealTriggerKey = Keys.LMenu;
                                break;
                            case "F":
                                RealTriggerKey = Keys.F;
                                break;
                        }

                        (int CrosshairID, int CrosshairTarget) = PlayerCrosshair();

                        if (!HasKnife() && CrosshairID > 0 && CrosshairID < 32 && CheckDormantImmuneTeamHP(CrosshairTarget)) {
                            if (!HasKnife() && IsKeyPushedDown(RealTriggerKey) | RealTriggerKey == 0) {
                                Thread.Sleep(TriggerBotDelay);
                                PlayerAttack();
                            }
                        }
                    }

                    if (AimbotBool) {
                        if (AimbotInt == 0) {
                            if (PlayerShots() > 2) {
                                Punch.X = ReadFloat(LocalPlayer + m_aimPunchAngle);
                                Punch.Y = ReadFloat(LocalPlayer + m_aimPunchAngle + 0x4);

                                NewRCS.X = ViewAngles.X - (Punch.X - OldPunch.X) * 2;
                                NewRCS.Y = ViewAngles.Y - (Punch.Y - OldPunch.Y) * 2;
                                OldPunch.X = Punch.X;
                                OldPunch.Y = Punch.Y;

                                if (NanChecker(NewRCS.X, NewRCS.Y)) {
                                    WriteFloat(EC + dwClientState_ViewAngles, NewRCS.X);
                                    WriteFloat(EC + dwClientState_ViewAngles + 0x4, NewRCS.Y);
                                }
                            } else {
                                OldPunch.X = 0;
                                OldPunch.Y = 0;
                                NewRCS.X = 0;
                                NewRCS.Y = 0;
                            }
                        } else {
                            switch (AimbotInt) {
                                case 1:
                                    RealAimbotKey = Keys.LMenu;
                                    break;
                                case 2:
                                    RealAimbotKey = Keys.F;
                                    break;
                            }
                        }
                    }

                    for (int i = 1; i < 24; i++) {
                        Player.self = ReadInt(ClientDLL + dwEntityList + i * 0x10);

                        //bool Player_IsDefusing = ReadBoolean(Player + m_bIsDefusing);
                        if (CheckDormantImmuneTeamHP(Player.self)) {
                            Player.Glow = ReadInt(Player.self + m_iGlowIndex);
                            Player.Team = ReadInt(Player.self + m_iTeamNum);
                            Player.Health = ReadInt(Player.self + m_iHealth);
                            Player.Bones = ReadInt(Player.self + m_dwBoneMatrix);
                            Player.Dormant = ReadBoolean(Player.self + m_bDormant);
                            Player.Pos.X = ReadFloat(Player.Bones + 0x30 * 8 + 0xC);
                            Player.Pos.Y = ReadFloat(Player.Bones + 0x30 * 8 + 0x1C);
                            Player.Pos.Z = ReadFloat(Player.Bones + 0x30 * 8 + 0x2C);

                            Vector GettingAngle = CalcAngle(LocalPos, Player.Pos);
                            Vector Distance = CalcDistance(LocalPos, GettingAngle);

                            if (Distance.X < olddist.X && Distance.Y < olddist.Y) {
                                (olddist.X, olddist.Y) = (Distance.X, Distance.Y);
                                (Target.self, Target.Health, Target.Dormant, Target.Pos.X, Target.Pos.Y, Target.Pos.Z) = (Player.self, Player.Health, Player.Dormant, Player.Pos.X, Player.Pos.Y, Player.Pos.Z);
                            }

                            if (AimbotInt != 0 && IsKeyPushedDown(RealAimbotKey) && Target.Health > 0 && !Target.Dormant) {
                                Vector AimAt = CalcAngle(LocalPos, Target.Pos);

                                if (NanChecker(AimAt.X, AimAt.Y)) {
                                    WriteFloat(EC + dwClientState_ViewAngles, AimAt.X);
                                    WriteFloat(EC + dwClientState_ViewAngles + 0x4, AimAt.Y);
                                }
                            }

                            if (RaderESPBool) {
                                WriteInt(Player.self + m_bSpotted, 1);
                            }

                            if (GlowESPBool) {
                                int GlowManager = ReadInt(ClientDLL + dwGlowObjectManager);
                                if (Player.Team == 2) {
                                    TRGB RGB;
                                    RGB.r = 0;
                                    RGB.g = 255;
                                    RGB.b = 255;

                                    if (GlowESPInt == 1 | GlowESPInt == 3) {
                                        switch (Player.Health) {
                                            case > 50 and not 100:
                                                RGB.r = 255;
                                                RGB.g = 255; // LORENZO ADRIAN GELD Farcry && Nicht Mehr;)
                                                RGB.b = 0;
                                                break;
                                            case < 50:
                                                RGB.r = 255;
                                                RGB.g = 0;
                                                RGB.b = 0;
                                                break;
                                        }
                                    }

                                    if (GlowESPInt == 2 | GlowESPInt == 3) {
                                        RGB.pulse = true;
                                    } else {
                                        RGB.pulse = false;
                                    }

                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0x4, RGB.r / 255); //R
                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0x8, RGB.g / 255); //G
                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0xC, RGB.b / 255); //B

                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0x10, 1); //Alpha
                                    //WriteFloat(Player + m_clrRender, 0); // Black nigs
                                    WriteBoolean(GlowManager + Player.Glow * 0x38 + 0x2C, RGB.pulse); // Pulse

                                    WriteBoolean(GlowManager + Player.Glow * 0x38 + 0x24, true); // Hate my life
                                } else if (Player.Team == 3) {
                                    CTRGB RGB;
                                    RGB.r = 0;
                                    RGB.g = 0;
                                    RGB.b = 255;

                                    if (GlowESPInt == 1 | GlowESPInt == 3) {
                                        switch (Player.Health) {
                                            case > 50 and not 100:
                                                RGB.r = 255;
                                                RGB.g = 255;
                                                RGB.b = 0;
                                                break;
                                            case < 50:
                                                RGB.r = 255;
                                                RGB.g = 0;
                                                RGB.b = 0;
                                                break;
                                        }
                                    }

                                    if (GlowESPInt == 2 | GlowESPInt == 3) {
                                        RGB.pulse = true;
                                    } else {
                                        RGB.pulse = false;
                                    }

                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0x4, RGB.r / 255); //R
                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0x8, RGB.g / 255); //G
                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0xC, RGB.b / 255); //B

                                    WriteFloat(GlowManager + Player.Glow * 0x38 + 0x10, 1); //Alpha
                                    //WriteFloat(Player + m_clrRender, 0); // Black nigs
                                    WriteBoolean(GlowManager + Player.Glow * 0x38 + 0x2C, RGB.pulse); // Pulse

                                    WriteBoolean(GlowManager + Player.Glow * 0x38 + 0x24, true); // Hate my life
                                }
                            }
                        }
                    }
                    Thread.Sleep(1);
                }
            }
        }
    }
}