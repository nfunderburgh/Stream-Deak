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
            this.OBSButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Discord = new MaterialSkin.Controls.MaterialButton();
            this.SoundCloud = new MaterialSkin.Controls.MaterialButton();
            this.StartStream = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stream_Manager = new MaterialSkin.Controls.MaterialButton();
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
            // OBSButton1
            // 
            this.OBSButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OBSButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OBSButton1.Depth = 0;
            this.OBSButton1.HighEmphasis = true;
            this.OBSButton1.Icon = null;
            this.OBSButton1.Location = new System.Drawing.Point(205, 27);
            this.OBSButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OBSButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.OBSButton1.Name = "OBSButton1";
            this.OBSButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OBSButton1.Size = new System.Drawing.Size(64, 36);
            this.OBSButton1.TabIndex = 7;
            this.OBSButton1.Text = "OBS";
            this.OBSButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OBSButton1.UseAccentColor = false;
            this.OBSButton1.UseVisualStyleBackColor = true;
            this.OBSButton1.Click += new System.EventHandler(this.OBSButton_Click);
            // 
            // Discord
            // 
            this.Discord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Discord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Discord.Depth = 0;
            this.Discord.HighEmphasis = true;
            this.Discord.Icon = null;
            this.Discord.Location = new System.Drawing.Point(186, 87);
            this.Discord.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Discord.MouseState = MaterialSkin.MouseState.HOVER;
            this.Discord.Name = "Discord";
            this.Discord.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Discord.Size = new System.Drawing.Size(83, 36);
            this.Discord.TabIndex = 9;
            this.Discord.Text = "Discord";
            this.Discord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Discord.UseAccentColor = false;
            this.Discord.UseVisualStyleBackColor = true;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // SoundCloud
            // 
            this.SoundCloud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SoundCloud.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SoundCloud.Depth = 0;
            this.SoundCloud.HighEmphasis = true;
            this.SoundCloud.Icon = null;
            this.SoundCloud.Location = new System.Drawing.Point(24, 146);
            this.SoundCloud.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SoundCloud.MouseState = MaterialSkin.MouseState.HOVER;
            this.SoundCloud.Name = "SoundCloud";
            this.SoundCloud.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SoundCloud.Size = new System.Drawing.Size(121, 36);
            this.SoundCloud.TabIndex = 10;
            this.SoundCloud.Text = "Sound Cloud";
            this.SoundCloud.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SoundCloud.UseAccentColor = false;
            this.SoundCloud.UseVisualStyleBackColor = true;
            this.SoundCloud.Click += new System.EventHandler(this.SoundCloud_Click);
            // 
            // StartStream
            // 
            this.StartStream.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartStream.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartStream.Depth = 0;
            this.StartStream.HighEmphasis = true;
            this.StartStream.Icon = null;
            this.StartStream.Location = new System.Drawing.Point(24, 87);
            this.StartStream.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartStream.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartStream.Name = "StartStream";
            this.StartStream.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartStream.Size = new System.Drawing.Size(128, 36);
            this.StartStream.TabIndex = 11;
            this.StartStream.Text = "Start Stream";
            this.StartStream.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartStream.UseAccentColor = false;
            this.StartStream.UseVisualStyleBackColor = true;
            this.StartStream.Click += new System.EventHandler(this.StartStream_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Stream_Manager);
            this.panel1.Controls.Add(this.OBSButton1);
            this.panel1.Controls.Add(this.SoundCloud);
            this.panel1.Controls.Add(this.StartStream);
            this.panel1.Controls.Add(this.Discord);
            this.panel1.Location = new System.Drawing.Point(37, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 189);
            this.panel1.TabIndex = 12;
            // 
            // Stream_Manager
            // 
            this.Stream_Manager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Stream_Manager.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Stream_Manager.Depth = 0;
            this.Stream_Manager.HighEmphasis = true;
            this.Stream_Manager.Icon = null;
            this.Stream_Manager.Location = new System.Drawing.Point(24, 27);
            this.Stream_Manager.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Stream_Manager.MouseState = MaterialSkin.MouseState.HOVER;
            this.Stream_Manager.Name = "Stream_Manager";
            this.Stream_Manager.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Stream_Manager.Size = new System.Drawing.Size(153, 36);
            this.Stream_Manager.TabIndex = 13;
            this.Stream_Manager.Text = "Stream Manager";
            this.Stream_Manager.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Stream_Manager.UseAccentColor = false;
            this.Stream_Manager.UseVisualStyleBackColor = true;
            this.Stream_Manager.Click += new System.EventHandler(this.Stream_Manager_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(37, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 160);
            this.panel2.TabIndex = 13;
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("settingsPictureBox.Image")));
            this.settingsPictureBox.Location = new System.Drawing.Point(6, 67);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(52, 50);
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
        private MaterialSkin.Controls.MaterialButton OBSButton1;
        private MaterialSkin.Controls.MaterialButton Discord;
        private MaterialSkin.Controls.MaterialButton SoundCloud;
        private MaterialSkin.Controls.MaterialButton StartStream;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton Stream_Manager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox settingsPictureBox;
    }
}

