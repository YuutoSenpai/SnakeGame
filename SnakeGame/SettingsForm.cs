using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SettingsForm : Form
    {
        public int SnakeSpeed { get; set; }
        public Color SnakeColor { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void rbtnSlow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnSlow.Checked)
            {
                SnakeSpeed = 200; // Slow
            }
        }

        private void rbtnMedium_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnMedium.Checked)
            {
                SnakeSpeed = 100; // Medium
            }
        }

        private void rbtnFast_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnFast.Checked)
            {
                SnakeSpeed = 50; // Fast
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Uloží změny 
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (SnakeSpeed == 200)
            {
                rbtnSlow.Checked = true;
            }
            else if (SnakeSpeed == 100)
            {
                rbtnMedium.Checked = true;
            }
            else if (SnakeSpeed == 50)
            {
                rbtnFast.Checked = true;
            }
        }
    }
}
