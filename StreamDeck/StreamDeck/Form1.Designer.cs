namespace StreamDeck
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DarkModeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.OBSButton = new MaterialSkin.Controls.MaterialButton();
            this.DiscordButton = new MaterialSkin.Controls.MaterialButton();
            this.SoundCloudBlutton = new MaterialSkin.Controls.MaterialButton();
            this.StartStreamButton = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StreamManagerButton = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DarkModeSwitch
            // 
            this.DarkModeSwitch.AutoSize = true;
            this.DarkModeSwitch.Depth = 0;
            this.DarkModeSwitch.Location = new System.Drawing.Point(392, 93);
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
            this.OBSButton.Location = new System.Drawing.Point(191, 72);
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
            this.DiscordButton.Location = new System.Drawing.Point(191, 24);
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
            this.SoundCloudBlutton.Location = new System.Drawing.Point(24, 120);
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
            this.StartStreamButton.Location = new System.Drawing.Point(24, 24);
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
            this.panel1.Controls.Add(this.OBSButton);
            this.panel1.Controls.Add(this.StreamManagerButton);
            this.panel1.Controls.Add(this.SoundCloudBlutton);
            this.panel1.Controls.Add(this.StartStreamButton);
            this.panel1.Controls.Add(this.DiscordButton);
            this.panel1.Location = new System.Drawing.Point(37, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 189);
            this.panel1.TabIndex = 12;
            // 
            // StreamManagerButton
            // 
            this.StreamManagerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StreamManagerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StreamManagerButton.Depth = 0;
            this.StreamManagerButton.HighEmphasis = true;
            this.StreamManagerButton.Icon = null;
            this.StreamManagerButton.Location = new System.Drawing.Point(24, 72);
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(37, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 160);
            this.panel2.TabIndex = 13;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 471);
            this.Controls.Add(this.settingsPictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DarkModeSwitch);
            this.Name = "Form1";
            this.Text = "Stream Deck";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox settingsPictureBox;
    }
}

