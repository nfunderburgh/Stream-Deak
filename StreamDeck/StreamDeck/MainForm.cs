using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using Utilities;


namespace StreamDeck
{
    public partial class MainForm : MaterialForm
    {
        KeybindForm keybindform;
        Location location = new Location();

        public MainForm()
        {
            InitializeComponent();
            InitializeButtonWidth();
            KeyPreview = true;

            keybindform = new KeybindForm(this);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            globalKeyboardHook gkh = new globalKeyboardHook();
            gkh.HookedKeys.Add(Keys.Q);
            gkh.HookedKeys.Add(Keys.E);
            gkh.HookedKeys.Add(Keys.W);
            gkh.HookedKeys.Add(Keys.F);
            gkh.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        MaterialSkinManager TManager=MaterialSkinManager.Instance;

        private void InitializeButtonWidth()
        {
            int width = StreamManagerButton.Width;
            OBSButton.Width = width;
            SoundCloudBlutton.Width = width;
            StartStreamButton.Width = width;
            DiscordButton.Width = width;
        }

        private void OBSButton_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(@"C:\Program Files\obs-studio\bin\64bit\");
            Process.Start(@"C:\Program Files\obs-studio\bin\64bit\obs64.exe");
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            Process.Start(location.discord);
        }

        private void SoundCloud_Click(object sender, EventArgs e)
        {
            Process.Start("https://soundcloud.com/discover");
        }

        private void StartStream_Click(object sender, EventArgs e)
        {
            OBSButton_Click(sender, e);
            SoundCloud_Click(sender, e);
            Stream_Manager_Click(sender, e);
            Discord_Click(sender, e);
        }

        private void Stream_Manager_Click(object sender, EventArgs e)
        {
            Process.Start("https://dashboard.twitch.tv/u/zapb0lt/stream-manager");
        }

        private void settingsPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            keybindform.Show();
        }

        private void DarkModeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkModeSwitch.Checked == true)
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
                TManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                TManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                settingsPictureBox_Click(sender, e);
            }
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), keybindform.SoundCloudButtonKeybind.Text, true))
            {
                SoundCloud_Click(sender, e);
            }
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), keybindform.DiscordButtonKeybind.Text, true))
            {
                Discord_Click(sender, e);
            }
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), keybindform.OBSButtonKeybind.Text, true))
            {
                OBSButton_Click(sender, e);
            }
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), keybindform.StreamManagerButtonKeybind.Text, true))
            {
                Stream_Manager_Click(sender, e);
            }
            Console.WriteLine(e.KeyCode.ToString());
        }
    }
}
