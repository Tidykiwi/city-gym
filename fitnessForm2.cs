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
    public partial class fitnessForm2 : Form
    {
        // Global variables
        string choice, output;
        int a;
        Boolean booked;

        public fitnessForm2()
        {
            InitializeComponent();
        }

        private void fitnessBookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fitnessBookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityGymDBDataSet);

        }

        private void fitnessForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityGymDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.cityGymDBDataSet.Member);
            // TODO: This line of code loads data into the 'cityGymDBDataSet.FitnessBooking' table. You can move, or remove it, as needed.
            this.fitnessBookingTableAdapter.Fill(this.cityGymDBDataSet.FitnessBooking);

        }

        private void SpinButton_CheckedChanged_1(object sender, EventArgs e)
        {
            // If user selects SPIN save in variable 'choice'
            if (SpinButton.Checked == true)
            {
                choice = "Spin";
            }
        }

        private void CardioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            // If user selects CARDIO save in variable 'choice'
            if (CardioButton.Checked == true)
            {
                choice = "Cardio";
            }
        }

        private void PilatesButton_CheckedChanged_1(object sender, EventArgs e)
        {
            // If user selects PILATES save in variable 'choice'
            if (PilatesButton.Checked == true)
            {
                choice = "Pilates";
            }
        }

        // ========================= BOOK FITNESS CLASS BUTTON =============================
        private void BookButton_Click(object sender, EventArgs e)
        {
            // Clear OutputBox of any previous text
            OutputBox.Clear();
           
            // Prompt user for input if ID field is blank
            if (IDSearchBox.Text.Equals(""))
            {
                OutputBox.Text = "\r\nPlease enter an ID";
            }
            // Confirm user input is a valid ID number
            else if (!int.TryParse(IDSearchBox.Text, out a))
            {
                OutputBox.Text = "\r\nIDs are numeric.\r\n \r\nPlease enter a valid ID";
                return;
            }
            // If ID is valid...
            else
            {
                a = Int32.Parse(IDSearchBox.Text);
                // Use ID to access the matching Row in Member Table
                CityGymDBDataSet.MemberRow memberRow = cityGymDBDataSet.Member.FindByMemberID(a);

                // Alert user if no matching entry exists
                if (memberRow == null)
                {
                    OutputBox.Text = "\r\nCould not find an entry for this ID";
                }
                
                else
                {
                    // Prompt user user if they have not selected a Fitness Class
                    if (SpinButton.Checked == false && CardioButton.Checked == false && PilatesButton.Checked == false)
                    {
                        OutputBox.Text = "\r\nPlease select a ftiness class";
                    }
                    else
                    {
                        // If any existing bookings are found boolean will be set to TRUE and user...
                        // Will be uanble to enter theri choice to the FITNESS BOOKING table
                        booked = false;
                        
                        // Use loop to examine each ROW in the FITNESS BOOKING table
                        for (int i = 1; i <= cityGymDBDataSet.FitnessBooking.Count; i++)
                        {
                            CityGymDBDataSet.FitnessBookingRow fitnessBookingRow = cityGymDBDataSet.FitnessBooking.FindByFitnessBookingID(i);

                            // If a ROW contains the ID entered by the user then...
                            if (fitnessBookingRow.MemberID == a)
                            {
                                // Check to see if the class DESCRIPTION in that ROW matches the users CHOICE
                                if (fitnessBookingRow.Description == choice)
                                {
                                    // If there is a match boolean is set to TRUE and user is informed that booking exists
                                    booked = true;
                                    output = "\r\nSorry... This member already has a booking for this " + choice + " class";
                                }                                
                            }                                                  
                        }

                        // If no prior booking exists booked will be FALSE and user choice can be saved into FITNESS BOOKING table
                        if (booked == false)
                        {
                            OutputBox.Clear();

                            // Create new row in "FitnessBooking" table and enter values
                            CityGymDBDataSet.FitnessBookingRow newRow = cityGymDBDataSet.FitnessBooking.NewFitnessBookingRow();
                            newRow.FitnessBookingID = cityGymDBDataSet.FitnessBooking.Count + 1;     // Set ID 1 higher than amount of rows found
                            newRow.Description = choice;
                            newRow.MemberID = a;

                            // Add row to FITNESS BOOKING table
                            cityGymDBDataSet.FitnessBooking.AddFitnessBookingRow(newRow);
                            output = "You have successfully booked a place in the " + choice + " class";
                        }

                        OutputBox.Text = output;
                    }
                }                
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and selections
            ClearForm(this);
        }

        private void MainMenuFitnessButton_Click(object sender, EventArgs e)
        {
            // Return to main menu
            Forms.menuSwitchTo.Show();
            this.Hide();
        }

        private void MembershipButton_Click(object sender, EventArgs e)
        {
            // Go to Membership
            Forms.memberSwitchTo.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Go to Search
            Forms.searchSwitchTo.Show();
            this.Hide();
        }

        private void ExitFitnessButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            Environment.Exit(0);
        }

        private void IDSearchBox_TextChanged(object sender, EventArgs e)
        { }
        private void OutputBox_TextChanged_1(object sender, EventArgs e)
        { }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void label2_Click(object sender, EventArgs e)
        { }

        public void ClearForm(Control form1)
        {
            // Method for clearing form RETREIVED FROM STACK OVERFLOW (QUESTION: How to clear the text of all textBoxes in the form? 
            // ANSWERED BY: Chandan Pasunoori JULY 10th, 2011) then... 
            // Edited by me to suit this application
            foreach (Control c in form1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }
    }
}
