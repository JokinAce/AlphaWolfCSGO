using Menu.Properties;
using System;
using System.Media;
using System.Runtime.InteropServices;
using static AlphaWolf.Manager;
using static AlphaWolf.Memory;
using static AlphaWolf.Offsets;
using static AlphaWolf.SOffsets;
using static AlphaWolf.Util.Entity_IDs;

namespace AlphaWolf {

    public static class Util {

        [DllImport("user32.dll")]
        private static extern ushort GetAsyncKeyState(int vKey);

        public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey) {
            return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
        }

        public static bool CheckDormantImmuneTeamHP(int Target) {
            int LocalTeam = ReadInt(LocalPlayer + m_iTeamNum);
            int TargetTeam = ReadInt(Target + m_iTeamNum);
            int IsTargetImmune = ReadInt(Target + m_bGunGameImmunity);
            bool IsTargetNonDormant = ReadBoolean(Target + m_bDormant);
            int TargetHP = ReadInt(Target + m_iHealth);

            if (!IsTargetNonDormant & IsTargetImmune == 256 & LocalTeam != TargetTeam & TargetHP > 0) {
                return true;
            } else {
                return false;
            }
        }

        public static bool NanChecker(float first, float second) {
            if (double.IsNaN(first) | double.IsNaN(second)) {
                return false;
            } else {
                return true;
            }
        }

        public static bool CheckAngles(float x, float y) {
            if (x > 89) {
                return false;
            } else if (x < -89) {
                return false;
            } else if (y > 360) {
                return false;
            } else if (y < -360) {
                return false;
            } else {
                return true;
            }
        }

        public static Vector CalcDistance(Vector current, Vector yeet) {
            Vector distance;

            distance.X = (yeet.X - current.X);
            distance.Y = (yeet.Y - current.Y);
            distance.Z = 0;

            if (distance.X < -89) {
                distance.X += 360;
            } else if (distance.X > 89) {
                distance.X -= 360;
            }
            if (distance.X < 0.0) {
                distance.X = -distance.X;
            }

            if (distance.X < -180) {
                distance.X += 360;
            } else if (distance.X > 180) {
                distance.X -= 360;
            }
            if (distance.X < 0.0) {
                distance.X = -distance.X;
            }
            return distance;
        }

        //    def normalizeAngles(viewAngleX, viewAngleY):
        //if viewAngleX > 89:
        //    viewAngleX -= 360
        //if viewAngleX< -89:
        //    viewAngleX += 360
        //if viewAngleY> 180:
        //    viewAngleY -= 360
        //if viewAngleY< -180:
        //    viewAngleY += 360
        //return viewAngleX, viewAngleY

        public static Vector NormalizeAngles(Vector ViewAngles) {
            if (ViewAngles.X > 89) {
                ViewAngles.X -= 360;
            }
            if (ViewAngles.X < -89) {
                ViewAngles.X += 360;
            }
            if (ViewAngles.Y > 180) {
                ViewAngles.Y -= 360;
            }
            if (ViewAngles.Y < -180) {
                ViewAngles.Y += 360;
            }

            return ViewAngles;
        }


        public static Vector CalcAngle(Vector src, Vector dst) {
            Vector Delta;
            Vector Finish;
            Delta.X = (src.X - dst.X);
            Delta.Y = (src.Y - dst.Y);
            Delta.Z = (src.Z - dst.Z);
            float hyp = (float)Math.Sqrt(Delta.X * Delta.X + Delta.Y * Delta.Y + Delta.Z * Delta.Z);

            Finish.X = (float)(Math.Atan(Delta.Z / hyp) * 180 / Math.PI);
            Finish.Y = (float)(Math.Atan(Delta.Y / Delta.X) * 180 / Math.PI);
            Finish.Z = 0;

            if (Delta.X >= 0.0f) {
                Finish.Y += 180.0f;
            }

            return Finish;
        }

        public static Vector PlayerViewAngles() {
            Vector ViewAngles;
            ViewAngles.X = ReadFloat(EC + dwClientState_ViewAngles);
            ViewAngles.Y = ReadFloat(EC + dwClientState_ViewAngles + 0x4);
            ViewAngles.Z = ReadFloat(LocalPlayer + m_vecViewOffset + 0x8);

            return ViewAngles;
        }

        public static Vector PlayerPos() {
            Vector PlayerView = PlayerViewAngles();
            Vector Pos;
            Pos.X = ReadFloat(LocalPlayer + m_vecOrigin);
            Pos.Y = ReadFloat(LocalPlayer + m_vecOrigin + 0x4);
            Pos.Z = ReadFloat(LocalPlayer + m_vecOrigin + 0x8) + PlayerView.Z;

            return Pos;
        }

        public static int Player() {
            return ReadInt(ClientDLL + dwLocalPlayer);
        }

        public static void PlayerForward() {
            WriteInt(ClientDLL + dwForceForward, 6);
        }

        public static void PlayerBackward() {
            WriteInt(ClientDLL + dwForceBackward, 6);
        }

        public static void PlayerLeft() {
            WriteInt(ClientDLL + dwForceLeft, 6);
        }

        public static void PlayerRight() {
            WriteInt(ClientDLL + dwForceRight, 6);
        }

        public static void PlayerJump() {
            WriteInt(ClientDLL + dwForceJump, 6);
        }

        public static void PlayerAttack() {
            WriteInt(ClientDLL + dwForceAttack, 6);
        }

        public static float PlayerFlash() {
            return ReadFloat(LocalPlayer + m_flFlashMaxAlpha);
        }

        public static int PlayerShots() {
            return ReadInt(LocalPlayer + m_iShotsFired);
        }

        public static int PlayerFlags() {
            return ReadInt(LocalPlayer + m_fFlags);
        }

        public static int PlayerFOV() {
            return ReadInt(LocalPlayer + m_iDefaultFOV);
        }

        public static (int, int) PlayerCrosshair() {
            int CrosshairID = ReadInt(LocalPlayer + m_iCrosshairId);
            int CrosshairTarget = ReadInt(ClientDLL + dwEntityList + (CrosshairID - 1) * 0x10);

            return (CrosshairID, CrosshairTarget);
        }

        public static bool HasKnife() {
            int ActiveWeapon = ReadInt(LocalPlayer + m_hActiveWeapon) & 0xfff;
            ActiveWeapon = ReadInt(ClientDLL + dwEntityList + (ActiveWeapon - 1) * 0x10);
            if (ActiveWeapon == 0) { return false; }
            int ActiveWeaponViewModelID = ReadInt(ActiveWeapon + m_iViewModelIndex);
            short ActiveWeaponID = ReadShort(ActiveWeapon + m_iItemDefinitionIndex);

            if (ActiveWeaponID == (short)WEAPON_Knife_CT | ActiveWeaponID == (short)WEAPON_Knife_T & ActiveWeaponViewModelID > 0) {
                return true;
            } else {
                return false;
            }
        }

        public static int PlayerHits() {
            return ReadInt(LocalPlayer + m_totalHitsOnServer);
        }

        private static readonly SoundPlayer audio = new SoundPlayer(Resources.skeet);

        public static void HitSound() {
            audio.Play();
        }

        public static int EngineClient() {
            return ReadInt(EngineDLL + dwClientState);
        }

        public static void ForceUpdate() {
            int ClientState = ReadInt(EngineDLL + dwClientState);
            WriteInt(ClientState + 0x174, -1);
        }

        public static void Niggerize() {
            Enemy Player;
            for (int i = 1; i < 24; i++) {
                Player.self = ReadInt(ClientDLL + dwEntityList + i * 0x10);
                WriteFloat(Player.self + m_clrRender, 0);
            }
        }

        public static int RandomChoose(int first, int second) {
            Random random = new Random();
            int[] values = new[] { first, second };
            int result = values[random.Next(values.Length)];
            return result;
        }

        public struct Vector {
            public float X, Y, Z;
        }

        public struct Enemy {
            public int self;
            public int Glow;
            public int Team;
            public int Health;
            public int Bones;
            public bool Dormant;

            public Vector Pos;
        }

        public enum Entity_IDs {
            WEAPON_Desert_Eagle = 1,
            WEAPON_Dual_Berettas = 2,
            WEAPON_Five_SeveN = 3,
            WEAPON_Glock_18 = 4,
            WEAPON_AK_47 = 7,
            WEAPON_AUG = 8,
            WEAPON_AWP = 9,
            WEAPON_FAMAS = 10,
            WEAPON_G3SG1 = 11,
            WEAPON_Galil_AR = 13,
            WEAPON_M249 = 14,
            WEAPON_M4A4 = 16,
            WEAPON_MAC_10 = 17,
            WEAPON_P90 = 19,
            WEAPON_MP5_SD = 23,
            WEAPON_UMP_45 = 24,
            WEAPON_XM1014 = 25,
            WEAPON_PP_Bizon = 26,
            WEAPON_MAG_7 = 27,
            WEAPON_Negev = 28,
            WEAPON_Sawed_Off = 29,
            WEAPON_Tec_9 = 30,
            WEAPON_Zeus_x27 = 31,
            WEAPON_P2000 = 32,
            WEAPON_MP7 = 33,
            WEAPON_MP9 = 34,
            WEAPON_Nova = 35,
            WEAPON_P250 = 36,
            WEAPON_Ballistic_Shield = 37,
            WEAPON_SCAR_20 = 38,
            WEAPON_SG_553 = 39,
            WEAPON_SSG_08 = 40,
            WEAPON_Knife_CT = 42,
            GRENADE_Flashbang = 43,
            GRENADE_Explosive = 44,
            GRENADE_Smoke = 45,
            GRENADE_Molotov = 46,
            GRENADE_Decoy = 47,
            GRENADE_Incendiary = 48,
            MISC_Bomb = 49,
            WEAPON_Knife_T = 59,
            WEAPON_M4A1_S = 60,
            WEAPON_USP_S = 61,
            WEAPON_CZ75_Auto = 63,
            WEAPON_R8_Revolver = 64,
        }

        public enum Sequences {
            SEQUENCE_DEFAULT_DRAW = 0,
            SEQUENCE_DEFAULT_IDLE1 = 1,
            SEQUENCE_DEFAULT_IDLE2 = 2,
            SEQUENCE_DEFAULT_LIGHT_MISS1 = 3,
            SEQUENCE_DEFAULT_LIGHT_MISS2 = 4,
            SEQUENCE_DEFAULT_HEAVY_MISS1 = 9,
            SEQUENCE_DEFAULT_HEAVY_HIT1 = 10,
            SEQUENCE_DEFAULT_HEAVY_BACKSTAB = 11,
            SEQUENCE_DEFAULT_LOOKAT1 = 12,

            SEQUENCE_FALCHION_IDLE1 = 1,
            SEQUENCE_FALCHION_HEAVY_MISS1 = 8,
            SEQUENCE_FALCHION_HEAVY_MISS1_NOFLIP = 9,
            SEQUENCE_FALCHION_LOOKAT1 = 12,
            SEQUENCE_FALCHION_LOOKAT2 = 13,

            SEQUENCE_BOWIE_IDLE1 = 1,

            SEQUENCE_BUTTERFLY_DRAW = 0,
            SEQUENCE_BUTTERFLY_DRAW2 = 1,
            SEQUENCE_BUTTERFLY_LOOKAT1 = 13,
            SEQUENCE_BUTTERFLY_LOOKAT3 = 15,

            SEQUENCE_DAGGERS_IDLE1 = 1,
            SEQUENCE_DAGGERS_LIGHT_MISS1 = 2,
            SEQUENCE_DAGGERS_LIGHT_MISS5 = 6,
            SEQUENCE_DAGGERS_HEAVY_MISS2 = 11,
            SEQUENCE_DAGGERS_HEAVY_MISS1 = 12,

            SEQUENCE_URSUS_DRAW = 0,
            SEQUENCE_URSUS_DRAW2 = 1,
            SEQUENCE_URSUS_LOOKAT1 = 13,
            SEQUENCE_URSUS_LOOKAT3 = 15,

            SEQUENCE_STILETTO_LOOKAT1 = 12,
            SEQUENCE_STILETTO_LOOKAT2 = 13,

            SEQUENCE_TALON_LOOKAT1 = 14,
            SEQUENCE_TALON_LOOKAT2 = 15
        }
    }
}