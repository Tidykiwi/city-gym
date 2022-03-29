using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign3_database_application
{
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
        }

        private void ExitHelpButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            Environment.Exit(0); 
        }

        private void MainMenuHelpButton_Click(object sender, EventArgs e)
        {
            // Return to main menu
            Forms.menuSwitchTo.Show();
            this.Hide();
        }
    }
}
