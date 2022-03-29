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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            Environment.Exit(0); 
        }

        private void HelpPageButton_Click(object sender, EventArgs e)
        {
            // Go to HELP form
            Forms.helpSwitchTo.Show();
            this.Hide();
        }

        private void FitnessClassesPageButton_Click(object sender, EventArgs e)
        {
            // Go to FITNESS page
            Forms.fitnessSwitchTo.Show();
            this.Hide();
        }

        private void SearchMembersPageButton_Click(object sender, EventArgs e)
        {
            // Go to SEARCH page
            Forms.searchSwitchTo.Show();
            this.Hide();
        }

        private void MembershipFormPageButton_Click(object sender, EventArgs e)
        {
            // Go to membership form
            Forms.memberSwitchTo.Show();
            this.Hide();
        }
    }
}
