namespace StreamDeck
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DarkModeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.OBSButton = new MaterialSkin.Controls.MaterialButton();
            this.DiscordButton = new MaterialSkin.Controls.MaterialButton();
            this.SoundCloudBlutton = new MaterialSkin.Controls.MaterialButton();
            this.StartStreamButton = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.programLabel = new System.Windows.Forms.Label();
            this.StreamManagerButton = new MaterialSkin.Controls.MaterialButton();
            this.crabrave = new MaterialSkin.Controls.MaterialButton();
            this.Airhorn = new MaterialSkin.Controls.MaterialButton();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.soundsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DarkModeSwitch
            // 
            this.DarkModeSwitch.AutoSize = true;
            this.DarkModeSwitch.Depth = 0;
            this.DarkModeSwitch.Location = new System.Drawing.Point(395, 93);
            this.DarkModeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.DarkModeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkModeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkModeSwitch.Name = "DarkModeSwitch";
            this.DarkModeSwitch.Ripple = true;
            this.DarkModeSwitch.Size = new System.Drawing.Size(94, 37);
            this.DarkModeSwitch.TabIndex = 6;
            this.DarkModeSwitch.Text = "Light";
            this.DarkModeSwitch.UseVisualStyleBackColor = true;
            this.DarkModeSwitch.CheckedChanged += new System.EventHandler(this.DarkModeSwitch_CheckedChanged);
            // 
            // OBSButton
            // 
            this.OBSButton.AutoSize = false;
            this.OBSButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OBSButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OBSButton.Depth = 0;
            this.OBSButton.HighEmphasis = true;
            this.OBSButton.Icon = null;
            this.OBSButton.Location = new System.Drawing.Point(191, 93);
            this.OBSButton.Margin = new System.Windows.Forms.Padding(0);
            this.OBSButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OBSButton.Name = "OBSButton";
            this.OBSButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OBSButton.Size = new System.Drawing.Size(64, 36);
            this.OBSButton.TabIndex = 7;
            this.OBSButton.Text = "OBS";
            this.OBSButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OBSButton.UseAccentColor = false;
            this.OBSButton.UseVisualStyleBackColor = true;
            this.OBSButton.Click += new System.EventHandler(this.OBSButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.AutoSize = false;
            this.DiscordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiscordButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DiscordButton.Depth = 0;
            this.DiscordButton.HighEmphasis = true;
            this.DiscordButton.Icon = null;
            this.DiscordButton.Location = new System.Drawing.Point(191, 45);
            this.DiscordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DiscordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DiscordButton.Size = new System.Drawing.Size(83, 36);
            this.DiscordButton.TabIndex = 9;
            this.DiscordButton.Text = "Discord";
            this.DiscordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DiscordButton.UseAccentColor = false;
            this.DiscordButton.UseVisualStyleBackColor = true;
            this.DiscordButton.Click += new System.EventHandler(this.Discord_Click);
            // 
            // SoundCloudBlutton
            // 
            this.SoundCloudBlutton.AutoSize = false;
            this.SoundCloudBlutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SoundCloudBlutton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SoundCloudBlutton.Depth = 0;
            this.SoundCloudBlutton.HighEmphasis = true;
            this.SoundCloudBlutton.Icon = null;
            this.SoundCloudBlutton.Location = new System.Drawing.Point(24, 141);
            this.SoundCloudBlutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SoundCloudBlutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SoundCloudBlutton.Name = "SoundCloudBlutton";
            this.SoundCloudBlutton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SoundCloudBlutton.Size = new System.Drawing.Size(121, 36);
            this.SoundCloudBlutton.TabIndex = 10;
            this.SoundCloudBlutton.Text = "Sound Cloud";
            this.SoundCloudBlutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SoundCloudBlutton.UseAccentColor = false;
            this.SoundCloudBlutton.UseVisualStyleBackColor = true;
            this.SoundCloudBlutton.Click += new System.EventHandler(this.SoundCloud_Click);
            // 
            // StartStreamButton
            // 
            this.StartStreamButton.AutoSize = false;
            this.StartStreamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartStreamButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartStreamButton.Depth = 0;
            this.StartStreamButton.HighEmphasis = true;
            this.StartStreamButton.Icon = null;
            this.StartStreamButton.Location = new System.Drawing.Point(24, 45);
            this.StartStreamButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartStreamButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartStreamButton.Name = "StartStreamButton";
            this.StartStreamButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartStreamButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartStreamButton.Size = new System.Drawing.Size(128, 36);
            this.StartStreamButton.TabIndex = 11;
            this.StartStreamButton.Text = "Start Stream";
            this.StartStreamButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartStreamButton.UseAccentColor = false;
            this.StartStreamButton.UseVisualStyleBackColor = true;
            this.StartStreamButton.Click += new System.EventHandler(this.StartStream_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.programLabel);
            this.panel1.Controls.Add(this.OBSButton);
            this.panel1.Controls.Add(this.StreamManagerButton);
            this.panel1.Controls.Add(this.SoundCloudBlutton);
            this.panel1.Controls.Add(this.StartStreamButton);
            this.panel1.Controls.Add(this.DiscordButton);
            this.panel1.Location = new System.Drawing.Point(37, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 346);
            this.panel1.TabIndex = 12;
            // 
            // programLabel
            // 
            this.programLabel.AutoSize = true;
            this.programLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel.Location = new System.Drawing.Point(19, -1);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(104, 25);
            this.programLabel.TabIndex = 16;
            this.programLabel.Text = "Programs";
            // 
            // StreamManagerButton
            // 
            this.StreamManagerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StreamManagerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StreamManagerButton.Depth = 0;
            this.StreamManagerButton.HighEmphasis = true;
            this.StreamManagerButton.Icon = null;
            this.StreamManagerButton.Location = new System.Drawing.Point(24, 93);
            this.StreamManagerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StreamManagerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StreamManagerButton.Name = "StreamManagerButton";
            this.StreamManagerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StreamManagerButton.Size = new System.Drawing.Size(153, 36);
            this.StreamManagerButton.TabIndex = 13;
            this.StreamManagerButton.Text = "Stream Manager";
            this.StreamManagerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StreamManagerButton.UseAccentColor = false;
            this.StreamManagerButton.UseVisualStyleBackColor = true;
            this.StreamManagerButton.Click += new System.EventHandler(this.Stream_Manager_Click);
            // 
            // crabrave
            // 
            this.crabrave.AutoSize = false;
            this.crabrave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crabrave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.crabrave.Depth = 0;
            this.crabrave.HighEmphasis = true;
            this.crabrave.Icon = null;
            this.crabrave.Location = new System.Drawing.Point(24, 37);
            this.crabrave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.crabrave.MouseState = MaterialSkin.MouseState.HOVER;
            this.crabrave.Name = "crabrave";
            this.crabrave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.crabrave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.crabrave.Size = new System.Drawing.Size(128, 36);
            this.crabrave.TabIndex = 15;
            this.crabrave.Text = "Crab Rave";
            this.crabrave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.crabrave.UseAccentColor = false;
            this.crabrave.UseVisualStyleBackColor = true;
            this.crabrave.Click += new System.EventHandler(this.Crabrave_Click);
            // 
            // Airhorn
            // 
            this.Airhorn.AutoSize = false;
            this.Airhorn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Airhorn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Airhorn.Depth = 0;
            this.Airhorn.HighEmphasis = true;
            this.Airhorn.Icon = null;
            this.Airhorn.Location = new System.Drawing.Point(191, 37);
            this.Airhorn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Airhorn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Airhorn.Name = "Airhorn";
            this.Airhorn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Airhorn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Airhorn.Size = new System.Drawing.Size(128, 36);
            this.Airhorn.TabIndex = 14;
            this.Airhorn.Text = "Airhorn";
            this.Airhorn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Airhorn.UseAccentColor = false;
            this.Airhorn.UseVisualStyleBackColor = true;
            this.Airhorn.Click += new System.EventHandler(this.Airhorn_Click);
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsPictureBox.Image")));
            this.settingsPictureBox.Location = new System.Drawing.Point(6, 76);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(33, 35);
            this.settingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPictureBox.TabIndex = 14;
            this.settingsPictureBox.TabStop = false;
            this.settingsPictureBox.Click += new System.EventHandler(this.settingsPictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.soundsLabel);
            this.panel2.Controls.Add(this.Airhorn);
            this.panel2.Controls.Add(this.crabrave);
            this.panel2.Location = new System.Drawing.Point(37, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 148);
            this.panel2.TabIndex = 16;
            // 
            // soundsLabel
            // 
            this.soundsLabel.AutoSize = true;
            this.soundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundsLabel.Location = new System.Drawing.Point(20, 0);
            this.soundsLabel.Name = "soundsLabel";
            this.soundsLabel.Size = new System.Drawing.Size(75, 24);
            this.soundsLabel.TabIndex = 17;
            this.soundsLabel.Text = "Sounds";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settingsPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DarkModeSwitch);
            this.Name = "MainForm";
            this.Text = "Stream Deck";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch DarkModeSwitch;
        private MaterialSkin.Controls.MaterialButton OBSButton;
        private MaterialSkin.Controls.MaterialButton DiscordButton;
        private MaterialSkin.Controls.MaterialButton SoundCloudBlutton;
        private MaterialSkin.Controls.MaterialButton StartStreamButton;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton StreamManagerButton;
        private System.Windows.Forms.PictureBox settingsPictureBox;
        private MaterialSkin.Controls.MaterialButton Airhorn;
        private MaterialSkin.Controls.MaterialButton crabrave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label soundsLabel;
        private System.Windows.Forms.Label programLabel;
    }
}

