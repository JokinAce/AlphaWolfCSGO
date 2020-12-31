namespace Menu
{
    partial class Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelLabel = new System.Windows.Forms.Label();
            this.btnAim = new System.Windows.Forms.Button();
            this.btnVisual = new System.Windows.Forms.Button();
            this.btnMisc = new System.Windows.Forms.Button();
            this.btnTrolling = new System.Windows.Forms.Button();
            this.btnSkinChanger = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Panel();
            this.labelfooter = new System.Windows.Forms.Label();
            this.bhop = new System.Windows.Forms.CheckBox();
            this.noFlash = new System.Windows.Forms.CheckBox();
            this.TriggerCombo = new System.Windows.Forms.ComboBox();
            this.TriggerBotCheck = new System.Windows.Forms.CheckBox();
            this.GlowESP = new System.Windows.Forms.CheckBox();
            this.RadarBox = new System.Windows.Forms.CheckBox();
            this.CustomFOVTrack = new System.Windows.Forms.TrackBar();
            this.CustomFOVBox = new System.Windows.Forms.CheckBox();
            this.CustomFOVLabel = new System.Windows.Forms.Label();
            this.GlowESPCombo = new System.Windows.Forms.ComboBox();
            this.AimbotBox = new System.Windows.Forms.CheckBox();
            this.AimbotCombo = new System.Windows.Forms.ComboBox();
            this.TriggerBotDelayBox = new System.Windows.Forms.NumericUpDown();
            this.TriggerBotDelayLabel = new System.Windows.Forms.Label();
            this.StrafeCheckBox = new System.Windows.Forms.CheckBox();
            this.Hitsoundcheckbox = new System.Windows.Forms.CheckBox();
            this.NiggerButton = new System.Windows.Forms.Button();
            this.SkeetColor = new System.Windows.Forms.FlowLayoutPanel();
            this.SkeetColorTimer = new System.Windows.Forms.Timer(this.components);
            this.KnifeChangerBox = new System.Windows.Forms.CheckBox();
            this.KnifeChangerCombo = new System.Windows.Forms.ComboBox();
            this.btnForceUpdate = new System.Windows.Forms.Button();
            this.SkinChangerCheckBox = new System.Windows.Forms.CheckBox();
            this.PistolsLabel = new System.Windows.Forms.Label();
            this.DesertEagleLabel = new System.Windows.Forms.Label();
            this.Glock18Label = new System.Windows.Forms.Label();
            this.DesertEagleComboBox = new System.Windows.Forms.ComboBox();
            this.Glock18ComboBox = new System.Windows.Forms.ComboBox();
            this.USPSLabel = new System.Windows.Forms.Label();
            this.USPSComboBox = new System.Windows.Forms.ComboBox();
            this.P250Label = new System.Windows.Forms.Label();
            this.P250ComboBox = new System.Windows.Forms.ComboBox();
            this.P2000Label = new System.Windows.Forms.Label();
            this.P2000ComboBox = new System.Windows.Forms.ComboBox();
            this.SideBar.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomFOVTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerBotDelayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SideBar.Controls.Add(this.PanelLogo);
            this.SideBar.Controls.Add(this.btnAim);
            this.SideBar.Controls.Add(this.btnVisual);
            this.SideBar.Controls.Add(this.btnMisc);
            this.SideBar.Controls.Add(this.btnTrolling);
            this.SideBar.Controls.Add(this.btnSkinChanger);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(220, 588);
            this.SideBar.TabIndex = 1;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelLogo.Controls.Add(this.PanelLabel);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelLogo.Location = new System.Drawing.Point(3, 3);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(214, 50);
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelLabel
            // 
            this.PanelLabel.AutoSize = true;
            this.PanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanelLabel.ForeColor = System.Drawing.Color.White;
            this.PanelLabel.Location = new System.Drawing.Point(54, 9);
            this.PanelLabel.Name = "PanelLabel";
            this.PanelLabel.Size = new System.Drawing.Size(103, 25);
            this.PanelLabel.TabIndex = 0;
            this.PanelLabel.Text = "AlphaWolf";
            // 
            // btnAim
            // 
            this.btnAim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAim.FlatAppearance.BorderSize = 0;
            this.btnAim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAim.Location = new System.Drawing.Point(3, 59);
            this.btnAim.Name = "btnAim";
            this.btnAim.Size = new System.Drawing.Size(215, 50);
            this.btnAim.TabIndex = 1;
            this.btnAim.Text = "Aim";
            this.btnAim.UseVisualStyleBackColor = true;
            this.btnAim.Click += new System.EventHandler(this.BtnAim_Click);
            // 
            // btnVisual
            // 
            this.btnVisual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisual.FlatAppearance.BorderSize = 0;
            this.btnVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVisual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVisual.Location = new System.Drawing.Point(3, 115);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Size = new System.Drawing.Size(215, 50);
            this.btnVisual.TabIndex = 2;
            this.btnVisual.Text = "Visual";
            this.btnVisual.UseVisualStyleBackColor = true;
            this.btnVisual.Click += new System.EventHandler(this.BtnVisual_Click);
            // 
            // btnMisc
            // 
            this.btnMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisc.FlatAppearance.BorderSize = 0;
            this.btnMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMisc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMisc.Location = new System.Drawing.Point(3, 171);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(215, 50);
            this.btnMisc.TabIndex = 3;
            this.btnMisc.Text = "Misc";
            this.btnMisc.UseVisualStyleBackColor = true;
            this.btnMisc.Click += new System.EventHandler(this.BtnMisc_Click);
            // 
            // btnTrolling
            // 
            this.btnTrolling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrolling.FlatAppearance.BorderSize = 0;
            this.btnTrolling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrolling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrolling.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrolling.Location = new System.Drawing.Point(3, 227);
            this.btnTrolling.Name = "btnTrolling";
            this.btnTrolling.Size = new System.Drawing.Size(215, 50);
            this.btnTrolling.TabIndex = 4;
            this.btnTrolling.Text = "Trolling";
            this.btnTrolling.UseVisualStyleBackColor = true;
            this.btnTrolling.Click += new System.EventHandler(this.BtnTrolling_Click);
            // 
            // btnSkinChanger
            // 
            this.btnSkinChanger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSkinChanger.FlatAppearance.BorderSize = 0;
            this.btnSkinChanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkinChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkinChanger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSkinChanger.Location = new System.Drawing.Point(3, 283);
            this.btnSkinChanger.Name = "btnSkinChanger";
            this.btnSkinChanger.Size = new System.Drawing.Size(215, 50);
            this.btnSkinChanger.TabIndex = 5;
            this.btnSkinChanger.Text = "Skin Changer";
            this.btnSkinChanger.UseVisualStyleBackColor = true;
            this.btnSkinChanger.Click += new System.EventHandler(this.BtnSkinChanger_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(781, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.footer.Controls.Add(this.labelfooter);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.footer.Location = new System.Drawing.Point(220, 538);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(648, 50);
            this.footer.TabIndex = 7;
            // 
            // labelfooter
            // 
            this.labelfooter.AutoSize = true;
            this.labelfooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelfooter.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelfooter.Location = new System.Drawing.Point(279, 10);
            this.labelfooter.Name = "labelfooter";
            this.labelfooter.Size = new System.Drawing.Size(0, 31);
            this.labelfooter.TabIndex = 0;
            // 
            // bhop
            // 
            this.bhop.AutoSize = true;
            this.bhop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bhop.Location = new System.Drawing.Point(262, 55);
            this.bhop.Name = "bhop";
            this.bhop.Size = new System.Drawing.Size(76, 17);
            this.bhop.TabIndex = 8;
            this.bhop.Text = "BunnyHop";
            this.bhop.UseVisualStyleBackColor = true;
            this.bhop.Visible = false;
            this.bhop.CheckedChanged += new System.EventHandler(this.Bhop_CheckedChanged);
            // 
            // noFlash
            // 
            this.noFlash.AutoSize = true;
            this.noFlash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noFlash.Location = new System.Drawing.Point(262, 124);
            this.noFlash.Name = "noFlash";
            this.noFlash.Size = new System.Drawing.Size(65, 17);
            this.noFlash.TabIndex = 9;
            this.noFlash.Text = "NoFlash";
            this.noFlash.UseVisualStyleBackColor = true;
            this.noFlash.Visible = false;
            this.noFlash.CheckedChanged += new System.EventHandler(this.NoFlash_CheckedChanged);
            // 
            // TriggerCombo
            // 
            this.TriggerCombo.DisplayMember = "None";
            this.TriggerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TriggerCombo.FormattingEnabled = true;
            this.TriggerCombo.Items.AddRange(new object[] {
            "None",
            "ALT",
            "F"});
            this.TriggerCombo.Location = new System.Drawing.Point(378, 88);
            this.TriggerCombo.Name = "TriggerCombo";
            this.TriggerCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TriggerCombo.Size = new System.Drawing.Size(121, 21);
            this.TriggerCombo.TabIndex = 10;
            this.TriggerCombo.ValueMember = "None";
            this.TriggerCombo.Visible = false;
            this.TriggerCombo.SelectedIndexChanged += new System.EventHandler(this.TriggerCombo_SelectedIndexChanged);
            // 
            // TriggerBotCheck
            // 
            this.TriggerBotCheck.AutoSize = true;
            this.TriggerBotCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TriggerBotCheck.Location = new System.Drawing.Point(262, 90);
            this.TriggerBotCheck.Name = "TriggerBotCheck";
            this.TriggerBotCheck.Size = new System.Drawing.Size(75, 17);
            this.TriggerBotCheck.TabIndex = 11;
            this.TriggerBotCheck.Text = "TriggerBot";
            this.TriggerBotCheck.UseVisualStyleBackColor = true;
            this.TriggerBotCheck.Visible = false;
            this.TriggerBotCheck.CheckedChanged += new System.EventHandler(this.TriggerBotCheck_CheckedChanged);
            // 
            // GlowESP
            // 
            this.GlowESP.AutoSize = true;
            this.GlowESP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GlowESP.Location = new System.Drawing.Point(262, 55);
            this.GlowESP.Name = "GlowESP";
            this.GlowESP.Size = new System.Drawing.Size(71, 17);
            this.GlowESP.TabIndex = 12;
            this.GlowESP.Text = "GlowESP";
            this.GlowESP.UseVisualStyleBackColor = true;
            this.GlowESP.Visible = false;
            this.GlowESP.CheckedChanged += new System.EventHandler(this.GlowESP_CheckedChanged);
            // 
            // RadarBox
            // 
            this.RadarBox.AutoSize = true;
            this.RadarBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadarBox.Location = new System.Drawing.Point(262, 92);
            this.RadarBox.Name = "RadarBox";
            this.RadarBox.Size = new System.Drawing.Size(76, 17);
            this.RadarBox.TabIndex = 13;
            this.RadarBox.Text = "RadarESP";
            this.RadarBox.UseVisualStyleBackColor = true;
            this.RadarBox.Visible = false;
            this.RadarBox.CheckedChanged += new System.EventHandler(this.RadarBox_CheckedChanged);
            // 
            // CustomFOVTrack
            // 
            this.CustomFOVTrack.LargeChange = 20;
            this.CustomFOVTrack.Location = new System.Drawing.Point(262, 183);
            this.CustomFOVTrack.Maximum = 200;
            this.CustomFOVTrack.Name = "CustomFOVTrack";
            this.CustomFOVTrack.Size = new System.Drawing.Size(372, 45);
            this.CustomFOVTrack.SmallChange = 10;
            this.CustomFOVTrack.TabIndex = 14;
            this.CustomFOVTrack.TickFrequency = 5;
            this.CustomFOVTrack.Value = 110;
            this.CustomFOVTrack.Visible = false;
            this.CustomFOVTrack.Scroll += new System.EventHandler(this.CustomFOVTrack_Scroll);
            // 
            // CustomFOVBox
            // 
            this.CustomFOVBox.AutoSize = true;
            this.CustomFOVBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomFOVBox.Location = new System.Drawing.Point(262, 160);
            this.CustomFOVBox.Name = "CustomFOVBox";
            this.CustomFOVBox.Size = new System.Drawing.Size(82, 17);
            this.CustomFOVBox.TabIndex = 15;
            this.CustomFOVBox.Text = "CustomFOV";
            this.CustomFOVBox.UseVisualStyleBackColor = true;
            this.CustomFOVBox.Visible = false;
            this.CustomFOVBox.CheckedChanged += new System.EventHandler(this.CustomFOVBox_CheckedChanged);
            // 
            // CustomFOVLabel
            // 
            this.CustomFOVLabel.AutoSize = true;
            this.CustomFOVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomFOVLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.CustomFOVLabel.Location = new System.Drawing.Point(670, 183);
            this.CustomFOVLabel.Name = "CustomFOVLabel";
            this.CustomFOVLabel.Size = new System.Drawing.Size(45, 25);
            this.CustomFOVLabel.TabIndex = 16;
            this.CustomFOVLabel.Text = "110";
            this.CustomFOVLabel.Visible = false;
            // 
            // GlowESPCombo
            // 
            this.GlowESPCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GlowESPCombo.FormattingEnabled = true;
            this.GlowESPCombo.Items.AddRange(new object[] {
            "Color",
            "HP Color",
            "Legit Glow",
            "Legit HP Glow"});
            this.GlowESPCombo.Location = new System.Drawing.Point(378, 55);
            this.GlowESPCombo.Name = "GlowESPCombo";
            this.GlowESPCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GlowESPCombo.Size = new System.Drawing.Size(121, 21);
            this.GlowESPCombo.TabIndex = 17;
            this.GlowESPCombo.Visible = false;
            this.GlowESPCombo.SelectedIndexChanged += new System.EventHandler(this.GlowESPCombo_SelectedIndexChanged);
            // 
            // AimbotBox
            // 
            this.AimbotBox.AutoSize = true;
            this.AimbotBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AimbotBox.Location = new System.Drawing.Point(262, 55);
            this.AimbotBox.Name = "AimbotBox";
            this.AimbotBox.Size = new System.Drawing.Size(89, 17);
            this.AimbotBox.TabIndex = 18;
            this.AimbotBox.Text = "Aimbot (Beta)";
            this.AimbotBox.UseVisualStyleBackColor = true;
            this.AimbotBox.Visible = false;
            this.AimbotBox.CheckedChanged += new System.EventHandler(this.AimbotBox_CheckedChanged);
            // 
            // AimbotCombo
            // 
            this.AimbotCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AimbotCombo.FormattingEnabled = true;
            this.AimbotCombo.Items.AddRange(new object[] {
            "Recoil Only",
            "ALT",
            "F"});
            this.AimbotCombo.Location = new System.Drawing.Point(378, 55);
            this.AimbotCombo.Name = "AimbotCombo";
            this.AimbotCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AimbotCombo.Size = new System.Drawing.Size(121, 21);
            this.AimbotCombo.TabIndex = 19;
            this.AimbotCombo.Visible = false;
            this.AimbotCombo.SelectedIndexChanged += new System.EventHandler(this.AimbotCombo_SelectedIndexChanged);
            // 
            // TriggerBotDelayBox
            // 
            this.TriggerBotDelayBox.Location = new System.Drawing.Point(528, 88);
            this.TriggerBotDelayBox.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.TriggerBotDelayBox.Name = "TriggerBotDelayBox";
            this.TriggerBotDelayBox.Size = new System.Drawing.Size(63, 20);
            this.TriggerBotDelayBox.TabIndex = 20;
            this.TriggerBotDelayBox.Visible = false;
            this.TriggerBotDelayBox.ValueChanged += new System.EventHandler(this.TriggerBotDelayBox_ValueChanged);
            // 
            // TriggerBotDelayLabel
            // 
            this.TriggerBotDelayLabel.AutoSize = true;
            this.TriggerBotDelayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TriggerBotDelayLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.TriggerBotDelayLabel.Location = new System.Drawing.Point(609, 84);
            this.TriggerBotDelayLabel.Name = "TriggerBotDelayLabel";
            this.TriggerBotDelayLabel.Size = new System.Drawing.Size(93, 25);
            this.TriggerBotDelayLabel.TabIndex = 21;
            this.TriggerBotDelayLabel.Text = "ms Delay";
            this.TriggerBotDelayLabel.Visible = false;
            // 
            // StrafeCheckBox
            // 
            this.StrafeCheckBox.AutoSize = true;
            this.StrafeCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StrafeCheckBox.Location = new System.Drawing.Point(262, 88);
            this.StrafeCheckBox.Name = "StrafeCheckBox";
            this.StrafeCheckBox.Size = new System.Drawing.Size(76, 17);
            this.StrafeCheckBox.TabIndex = 22;
            this.StrafeCheckBox.Text = "AutoStrafe";
            this.StrafeCheckBox.UseVisualStyleBackColor = true;
            this.StrafeCheckBox.Visible = false;
            this.StrafeCheckBox.CheckedChanged += new System.EventHandler(this.StrafeCheckBox_CheckedChanged);
            // 
            // Hitsoundcheckbox
            // 
            this.Hitsoundcheckbox.AutoSize = true;
            this.Hitsoundcheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hitsoundcheckbox.Location = new System.Drawing.Point(262, 124);
            this.Hitsoundcheckbox.Name = "Hitsoundcheckbox";
            this.Hitsoundcheckbox.Size = new System.Drawing.Size(68, 17);
            this.Hitsoundcheckbox.TabIndex = 23;
            this.Hitsoundcheckbox.Text = "Hitsound";
            this.Hitsoundcheckbox.UseVisualStyleBackColor = true;
            this.Hitsoundcheckbox.Visible = false;
            this.Hitsoundcheckbox.CheckedChanged += new System.EventHandler(this.Hitsoundcheckbox_CheckedChanged);
            // 
            // NiggerButton
            // 
            this.NiggerButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.NiggerButton.FlatAppearance.BorderSize = 2;
            this.NiggerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NiggerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NiggerButton.Location = new System.Drawing.Point(262, 257);
            this.NiggerButton.Name = "NiggerButton";
            this.NiggerButton.Size = new System.Drawing.Size(114, 44);
            this.NiggerButton.TabIndex = 24;
            this.NiggerButton.Text = "Niggerize All Players";
            this.NiggerButton.UseVisualStyleBackColor = true;
            this.NiggerButton.Visible = false;
            this.NiggerButton.Click += new System.EventHandler(this.NiggerButton_Click);
            // 
            // SkeetColor
            // 
            this.SkeetColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.SkeetColor.Location = new System.Drawing.Point(220, 0);
            this.SkeetColor.Name = "SkeetColor";
            this.SkeetColor.Size = new System.Drawing.Size(648, 10);
            this.SkeetColor.TabIndex = 25;
            // 
            // SkeetColorTimer
            // 
            this.SkeetColorTimer.Enabled = true;
            this.SkeetColorTimer.Interval = 2000;
            this.SkeetColorTimer.Tick += new System.EventHandler(this.SkeetColorTimer_Tick);
            // 
            // KnifeChangerBox
            // 
            this.KnifeChangerBox.AutoSize = true;
            this.KnifeChangerBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KnifeChangerBox.Location = new System.Drawing.Point(622, 505);
            this.KnifeChangerBox.Name = "KnifeChangerBox";
            this.KnifeChangerBox.Size = new System.Drawing.Size(93, 17);
            this.KnifeChangerBox.TabIndex = 26;
            this.KnifeChangerBox.Text = "Knife Changer";
            this.KnifeChangerBox.UseVisualStyleBackColor = true;
            this.KnifeChangerBox.Visible = false;
            this.KnifeChangerBox.CheckedChanged += new System.EventHandler(this.KnifeChangerBox_CheckedChanged);
            // 
            // KnifeChangerCombo
            // 
            this.KnifeChangerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KnifeChangerCombo.FormattingEnabled = true;
            this.KnifeChangerCombo.Items.AddRange(new object[] {
            "Karambit",
            "Butterfly",
            "Flip Knife",
            "Gut Knife",
            "M9 Bayonet",
            "Skeleton",
            "Talon Knife",
            "Stiletto"});
            this.KnifeChangerCombo.Location = new System.Drawing.Point(735, 503);
            this.KnifeChangerCombo.Name = "KnifeChangerCombo";
            this.KnifeChangerCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KnifeChangerCombo.Size = new System.Drawing.Size(121, 21);
            this.KnifeChangerCombo.TabIndex = 27;
            this.KnifeChangerCombo.Visible = false;
            this.KnifeChangerCombo.SelectedIndexChanged += new System.EventHandler(this.KnifeChangerCombo_SelectedIndexChanged);
            // 
            // btnForceUpdate
            // 
            this.btnForceUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnForceUpdate.FlatAppearance.BorderSize = 2;
            this.btnForceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForceUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForceUpdate.Location = new System.Drawing.Point(240, 488);
            this.btnForceUpdate.Name = "btnForceUpdate";
            this.btnForceUpdate.Size = new System.Drawing.Size(114, 44);
            this.btnForceUpdate.TabIndex = 28;
            this.btnForceUpdate.Text = "Force Update";
            this.btnForceUpdate.UseVisualStyleBackColor = true;
            this.btnForceUpdate.Visible = false;
            this.btnForceUpdate.Click += new System.EventHandler(this.BtnForceUpdate_Click);
            // 
            // SkinChangerCheckBox
            // 
            this.SkinChangerCheckBox.AutoSize = true;
            this.SkinChangerCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkinChangerCheckBox.Location = new System.Drawing.Point(433, 505);
            this.SkinChangerCheckBox.Name = "SkinChangerCheckBox";
            this.SkinChangerCheckBox.Size = new System.Drawing.Size(59, 17);
            this.SkinChangerCheckBox.TabIndex = 29;
            this.SkinChangerCheckBox.Text = "Enable";
            this.SkinChangerCheckBox.UseVisualStyleBackColor = true;
            this.SkinChangerCheckBox.Visible = false;
            this.SkinChangerCheckBox.CheckedChanged += new System.EventHandler(this.SkinChangerCheckBox_CheckedChanged);
            // 
            // PistolsLabel
            // 
            this.PistolsLabel.AutoSize = true;
            this.PistolsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PistolsLabel.Location = new System.Drawing.Point(555, 271);
            this.PistolsLabel.Name = "PistolsLabel";
            this.PistolsLabel.Size = new System.Drawing.Size(201, 13);
            this.PistolsLabel.TabIndex = 30;
            this.PistolsLabel.Text = "Pistols WORK IN FUCKING PROGRESS";
            this.PistolsLabel.Visible = false;
            // 
            // DesertEagleLabel
            // 
            this.DesertEagleLabel.AutoSize = true;
            this.DesertEagleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DesertEagleLabel.Location = new System.Drawing.Point(540, 303);
            this.DesertEagleLabel.Name = "DesertEagleLabel";
            this.DesertEagleLabel.Size = new System.Drawing.Size(68, 13);
            this.DesertEagleLabel.TabIndex = 32;
            this.DesertEagleLabel.Text = "Desert Eagle";
            this.DesertEagleLabel.Visible = false;
            // 
            // Glock18Label
            // 
            this.Glock18Label.AutoSize = true;
            this.Glock18Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Glock18Label.Location = new System.Drawing.Point(542, 331);
            this.Glock18Label.Name = "Glock18Label";
            this.Glock18Label.Size = new System.Drawing.Size(50, 13);
            this.Glock18Label.TabIndex = 33;
            this.Glock18Label.Text = "Glock-18";
            this.Glock18Label.Visible = false;
            // 
            // DesertEagleComboBox
            // 
            this.DesertEagleComboBox.DisplayMember = "None";
            this.DesertEagleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DesertEagleComboBox.FormattingEnabled = true;
            this.DesertEagleComboBox.Items.AddRange(new object[] {
            "None",
            "Blaze",
            "Blue Ply",
            "Bronze Deco",
            "Cobalt Disruption",
            "Code Red",
            "Conspiracy",
            "Corinthian",
            "Crimson Web",
            "Directive",
            "Emerald Jörmungandr",
            "Golden Koi",
            "Hand Cannon",
            "Heirloom",
            "Hypnotic",
            "Kumicho Dragon",
            "Light Rail",
            "Mecha Industries",
            "Meteorite",
            "Midnight Storm",
            "Mudder",
            "Naga",
            "Night",
            "Oxide Blaze",
            "Pilot",
            "Printstream",
            "Sunset Storm 壱",
            "Sunset Storm 弐",
            "Urban DDPAT",
            "Urban Rubble"});
            this.DesertEagleComboBox.Location = new System.Drawing.Point(614, 300);
            this.DesertEagleComboBox.Name = "DesertEagleComboBox";
            this.DesertEagleComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DesertEagleComboBox.Size = new System.Drawing.Size(100, 21);
            this.DesertEagleComboBox.TabIndex = 34;
            this.DesertEagleComboBox.ValueMember = "None";
            this.DesertEagleComboBox.Visible = false;
            this.DesertEagleComboBox.SelectedIndexChanged += new System.EventHandler(this.DesertEagleComboBox_SelectedIndexChanged);
            // 
            // Glock18ComboBox
            // 
            this.Glock18ComboBox.DisplayMember = "None";
            this.Glock18ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Glock18ComboBox.FormattingEnabled = true;
            this.Glock18ComboBox.Items.AddRange(new object[] {
            "None",
            "Blue Fissure",
            "Brass",
            "Bullet Queen",
            "Bunsen Burner",
            "Candy Apple",
            "Catacombs",
            "Death Rattle",
            "Dragon Tattoo",
            "Fade",
            "Grinder",
            "Groundwater",
            "High Beam",
            "Ironwork",
            "Moonrise",
            "Night",
            "Nuclear Garden",
            "Off World",
            "Oxide Blaze",
            "Reactor",
            "Royal Legion",
            "Sacrifice",
            "Sand Dune",
            "Steel Disruption",
            "Synth Leaf",
            "Twilight Galaxy",
            "Vogue",
            "Warhawk",
            "Wasteland Rebel",
            "Water Elemental",
            "Weasel",
            "Wraiths"});
            this.Glock18ComboBox.Location = new System.Drawing.Point(614, 327);
            this.Glock18ComboBox.Name = "Glock18ComboBox";
            this.Glock18ComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Glock18ComboBox.Size = new System.Drawing.Size(100, 21);
            this.Glock18ComboBox.TabIndex = 35;
            this.Glock18ComboBox.ValueMember = "None";
            this.Glock18ComboBox.Visible = false;
            this.Glock18ComboBox.SelectedIndexChanged += new System.EventHandler(this.Glock18ComboBox_SelectedIndexChanged);
            // 
            // USPSLabel
            // 
            this.USPSLabel.AutoSize = true;
            this.USPSLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.USPSLabel.Location = new System.Drawing.Point(542, 416);
            this.USPSLabel.Name = "USPSLabel";
            this.USPSLabel.Size = new System.Drawing.Size(39, 13);
            this.USPSLabel.TabIndex = 36;
            this.USPSLabel.Text = "USP-S";
            this.USPSLabel.Visible = false;
            // 
            // USPSComboBox
            // 
            this.USPSComboBox.DisplayMember = "None";
            this.USPSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.USPSComboBox.FormattingEnabled = true;
            this.USPSComboBox.Items.AddRange(new object[] {
            "None",
            "Blood Tiger",
            "Blueprint",
            "Business Class",
            "Caiman",
            "Check Engine",
            "Cortex",
            "Cyrex",
            "Dark Water",
            "Flashback",
            "Forest Leaves",
            "Guardian",
            "Kill Confirmed",
            "Lead Conduit",
            "Neo-Noir",
            "Night Ops",
            "Orion",
            "Overgrowth",
            "Para Green",
            "Pathfinder",
            "Road Rash",
            "Royal Blue",
            "Serum",
            "Stainless",
            "Torque"});
            this.USPSComboBox.Location = new System.Drawing.Point(614, 408);
            this.USPSComboBox.Name = "USPSComboBox";
            this.USPSComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.USPSComboBox.Size = new System.Drawing.Size(100, 21);
            this.USPSComboBox.TabIndex = 37;
            this.USPSComboBox.ValueMember = "None";
            this.USPSComboBox.Visible = false;
            this.USPSComboBox.SelectedIndexChanged += new System.EventHandler(this.USPSComboBox_SelectedIndexChanged);
            // 
            // P250Label
            // 
            this.P250Label.AutoSize = true;
            this.P250Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P250Label.Location = new System.Drawing.Point(542, 389);
            this.P250Label.Name = "P250Label";
            this.P250Label.Size = new System.Drawing.Size(35, 13);
            this.P250Label.TabIndex = 38;
            this.P250Label.Text = "P250 ";
            this.P250Label.Visible = false;
            // 
            // P250ComboBox
            // 
            this.P250ComboBox.DisplayMember = "None";
            this.P250ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P250ComboBox.FormattingEnabled = true;
            this.P250ComboBox.Items.AddRange(new object[] {
            "None",
            "Asiimov",
            "Bone Mask",
            "Boreal Forest",
            "Cartel",
            "Cassette",
            "Contamination",
            "Crimson Kimono",
            "Dark Filigree",
            "Exchanger",
            "Facets",
            "Facility Draft",
            "Franklin",
            "Gunsmoke",
            "Hive",
            "Inferno",
            "Iron Clad",
            "Mehndi",
            "Metallic DDPAT",
            "Mint Kimono",
            "Modern Hunter",
            "Muertos",
            "Nevermore",
            "Nuclear Threat",
            "Red Rock",
            "Ripple",
            "Sand Dune",
            "See Ya Later",
            "Splash",
            "Steel Disruption",
            "Supernova",
            "Undertow",
            "Valence",
            "Verdigris",
            "Vino Primo",
            "Whiteout",
            "Wingshot",
            "X-Ray"});
            this.P250ComboBox.Location = new System.Drawing.Point(614, 381);
            this.P250ComboBox.Name = "P250ComboBox";
            this.P250ComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.P250ComboBox.Size = new System.Drawing.Size(100, 21);
            this.P250ComboBox.TabIndex = 39;
            this.P250ComboBox.ValueMember = "None";
            this.P250ComboBox.Visible = false;
            this.P250ComboBox.SelectedIndexChanged += new System.EventHandler(this.P250ComboBox_SelectedIndexChanged);
            // 
            // P2000Label
            // 
            this.P2000Label.AutoSize = true;
            this.P2000Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P2000Label.Location = new System.Drawing.Point(542, 357);
            this.P2000Label.Name = "P2000Label";
            this.P2000Label.Size = new System.Drawing.Size(38, 13);
            this.P2000Label.TabIndex = 40;
            this.P2000Label.Text = "P2000";
            this.P2000Label.Visible = false;
            // 
            // P2000ComboBox
            // 
            this.P2000ComboBox.DisplayMember = "None";
            this.P2000ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P2000ComboBox.FormattingEnabled = true;
            this.P2000ComboBox.Items.AddRange(new object[] {
            "None",
            "Acid Etched",
            "Amber Fade",
            "Chainmail",
            "Coach Class",
            "Corticera",
            "Fire Elemental",
            "Gnarled",
            "Granite Marbleized",
            "Grassland",
            "Grassland Leaves",
            "Handgun",
            "Imperial",
            "Imperial Dragon",
            "Ivory",
            "Obsidian",
            "Ocean Foam",
            "Oceanic",
            "Pathfinder",
            "Pulse",
            "Red FragCam",
            "Scorpion",
            "Silver",
            "Turf",
            "Urban Hazard",
            "Woodsman"});
            this.P2000ComboBox.Location = new System.Drawing.Point(614, 354);
            this.P2000ComboBox.Name = "P2000ComboBox";
            this.P2000ComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.P2000ComboBox.Size = new System.Drawing.Size(100, 21);
            this.P2000ComboBox.TabIndex = 41;
            this.P2000ComboBox.ValueMember = "None";
            this.P2000ComboBox.Visible = false;
            this.P2000ComboBox.SelectedIndexChanged += new System.EventHandler(this.P2000ComboBox_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(868, 588);
            this.Controls.Add(this.P2000ComboBox);
            this.Controls.Add(this.P2000Label);
            this.Controls.Add(this.P250ComboBox);
            this.Controls.Add(this.P250Label);
            this.Controls.Add(this.USPSComboBox);
            this.Controls.Add(this.USPSLabel);
            this.Controls.Add(this.Glock18ComboBox);
            this.Controls.Add(this.DesertEagleComboBox);
            this.Controls.Add(this.Glock18Label);
            this.Controls.Add(this.DesertEagleLabel);
            this.Controls.Add(this.PistolsLabel);
            this.Controls.Add(this.SkinChangerCheckBox);
            this.Controls.Add(this.btnForceUpdate);
            this.Controls.Add(this.KnifeChangerCombo);
            this.Controls.Add(this.SkeetColor);
            this.Controls.Add(this.NiggerButton);
            this.Controls.Add(this.Hitsoundcheckbox);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.StrafeCheckBox);
            this.Controls.Add(this.TriggerBotDelayLabel);
            this.Controls.Add(this.TriggerBotDelayBox);
            this.Controls.Add(this.CustomFOVLabel);
            this.Controls.Add(this.CustomFOVBox);
            this.Controls.Add(this.CustomFOVTrack);
            this.Controls.Add(this.TriggerCombo);
            this.Controls.Add(this.noFlash);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TriggerBotCheck);
            this.Controls.Add(this.RadarBox);
            this.Controls.Add(this.AimbotCombo);
            this.Controls.Add(this.GlowESPCombo);
            this.Controls.Add(this.KnifeChangerBox);
            this.Controls.Add(this.bhop);
            this.Controls.Add(this.AimbotBox);
            this.Controls.Add(this.GlowESP);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "C# External AlphaWolf";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.SideBar.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomFOVTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerBotDelayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button btnAim;
        private System.Windows.Forms.Button btnVisual;
        private System.Windows.Forms.Button btnMisc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label PanelLabel;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label labelfooter;
        private System.Windows.Forms.CheckBox bhop;
        private System.Windows.Forms.CheckBox noFlash;
        private System.Windows.Forms.ComboBox TriggerCombo;
        private System.Windows.Forms.CheckBox TriggerBotCheck;
        private System.Windows.Forms.CheckBox GlowESP;
        private System.Windows.Forms.CheckBox RadarBox;
        private System.Windows.Forms.TrackBar CustomFOVTrack;
        private System.Windows.Forms.CheckBox CustomFOVBox;
        private System.Windows.Forms.Label CustomFOVLabel;
        private System.Windows.Forms.ComboBox GlowESPCombo;
        private System.Windows.Forms.CheckBox AimbotBox;
        private System.Windows.Forms.ComboBox AimbotCombo;
        private System.Windows.Forms.NumericUpDown TriggerBotDelayBox;
        private System.Windows.Forms.Label TriggerBotDelayLabel;
        private System.Windows.Forms.CheckBox StrafeCheckBox;
        private System.Windows.Forms.CheckBox Hitsoundcheckbox;
        private System.Windows.Forms.Button NiggerButton;
        private System.Windows.Forms.Button btnTrolling;
        private System.Windows.Forms.FlowLayoutPanel SkeetColor;
        private System.Windows.Forms.Timer SkeetColorTimer;
        private System.Windows.Forms.Button btnSkinChanger;
        private System.Windows.Forms.CheckBox KnifeChangerBox;
        private System.Windows.Forms.ComboBox KnifeChangerCombo;
        private System.Windows.Forms.Button btnForceUpdate;
        private System.Windows.Forms.CheckBox SkinChangerCheckBox;
        private System.Windows.Forms.Label PistolsLabel;
        private System.Windows.Forms.Label DesertEagleLabel;
        private System.Windows.Forms.Label Glock18Label;
        private System.Windows.Forms.ComboBox DesertEagleComboBox;
        private System.Windows.Forms.ComboBox Glock18ComboBox;
        private System.Windows.Forms.Label USPSLabel;
        private System.Windows.Forms.ComboBox USPSComboBox;
        private System.Windows.Forms.Label P250Label;
        private System.Windows.Forms.ComboBox P250ComboBox;
        private System.Windows.Forms.Label P2000Label;
        private System.Windows.Forms.ComboBox P2000ComboBox;
    }
}

