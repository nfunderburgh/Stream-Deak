using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace StreamDeck
{
    public partial class KeybindForm : MaterialForm 
    {
        MainForm mainform;
        public KeybindForm(MainForm mainfrm)
        {
            InitializeComponent();
            KeyPreview = true;

            mainform = mainfrm;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        public void SoundCloud_KeyDown(object sender, KeyEventArgs e)
        {
            SoundCloudButtonKeybind.Text = e.KeyCode.ToString();
        }

        private void DiscordButtonKeybind_KeyDown(object sender, KeyEventArgs e)
        {
            DiscordButtonKeybind.Text = e.KeyCode.ToString();
        }

        private void OBSButtonKeybind_KeyDown(object sender, KeyEventArgs e)
        {
            OBSButtonKeybind.Text = e.KeyCode.ToString();
        }

        private void StreamManagerButtonKeybind_KeyDown(object sender, KeyEventArgs e)
        {
            StreamManagerButtonKeybind.Text = e.KeyCode.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform.Show();
        }

        private void Back_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Back_Click(sender, e);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Font smallFont = new Font("Arial", 15);
            label1.Font = smallFont;
            label2.Font = smallFont;
            label3.Font = smallFont;
            label4.Font = smallFont;  
        }
    }
}
