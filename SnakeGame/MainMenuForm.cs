using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            // Otevře hlavní formulář se hrou
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide();
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            // Otevře Help formulář
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit
            Application.Exit();
        }
    }
}
