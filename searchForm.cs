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
    public partial class searchForm : Form
    {
        string output;

        public searchForm()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityGymDBDataSet);

        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityGymDBDataSet.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter.Fill(this.cityGymDBDataSet.Membership);
            // TODO: This line of code loads data into the 'cityGymDBDataSet.FitnessBooking' table. You can move, or remove it, as needed.
            this.fitnessBookingTableAdapter.Fill(this.cityGymDBDataSet.FitnessBooking);
            // TODO: This line of code loads data into the 'cityGymDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.cityGymDBDataSet.Member);

        }    

        // ==================== SEARCH BY ID BUTTON ==================================================
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string output;
            int a;

            // Prompt user for input if ID field is blank
            if (IDSearchBox.Text.Equals(""))
            {
                output = "\r\nPlease enter an ID";
            }
            // Confirm user input is a valid ID number
            else if (!int.TryParse(IDSearchBox.Text, out a))        
            {
                OutputBox.Text = "\r\nIDs are numeric.\r\n \r\nPlease enter a valid ID";
                return;
            }        
            else
            {
                a = Int32.Parse(IDSearchBox.Text);
                // Use user input to access the appropriate Row in Member Table
                CityGymDBDataSet.MemberRow memberRow = cityGymDBDataSet.Member.FindByMemberID(a);

                // Alert user if no matching entry exists
                if (memberRow == null)
                {
                    output = "\r\nCould not find an entry for this ID";
                }
                // If yes then output entry details
                else
                {
                    // Use MemberID to access appropriate row from Membership table NOTE: This code is located here to protect from...
                    // an error occurring if user input (int a) is greater than number of members
                    CityGymDBDataSet.MembershipRow membershipRow = cityGymDBDataSet.Membership.FindByMembershipID(memberRow.MembershipID);

                    output = "ID is: " + (memberRow.MemberID).ToString() + Environment.NewLine +
                             "First Name: " + memberRow.FirstName + Environment.NewLine +
                             "Last Name: " + memberRow.LastName + Environment.NewLine +
                             "Payment Frequency: " + memberRow.PaymentFrequency + Environment.NewLine +
                             "24/7 Access: " + memberRow.AccessExtra + Environment.NewLine +
                             "Personal Trainer: " + memberRow.TrainerExtra + Environment.NewLine +
                             "Diet Consultation: " + memberRow.DietExtra + Environment.NewLine +
                             "Online Videos: "+ memberRow.VideoExtra + Environment.NewLine +
                             "Regular Payment Amount: " + memberRow.RegularPaymentAmount + Environment.NewLine +
                             // Look in Row from Membership Table to find string value for Membership Description 
                             "Membership Type: " + membershipRow.Description + Environment.NewLine;
                }
            }

            // Display Output
            OutputBox.Text = output;
            FirstNameSearchBox.Clear();
            TypeSearchBox.Clear();
        }

        // +++++++++++++++++++++++ SEARCH BY FIRST NAME BUTTON +++++++++++++++++++++++++
        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            string name;
            int a;

            // Prompt user for input if ID field is blank
            if (FirstNameSearchBox.Text.Equals(""))
            {
                output = "\r\nPlease enter a First Name";
            }
            // Confirm if user input is a string
            else if (int.TryParse(FirstNameSearchBox.Text, out a))
            {
                OutputBox.Text = "\r\nPleasee enter a valid First Name";
                return;
            }
            else
            {
                name = FirstNameSearchBox.Text;
                Boolean nameExists = false;
                // Use loop to examine each ROW in the MEMBER table
                for (int i = 1; i <= cityGymDBDataSet.Member.Count; i++)
                {
                    CityGymDBDataSet.MemberRow memberRow = cityGymDBDataSet.Member.FindByMemberID(i);

                    // If a ROW contains the First Name entered by the user then Output their details
                    if (memberRow.FirstName == name)
                    {
                        nameExists = true;
                        // Use MemberID to access appropriate row from Membership table NOTE: This code is located here to protect from...
                        // an error occurring if user input (int a) is greater than number of members
                        CityGymDBDataSet.MembershipRow membershipRow = cityGymDBDataSet.Membership.FindByMembershipID(memberRow.MembershipID);

                        output = "ID is: " + (memberRow.MemberID).ToString() + Environment.NewLine +
                                 "First Name: " + memberRow.FirstName + Environment.NewLine +
                                 "Last Name: " + memberRow.LastName + Environment.NewLine +
                                 "Payment Frequency: " + memberRow.PaymentFrequency + Environment.NewLine +
                                 "24/7 Access: " + memberRow.AccessExtra + Environment.NewLine +
                                 "Personal Trainer: " + memberRow.TrainerExtra + Environment.NewLine +
                                 "Diet Consultation: " + memberRow.DietExtra + Environment.NewLine +
                                 "Online Videos: " + memberRow.VideoExtra + Environment.NewLine +
                                 "Regular Payment Amount: " + memberRow.RegularPaymentAmount + Environment.NewLine +
                                 // Look in Row from Membership Table to find string value for Membership Description 
                                 "Membership Type: " + membershipRow.Description + Environment.NewLine;
                    }
                }
                if (nameExists == false)
                {
                    // Alert user if no matching entry exists
                    output = "\r\nCould not find an entry for this First Name";
                }
            }
            // Display output
            OutputBox.Text = output;
            IDSearchBox.Clear();
            TypeSearchBox.Clear();

        }

        //**************************** SEARCH BY MEMBERSHIP TYPE BUTTON *************************************
        private void SearchTypeButton_Click(object sender, EventArgs e)
        {
            string type;
            int a;

            // Prompt user for input if membership TYPE field is blank
            if (TypeSearchBox.Text.Equals(""))
            {
                OutputBox.Text = "\r\nPlease enter a membership Type";
            }
            // Confirm if user input is a string
            else if (int.TryParse(TypeSearchBox.Text, out a))
            {
                OutputBox.Text = "\r\nPleasee enter a valid membership type";
                return;
            }
            else
            {
                type = TypeSearchBox.Text;
                // Will set boolean to true when member record with matching membership type is found
                Boolean typeExists = false;

                // Use loop to examine each ROW in the MEMBER table
                OutputBox.Clear();

                for (int i = 1; i <= cityGymDBDataSet.Member.Count; i++)
                {

                    CityGymDBDataSet.MemberRow memberRow = cityGymDBDataSet.Member.FindByMemberID(i);
                    
                    // Use MemberID to access appropriate row from Membership table
                    CityGymDBDataSet.MembershipRow membershipRow = cityGymDBDataSet.Membership.FindByMembershipID(memberRow.MembershipID);

                    // If a ROW contains the Membership TYPE entered by the user then Output details
                    if (membershipRow.Description == type)
                    {
                        // Set boolean as true then...
                        typeExists = true;
                        // Display output 
                        OutputBox.AppendText(Environment.NewLine + "ID is: " + (memberRow.MemberID).ToString() + Environment.NewLine +
                                 "First Name: " + memberRow.FirstName + Environment.NewLine +
                                 "Last Name: " + memberRow.LastName + Environment.NewLine +
                                 "Payment Frequency: " + memberRow.PaymentFrequency + Environment.NewLine +
                                 "24/7 Access: " + memberRow.AccessExtra + Environment.NewLine +
                                 "Personal Trainer: " + memberRow.TrainerExtra + Environment.NewLine +
                                 "Diet Consultation: " + memberRow.DietExtra + Environment.NewLine +
                                 "Online Videos: " + memberRow.VideoExtra + Environment.NewLine +
                                 "Regular Payment Amount: " + memberRow.RegularPaymentAmount + Environment.NewLine +
                                 // Look in Row from Membership Table to find string value for Membership Description 
                                 "Membership Type: " + membershipRow.Description + Environment.NewLine);
                    }
                }
                if (typeExists == false)
                {
                    // Alert user if no matching entry exists
                    OutputBox.Text = "\r\nCould not find an entry that matches your input";
                }
            }
            // Display output
            //OutputBox.Text = output;
            IDSearchBox.Clear();
            FirstNameSearchBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IDSearchBox.Clear();
            FirstNameSearchBox.Clear();
            TypeSearchBox.Clear();
            OutputBox.Clear();
        }
        private void ExitSearchButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            Environment.Exit(0);
        }

        private void MainMenuSearchButton_Click(object sender, EventArgs e)
        {
            // Returm to main menu
            Forms.menuSwitchTo.Show();
            this.Hide();
        }

        private void MembershipButton_Click(object sender, EventArgs e)
        {
            // Go to Membership
            Forms.memberSwitchTo.Show();
            this.Hide();
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            // Go to Fitness Bookings
            Forms.fitnessSwitchTo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void IDSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
