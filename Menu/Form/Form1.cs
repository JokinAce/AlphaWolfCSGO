using AlphaWolf;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static AlphaWolf.Util;

namespace Menu {
    public partial class Menu : Form {
        private readonly Thread Starter = new Thread(new ThreadStart(Manager.Start));
        private readonly Thread StarterAlt = new Thread(new ThreadStart(AlphaWolf.Alt.Manager.Start));
        private readonly Thread StarterSkin = new Thread(new ThreadStart(AlphaWolf.Skin.Manager.Start));
        public Menu() {
            InitializeComponent();

            Process[] CheckAlive = Process.GetProcessesByName("csgo");

            if (CheckAlive.Length > 0) {
                MessageBox.Show("It's recommended to open the Cheat first and then CSGO.\n\nThe safest way is putting this Cheat on a USB, running it, and pulling the USB out.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                Process[] steam = Process.GetProcessesByName("steam");
                if (steam.Length > 0) {
                    steam[0].Kill();
                }
                MessageBox.Show("Now start Steam and CSGO to Main Menu and then press OK", "Init", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Starter.Start();
            StarterAlt.Start();
            StarterSkin.Start();
        }

        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1) {
                        m.Result = (IntPtr)0x2;
                    }

                    return;
            }

            base.WndProc(ref m);
        }

        private void Menu_Load(object sender, EventArgs e) {
            PanelLabel.ForeColor = Color.FromArgb(0, 128, 128);
            labelfooter.ForeColor = Color.FromArgb(0, 128, 128);
            CustomFOVLabel.ForeColor = Color.FromArgb(0, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 128);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Starter.Abort("Close Button");
            StarterAlt.Abort("Close Button");
            StarterSkin.Abort("Close Button");

            if (Application.MessageLoop) {
                // WinForms app
                Application.Exit();
            } else {
                // Console app
                Environment.Exit(1);
            }
        }

        private void SkeetColorTimer_Tick(object sender, EventArgs e) {
            Random Colors = new Random();
            (int R, int G, int B) = (Colors.Next(100, 200), Colors.Next(100, 200), Colors.Next(100, 200));

            SkeetColor.BackColor = Color.FromArgb(150, R, G, B);

            PanelLabel.ForeColor = Color.FromArgb(150, R, G, B);
            labelfooter.ForeColor = Color.FromArgb(150, R, G, B);
            TriggerBotDelayLabel.ForeColor = Color.FromArgb(150, R, G, B);
            CustomFOVLabel.ForeColor = Color.FromArgb(150, R, G, B);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(150, R, G, B);
        }

        private void CheckTabs() {
            bhop.Visible = false;
            StrafeCheckBox.Visible = false;
            Hitsoundcheckbox.Visible = false;
            GlowESP.Visible = false;
            GlowESPCombo.Visible = false;
            noFlash.Visible = false;
            AimbotBox.Visible = false;
            AimbotCombo.Visible = false;
            TriggerBotCheck.Visible = false;
            TriggerCombo.Visible = false;
            TriggerBotDelayBox.Visible = false;
            TriggerBotDelayLabel.Visible = false;
            RadarBox.Visible = false;
            CustomFOVBox.Visible = false;
            CustomFOVTrack.Visible = false;
            CustomFOVLabel.Visible = false;
            NiggerButton.Visible = false;
            SkinChangerCheckBox.Visible = false;
            KnifeChangerBox.Visible = false;
            KnifeChangerCombo.Visible = false;
            btnForceUpdate.Visible = false;

            PistolsLabel.Visible = false;
            DesertEagleLabel.Visible = false;
            DesertEagleComboBox.Visible = false;
            Glock18Label.Visible = false;
            Glock18ComboBox.Visible = false;
            USPSLabel.Visible = false;
            USPSComboBox.Visible = false;
            P2000Label.Visible = false;
            P2000ComboBox.Visible = false;

            foreach (Control previousBtn in SideBar.Controls) {
                if (previousBtn.GetType() == typeof(Button)) {
                    previousBtn.BackColor = Color.FromArgb(28, 28, 28);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
                }
            }
        }

        private void ActivateButton(string name, Button shit) {
            labelfooter.Text = name;

            shit.BackColor = Color.FromArgb(35, 35, 35);
            shit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
        }

        private void BtnAim_Click(object sender, EventArgs e) {
            CheckTabs();
            ActivateButton(btnAim.Text, btnAim);

            AimbotBox.Visible = true;
            AimbotCombo.Visible = true;
            TriggerBotCheck.Visible = true;
            TriggerCombo.Visible = true;
            TriggerBotDelayBox.Visible = true;
            TriggerBotDelayLabel.Visible = true;
        }

        private void BtnVisual_Click(object sender, EventArgs e) {
            CheckTabs();
            ActivateButton(btnVisual.Text, btnVisual);
            GlowESP.Visible = true;
            GlowESPCombo.Visible = true;
            noFlash.Visible = true;
            RadarBox.Visible = true;
            CustomFOVBox.Visible = true;
            CustomFOVTrack.Visible = true;
            CustomFOVLabel.Visible = true;
        }

        private void BtnMisc_Click(object sender, EventArgs e) {
            CheckTabs();
            ActivateButton(btnMisc.Text, btnMisc);

            bhop.Visible = true;
            StrafeCheckBox.Visible = true;
            Hitsoundcheckbox.Visible = true;
        }

        private void BtnTrolling_Click(object sender, EventArgs e) {
            CheckTabs();
            ActivateButton(btnTrolling.Text, btnTrolling);

            NiggerButton.Visible = true;
        }

        private void BtnSkinChanger_Click(object sender, EventArgs e) {
            CheckTabs();
            ActivateButton(btnSkinChanger.Text, btnSkinChanger);

            SkinChangerCheckBox.Visible = true;
            KnifeChangerBox.Visible = true;
            KnifeChangerCombo.Visible = true;
            btnForceUpdate.Visible = true;

            PistolsLabel.Visible = true;
            DesertEagleLabel.Visible = true;
            DesertEagleComboBox.Visible = true;
            Glock18Label.Visible = true;
            Glock18ComboBox.Visible = true;
            USPSLabel.Visible = true;
            USPSComboBox.Visible = true;
            P2000Label.Visible = true;
            P2000ComboBox.Visible = true;
        }

        public static bool BHopBool = false;
        private void Bhop_CheckedChanged(object sender, EventArgs e) {
            BHopBool = bhop.Checked;
        }

        public static bool StrafeBool = false;
        private void StrafeCheckBox_CheckedChanged(object sender, EventArgs e) {
            StrafeBool = StrafeCheckBox.Checked;
        }

        public static bool HitSoundBool = false;
        private void Hitsoundcheckbox_CheckedChanged(object sender, EventArgs e) {
            HitSoundBool = Hitsoundcheckbox.Checked;
        }

        public static bool NoFlash = false;
        private void NoFlash_CheckedChanged(object sender, EventArgs e) {
            NoFlash = noFlash.Checked;
        }

        public static bool AimbotBool = false;
        private void AimbotBox_CheckedChanged(object sender, EventArgs e) {
            AimbotBool = AimbotBox.Checked;
        }

        public static int AimbotInt = 0;
        private void AimbotCombo_SelectedIndexChanged(object sender, EventArgs e) {
            AimbotInt = AimbotCombo.SelectedIndex;
        }

        public static bool TriggerBotBool = false;
        private void TriggerBotCheck_CheckedChanged(object sender, EventArgs e) {
            TriggerBotBool = TriggerBotCheck.Checked;
        }

        public static string TriggerBotKey;
        private void TriggerCombo_SelectedIndexChanged(object sender, EventArgs e) {
            TriggerBotKey = (string)TriggerCombo.SelectedItem;
        }

        public static int TriggerBotDelay;
        private void TriggerBotDelayBox_ValueChanged(object sender, EventArgs e) {
            TriggerBotDelay = (int)TriggerBotDelayBox.Value;
        }

        public static bool GlowESPBool = false;
        private void GlowESP_CheckedChanged(object sender, EventArgs e) {
            GlowESPBool = GlowESP.Checked;
        }

        public static int GlowESPInt = 0;
        private void GlowESPCombo_SelectedIndexChanged(object sender, EventArgs e) {
            GlowESPInt = GlowESPCombo.SelectedIndex;
        }

        public static bool RaderESPBool = false;
        private void RadarBox_CheckedChanged(object sender, EventArgs e) {
            RaderESPBool = RadarBox.Checked;
        }

        public static bool CustomFOVBool = false;
        private void CustomFOVBox_CheckedChanged(object sender, EventArgs e) {
            CustomFOVBool = CustomFOVBox.Checked;
        }

        public static int CustomFOVNumber = 110;
        private void CustomFOVTrack_Scroll(object sender, EventArgs e) {
            CustomFOVNumber = CustomFOVTrack.Value;
            CustomFOVLabel.Text = CustomFOVTrack.Value.ToString();
        }

        private void NiggerButton_Click(object sender, EventArgs e) {
            Niggerize();
        }

        public static bool KnifeChangerBool = false;
        private void KnifeChangerBox_CheckedChanged(object sender, EventArgs e) {
            KnifeChangerBool = KnifeChangerBox.Checked;
        }

        public static bool SkinChangerBool = false;
        private void SkinChangerCheckBox_CheckedChanged(object sender, EventArgs e) {
            SkinChangerBool = SkinChangerCheckBox.Checked;
        }

        public static string KnifeChangerKnife;
        private void KnifeChangerCombo_SelectedIndexChanged(object sender, EventArgs e) {
            KnifeChangerKnife = KnifeChangerCombo.Text;
        }

        private void BtnForceUpdate_Click(object sender, EventArgs e) {
            ForceUpdate();
        }

        public static int DesertEagleSkin = 0;
        private void DesertEagleComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //None
            //Blaze
            //Blue Ply
            //Bronze Deco
            //Cobalt Disruption
            //Code Red
            //Conspiracy
            //Corinthian
            //Crimson Web
            //Directive
            //Emerald Jörmungandr
            //Golden Koi
            //Hand Cannon
            //Heirloom
            //Hypnotic
            //Kumicho Dragon
            //Light Rail
            //Mecha Industries
            //Meteorite
            //Midnight Storm
            //Mudder
            //Naga
            //Night
            //Oxide Blaze
            //Pilot
            //Printstream
            //Sunset Storm
            //Urban DDPAT
            //Urban Rubble
            DesertEagleSkin = DesertEagleComboBox.SelectedIndex switch
            {
                0 => 0,
                1 => 37,
                2 => 945,
                3 => 425,
                4 => 231,
                5 => 711,
                6 => 351,
                7 => 509,
                8 => 232,
                9 => 603,
                10 => 757,
                11 => 185,
                12 => 328,
                13 => 273,
                14 => 61,
                15 => 527,
                16 => 841,
                17 => 805,
                18 => 296,
                19 => 468,
                20 => 90,
                21 => 397,
                22 => 40,
                23 => 645,
                24 => 347,
                25 => 962,
                26 => 469,
                27 => 470,
                28 => 17,
                29 => 237,
                _ => 0,
            };
        }

        public static int Glock18Skin = 0;
        private void Glock18ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //            None
            //Blue Fissure
            //Brass
            //Bullet Queen
            //Bunsen Burner
            //Candy Apple
            //Catacombs
            //Death Rattle
            //Dragon Tattoo
            //Fade
            //Grinder
            //Groundwater
            //High Beam
            //Ironwork
            //Moonrise
            //Night
            //Nuclear Garden
            //Off World
            //Oxide Blaze
            //Reactor
            //Royal Legion
            //Sacrifice
            //Sand Dune
            //Steel Disruption
            //Synth Leaf
            //Twilight Galaxy
            //Vogue
            //Warhawk
            //Wasteland Rebel
            //Water Elemental
            //Weasel
            //Wraiths
            Glock18Skin = Glock18ComboBox.SelectedIndex switch
            {
                0 => 0,
                1 => 278,
                2 => 159,
                3 => 957,
                4 => 479,
                5 => 3,
                6 => 399,
                7 => 293,
                8 => 48,
                10 => 38,
                11 => 381,
                12 => 2,
                13 => 799,
                14 => 623,
                15 => 694,
                16 => 40,
                17 => 789,
                18 => 680,
                19 => 808,
                20 => 367,
                21 => 532,
                22 => 918,
                23 => 208,
                24 => 230,
                25 => 732,
                26 => 437,
                27 => 963,
                28 => 713,
                29 => 586,
                30 => 353,
                32 => 607,
                33 => 495,
                _ => 0,
            };
        }

        public static int P2000Skin = 0;
        private void P2000ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //            None
            //Acid Etched
            //Amber Fade
            //Chainmail
            //Coach Class
            //Corticera
            //Fire Elemental
            //Gnarled
            //Granite Marbleized
            //Grassland
            //Grassland Leaves
            //Handgun
            //Imperial
            //Imperial Dragon
            //Ivory
            //Obsidian
            //Ocean Foam
            //Oceanic
            //Pathfinder
            //Pulse
            //Red FragCam
            //Scorpion
            //Silver
            //Turf
            //Urban Hazard
            //Woodsman
            P2000Skin = P2000ComboBox.SelectedIndex switch
            {
                0 => 0,
                1 => 951,
                2 => 246,
                3 => 327,
                4 => 346,
                5 => 184,
                6 => 389,
                7 => 960,
                8 => 21,
                9 => 95,
                10 => 104,
                12 => 485,
                13 => 515,
                14 => 591,
                15 => 357,
                16 => 894,
                17 => 211,
                18 => 550,
                19 => 443,
                20 => 338,
                21 => 275,
                22 => 71,
                23 => 32,
                24 => 635,
                25 => 700,
                26 => 667,
                _ => 0,
            };
        }

        public static int P250Skin = 0;
        private void P250ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //            None
            //Asiimov
            //Bone Mask
            //Boreal Forest
            //Cartel
            //Cassette
            //Contamination
            //Crimson Kimono
            //Dark Filigree
            //Exchanger
            //Facets
            //Facility Draft
            //Franklin
            //Gunsmoke
            //Hive
            //Inferno
            //Iron Clad
            //Mehndi
            //Metallic DDPAT
            //Mint Kimono
            //Modern Hunter
            //Muertos
            //Nevermore
            //Nuclear Threat
            //Red Rock
            //Ripple
            //Sand Dune
            //See Ya Later
            //Splash
            //Steel Disruption
            //Supernova
            //Undertow
            //Valence
            //Verdigris
            //Vino Primo
            //Whiteout
            //Wingshot
            //X - Ray
            P250Skin = P250ComboBox.SelectedIndex switch
            {
                0 => 0,
                1 => 551,
                2 => 27,
                3 => 77,
                4 => 388,
                5 => 968,
                6 => 373,
                7 => 466,
                8 => 741,
                9 => 786,
                10 => 207,
                11 => 777,
                _ => 0,
            };
        }

        public static int USPSSkin = 0;
        private void USPSComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //            None
            //Blood Tiger
            //Blueprint
            //Business Class
            //Caiman
            //Check Engine
            //Cortex
            //Cyrex
            //Dark Water
            //Flashback
            //Forest Leaves
            //Guardian
            //Kill Confirmed
            //Lead Conduit
            //Neo - Noir
            //Night Ops
            //Orion
            //Overgrowth
            //Para Green
            //Pathfinder
            //Road Rash
            //Royal Blue
            //Serum
            //Stainless
            //Torque
            USPSSkin = USPSComboBox.SelectedIndex switch
            {
                0 => 0,
                1 => 217,
                2 => 657,
                3 => 364,
                4 => 339,
                5 => 796,
                6 => 705,
                7 => 637,
                8 => 60,
                9 => 817,
                10 => 25,
                11 => 290,
                12 => 504,
                13 => 540,
                14 => 653,
                15 => 236,
                16 => 313,
                17 => 183,
                18 => 454,
                19 => 443,
                20 => 318,
                21 => 332,
                22 => 221,
                23 => 277,
                24 => 489,
                _ => 0,
            };
        }
    }
}
