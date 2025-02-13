using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnCloseHelp_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
