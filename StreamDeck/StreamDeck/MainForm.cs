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

        /*
         * The Main Form Constructor
         */
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
            gkh.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        MaterialSkinManager TManager=MaterialSkinManager.Instance;

        /*
         * Initalizes the width of the buttons so they are the same size
         */
        private void InitializeButtonWidth()
        {
            int width = StreamManagerButton.Width;
            OBSButton.Width = width;
            SoundCloudBlutton.Width = width;
            StartStreamButton.Width = width;
            DiscordButton.Width = width;
            Alert1.Width = width;
        }

        /*
         * Launches OBS when the button is clicked
         * 
         * @param object reference to the control/object that raised the event
         * @param EventArgs contains event data
         */
        private void OBSButton_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(@"C:\Program Files\obs-studio\bin\64bit\");
            Process.Start(@"C:\Program Files\obs-studio\bin\64bit\obs64.exe");
        }

        /*
        * Launches Discord when the button is clicked
        * 
        * @param object reference to the control/object that raised the event
        * @param EventArgs contains event data
        */
        private void Discord_Click(object sender, EventArgs e)
        {
            Process.Start(location.discord);
        }

        /*
        * Launches Soundcloud in chrome when the button is clicked
        * 
        * @param object reference to the control/object that raised the event
        * @param EventArgs contains event data
        */
        private void SoundCloud_Click(object sender, EventArgs e)
        {
            Process.Start("https://soundcloud.com/discover");
        }

        /*
        * Launches stream manager in chrome when the button is clicked
        * 
        * @param object reference to the control/object that raised the event
        * @param EventArgs contains event data
        */
        private void Stream_Manager_Click(object sender, EventArgs e)
        {
            Process.Start("https://dashboard.twitch.tv/u/zapb0lt/stream-manager");
        }

        /*
        * Launches All applications needed for the start of a stream
        * 
        * @param object reference to the control/object that raised the event
        * @param EventArgs contains event data
        */
        private void StartStream_Click(object sender, EventArgs e)
        {
            OBSButton_Click(sender, e);
            SoundCloud_Click(sender, e);
            Stream_Manager_Click(sender, e);
            Discord_Click(sender, e);
        }

        /*
        * Hides the current form and shows the keybind form when the settings cog wheel is clicked
        * 
        * @param object reference to the control/object that raised the event
        * @param EventArgs contains event data
        */
        private void settingsPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            keybindform.Show();
        }

        /*
        * Changes the Light mode if the switch is set to true
        * 
        * @param object reference to the control/object that raised the event
        * @param EventArgs contains event data
        */
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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
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
