using static AlphaWolf.Manager;
using static AlphaWolf.Memory;
using static AlphaWolf.Offsets;
using static AlphaWolf.SOffsets;
using static AlphaWolf.Util;
using static AlphaWolf.Util.Entity_IDs;
using static AlphaWolf.Util.Sequences;
using static Menu.Menu;

namespace AlphaWolf.Skin {
    public static class Manager {
        public static void Start() {
            _ = $"{AntiVac}";
            if (GetModules() && jokin.CheckProcess()) {
                while (true) {
                    if (SkinChangerBool) {
                        for (int i = 0; i < 8; i++) {
                            int ActiveWeapon = ReadInt(LocalPlayer + m_hMyWeapons + i * 0x4) & 0xfff;
                            ActiveWeapon = ReadInt(ClientDLL + dwEntityList + (ActiveWeapon - 1) * 0x10);
                            if (ActiveWeapon == 0) { continue; }
                            int ActiveWeaponID = ReadShort(ActiveWeapon + m_iItemDefinitionIndex);
                            int OwnerID = ReadInt(ActiveWeapon + m_OriginalOwnerXuidLow);

                            int PaintKit = 0;
                            int EntityQuality = 0;
                            float Wear = 0.0001f;
                            int Seed = 0;
                            int StatTrack = 1337;
                            string CustomName = "AlphaWolf | GG EZ";

                            switch (ActiveWeaponID) {
                                case (int)WEAPON_Desert_Eagle:
                                    PaintKit = DesertEagleSkin;
                                    break;
                                case (int)WEAPON_Glock_18:
                                    PaintKit = Glock18Skin;
                                    break;
                                case (int)WEAPON_USP_S:
                                    PaintKit = USPSSkin;
                                    break;
                                // TO-DO: Add more Weapons GUI
                            }

                            if (PaintKit != 0) {
                                if (ReadInt(ActiveWeapon + m_iItemIDHigh) != -1) {
                                    WriteInt(ActiveWeapon + m_iItemIDHigh, -1);
                                }

                                WriteInt(ActiveWeapon + m_iAccountID, OwnerID);
                                WriteInt(ActiveWeapon + m_nFallbackPaintKit, PaintKit);
                                WriteInt(ActiveWeapon + m_nFallbackSeed, Seed);
                                WriteInt(ActiveWeapon + m_nFallbackStatTrak, StatTrack);
                                WriteFloat(ActiveWeapon + m_flFallbackWear, Wear);
                                WriteString(ActiveWeapon + m_szCustomName, CustomName);

                                if (StatTrack >= 0) {
                                    WriteInt(ActiveWeapon + m_iEntityQuality, 9);
                                } else {
                                    WriteInt(ActiveWeapon + m_iEntityQuality, EntityQuality);
                                }
                            }
                        }
                    }

                    if (KnifeChangerBool) {
                        int ActiveWeapon = ReadInt(LocalPlayer + m_hActiveWeapon) & 0xfff;
                        ActiveWeapon = ReadInt(ClientDLL + dwEntityList + (ActiveWeapon - 1) * 0x10);
                        if (ActiveWeapon == 0) { continue; }
                        int ActiveWeaponViewModelID = ReadInt(ActiveWeapon + m_iViewModelIndex);
                        short ActiveWeaponID = ReadShort(ActiveWeapon + m_iItemDefinitionIndex);

                        int ModelIndex; // sv_precacheinfo FUCK MAN T409/CT384 Knives + ? till knife number
                        int Temp = 0;
                        if (ActiveWeaponID == (short)WEAPON_Knife_CT && ActiveWeaponViewModelID > 0) {

                            int KnifeViewModel = ReadInt(LocalPlayer + m_hViewModel) & 0xfff;
                            KnifeViewModel = ReadInt(ClientDLL + dwEntityList + (KnifeViewModel - 1) * 0x10);
                            if (KnifeViewModel == 0) { continue; }

                            int Sequence = ReadInt(KnifeViewModel + m_nSequence);
                            switch (KnifeChangerKnife) {
                                case "Karambit":
                                    ModelIndex = ActiveWeaponViewModelID + 102;
                                    break;
                                case "Butterfly":
                                    ModelIndex = ActiveWeaponViewModelID + 117;
                                    switch (Sequence) {
                                        case (int)SEQUENCE_DEFAULT_DRAW:
                                            Temp = RandomChoose((int)SEQUENCE_BUTTERFLY_DRAW, (int)SEQUENCE_BUTTERFLY_DRAW2);
                                            break;
                                        case (int)SEQUENCE_DEFAULT_LOOKAT1:
                                            Temp = RandomChoose((int)SEQUENCE_BUTTERFLY_LOOKAT1, (int)SEQUENCE_BUTTERFLY_LOOKAT3);
                                            break;
                                    }
                                    break;
                                case "Flip Knife":
                                    ModelIndex = ActiveWeaponViewModelID + 96;
                                    break;
                                case "Gut Knife":
                                    ModelIndex = ActiveWeaponViewModelID + 99;
                                    break;
                                case "M9 Bayonet":
                                    ModelIndex = ActiveWeaponViewModelID + 105;
                                    break;
                                case "Skeleton":
                                    ModelIndex = ActiveWeaponViewModelID + 145;
                                    break;
                                case "Talon Knife":
                                    ModelIndex = ActiveWeaponViewModelID + 142;
                                    switch (Sequence) {
                                        case (int)SEQUENCE_DEFAULT_LOOKAT1:
                                            Temp = RandomChoose((int)SEQUENCE_TALON_LOOKAT1, (int)SEQUENCE_TALON_LOOKAT2);
                                            break;
                                    }
                                    break;
                                case "Stiletto":
                                    ModelIndex = ActiveWeaponViewModelID + 139;
                                    break;
                                default:
                                    ModelIndex = ActiveWeaponViewModelID + 102;
                                    break;
                            }

                            WriteInt(KnifeViewModel + m_nModelIndex, ModelIndex);
                            if (Temp != 0) {
                                WriteInt(KnifeViewModel + m_nSequence, Temp);
                            }

                            //WriteInt(ActiveWeapon + m_nModelIndex, ModelIndex);
                            //WriteInt(ActiveWeapon + m_iItemDefinitionIndex, ItemDef);
                        } else if (ActiveWeaponID == (short)WEAPON_Knife_T && ActiveWeaponViewModelID > 0) {
                            int KnifeViewModel = ReadInt(LocalPlayer + m_hViewModel) & 0xfff;
                            KnifeViewModel = ReadInt(ClientDLL + dwEntityList + (KnifeViewModel - 1) * 0x10);
                            if (KnifeViewModel == 0) { continue; }
                            int Sequence = ReadInt(KnifeViewModel + m_nSequence);

                            switch (KnifeChangerKnife) {
                                case "Karambit":
                                    ModelIndex = ActiveWeaponViewModelID + 77;
                                    break;
                                case "Butterfly":
                                    ModelIndex = ActiveWeaponViewModelID + 92;
                                    switch (Sequence) {
                                        case (int)SEQUENCE_DEFAULT_DRAW:
                                            Temp = RandomChoose((int)SEQUENCE_BUTTERFLY_DRAW, (int)SEQUENCE_BUTTERFLY_DRAW2);
                                            break;
                                        case (int)SEQUENCE_DEFAULT_LOOKAT1:
                                            Temp = RandomChoose((int)SEQUENCE_BUTTERFLY_LOOKAT1, (int)SEQUENCE_BUTTERFLY_LOOKAT3);
                                            break;
                                    }
                                    break;
                                case "Flip Knife":
                                    ModelIndex = ActiveWeaponViewModelID + 71;
                                    break;
                                case "Gut Knife":
                                    ModelIndex = ActiveWeaponViewModelID + 74;
                                    break;
                                case "M9 Bayonet":
                                    ModelIndex = ActiveWeaponViewModelID + 80;
                                    break;
                                case "Skeleton":
                                    ModelIndex = ActiveWeaponViewModelID + 120;
                                    break;
                                case "Talon Knife":
                                    ModelIndex = ActiveWeaponViewModelID + 117;
                                    switch (Sequence) {
                                        case (int)SEQUENCE_DEFAULT_LOOKAT1:
                                            Temp = RandomChoose((int)SEQUENCE_TALON_LOOKAT1, (int)SEQUENCE_TALON_LOOKAT2);
                                            break;
                                    }
                                    break;
                                case "Stiletto":
                                    ModelIndex = ActiveWeaponViewModelID + 114;
                                    switch (Sequence) {
                                        case (int)SEQUENCE_DEFAULT_LOOKAT1:
                                            Temp = RandomChoose((int)SEQUENCE_STILETTO_LOOKAT1, (int)SEQUENCE_STILETTO_LOOKAT2);
                                            break;
                                    }
                                    break;
                                default:
                                    ModelIndex = ActiveWeaponViewModelID + 77;
                                    break;
                            }

                            WriteInt(KnifeViewModel + m_nModelIndex, ModelIndex);
                            if (Temp != 0) {
                                WriteInt(KnifeViewModel + m_nSequence, Temp);
                            }

                            //WriteInt(ActiveWeapon + m_nModelIndex, ModelIndex);
                            //WriteInt(ActiveWeapon + m_iItemDefinitionIndex, ItemDef);
                        }
                    }
                }
            }
        }
    }
}
