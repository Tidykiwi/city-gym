using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assign3_database_application
{
    public partial class CityGymMembershipForm : Form
    {
        // Global variables needed for calculations/notifications/creation of text file
        string firstNameBox, lastNameBox, addressBox, mobileNumberBox, typeChar,
           freqChar, accessChar, trainerChar, dietChar, videoChar;
        double typeDbl, durationDiscount, weeks, months, debitDbl, freqDbl, accessDbl, trainerDbl, dietDbl, videoDbl;
        double MCTB, ECB, TDB, NMCB, RPAB;

        // Bool for controlling whether the form is correctly filled in
        bool Success;

        public CityGymMembershipForm()
        {
            InitializeComponent();
        }
        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityGymDBDataSet);

        }

        private void CityGymMembershipForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityGymDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.cityGymDBDataSet.Member);

        }

        private void memberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void label2_Click(object sender, EventArgs e)
        { }
        private void label3_Click(object sender, EventArgs e)
        { }
        private void label4_Click(object sender, EventArgs e)
        { }
        private void label5_Click(object sender, EventArgs e)
        { }
        private void label6_Click(object sender, EventArgs e)
        { }
        private void label7_Click(object sender, EventArgs e)
        { }
        private void label8_Click(object sender, EventArgs e)
        { }
        private void label9_Click(object sender, EventArgs e)
        { }
        private void label10_Click(object sender, EventArgs e)
        { }
        private void label11_Click(object sender, EventArgs e)
        { }
        private void label12_Click(object sender, EventArgs e)
        { }
        private void label13_Click(object sender, EventArgs e)
        { }
        private void label14_Click(object sender, EventArgs e)
        { }
        private void label15_Click(object sender, EventArgs e)
        { }
        private void label16_Click(object sender, EventArgs e)
        { }
        private void label18_Click(object sender, EventArgs e)
        { }
        private void label19_Click(object sender, EventArgs e)
        { }
        private void label20_Click(object sender, EventArgs e)
        { }
        private void label21_Click(object sender, EventArgs e)
        { }
        private void label22_Click(object sender, EventArgs e)
        { }
        private void label23_Click(object sender, EventArgs e)
        { }
        private void label24_Click(object sender, EventArgs e)
        { }
        private void label25_Click(object sender, EventArgs e)
        { }
        private void CityGymMembershipForm_Click(object sender, EventArgs e)
        { }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            // Variable for the users FIRST NAME
            firstNameBox = FirstNameBox.Text;
        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            // Variable for the users LAST NAME
            lastNameBox = LastNameBox.Text;
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            // Variable for the users ADDRESS
            addressBox = AddressBox.Text;
        }

        private void MobileNumberBox_TextChanged(object sender, EventArgs e)
        {
            // Variable for the users MOBILE NUMBER
            mobileNumberBox = MobileNumberBox.Text;
        }

        private void BasicButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BasicButton.Checked == true)
            {
                // Set values for if user selects BASIC MEMBERSHIP 
                typeDbl = 10;
                typeChar = "1";
            }
        }

        private void RegularButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RegularButton.Checked == true)
            {
                // Set values for if user selects REGULAR MEMBERSHIP
                typeDbl = 15;
                typeChar = "2";
            }
        }

        private void PremiumButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PremiumButton.Checked == true)
            {
                // Set values for if user selects PREMIUM MEMBERSHIP
                typeDbl = 20;
                typeChar = "3";
            }
        }

        private void Duration3Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Duration3Button.Checked == true)
            {
                // Set values for if user selects 3 MONTH MEMBERSHIP
                months = 3;
                weeks = 13;
            }
        }

        private void Duration12Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Duration12Button.Checked == true)
            {
                // Set values for if user selects 12 MONTH MEMBERSHIP
                durationDiscount = 24;
                months = 12;
                weeks = 52;
            }
        }

        private void Duration24Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Duration24Button.Checked == true)
            {
                // Set values for if user selects 24 MONTH MEMBERSHIP
                durationDiscount = 96;
                months = 24;
                weeks = 104;
            }
        }

        private void DDYESBUTTON_CheckedChanged(object sender, EventArgs e)
        {
            if (DDYesButton.Checked == true)
            {
                // Set values for if user selects YES for DIRECT DEBIT
                debitDbl = Math.Round((typeDbl * weeks) / 100, 2);
            }
        }

        private void DDNoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DDNoButton.Checked == true)
            {
                // Set values for if user selects NO for DIRECT DEBIT
                debitDbl = 0;
            }
        }

        private void FOPWeeklyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FOPWeeklyButton.Checked == true)
            {
                // Set values for if user selects WEEKLY FOP
                freqChar = "Weekly";
                freqDbl = weeks;
            }
        }

        private void FOPMonthlyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FOPMonthlyButton.Checked == true)
            {
                // Set values for if user selects MONTHLY FOP
                freqChar = "Monthly";
                freqDbl = months;
            }
        }

        private void AccessYesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AccessYesButton.Checked == true)
            {
                // Set values for if user selects YES for 24/7 ACCESS
                accessDbl = 1;
                accessChar = "True";
            }
        }

        private void AccessNoButton_CheckedChanged(object sender, EventArgs e)
        {         
            if (AccessNoButton.Checked == true)
            {
                // Set values for if user slects NO for 24/7 ACCESS
                accessDbl = 0;
                accessChar = "False";
            }
        }

        private void TrainerYesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TrainerYesButton.Checked == true)
            {
                // Set values for if user selects YES for PERSONAL TRAINER
                trainerDbl = 20;
                trainerChar = "True";
            }
        }

        private void TrainerNoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TrainerNoButton.Checked == true)
            {
                // Set values for if user selects NO for PERSONAL TRAINER
                trainerDbl = 0;
                trainerChar = "False";
            }
        }

        private void DietYesButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values for if user selects YES for DIET CONSULTATION
            if (DietYesButton.Checked == true)
            {
                dietDbl = 20;
                dietChar = "True";
            }
        }

        private void DietNoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DietNoButton.Checked == true)
            {
                // Set values for if usr selects NO for DIET CONSULTATION
                dietDbl = 0;
                dietChar = "False";
            }
        }

        private void VideoYesButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values for if user selects YES for ONLINE VIDEO ACCESS
            if (VideoYesButton.Checked == true)
            {
                videoDbl = 2;
                videoChar = "True";
            }
        }

        private void VideoNoButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set values for if user selects NO for ONLINE VIDEO ACCESS
            if (VideoNoButton.Checked == true)
            {
                videoDbl = 0;
                videoChar = "False";
            }
        }

        public void errorMessage(string message)
        {
            // Method for declaring error messages
            NotificationBox.Text = "\r\nWHOOPS!!!\r\n\r\nLooks like your forgot \r\n\r\n" + message;
            Success = false;
        }

        // =================================== CALCULATE BUTTON ====================================
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Any errors and SUCCESS will switch to false and CALACULATE buttom will not function
            Success = true;

            CityGymLogo.Hide(); // Hides CITY GYM LOGO so text can be seen in NOTIFICATION BOX

            // SERIES OF CHECKS TO VERIFY IF FORM IS FILLED IN CORRECTLY AND ALERT USER TO ERRORS

            // Variable for testing if MOBILE NUMBER consists of all integers
            long mobileNumberTest;

            // Check to see if ONLINE FITNESS VIDEOS selection has been made
            if (VideoYesButton.Checked == false && VideoNoButton.Checked == false)
            {
                errorMessage("ONLINE FITNESS VIDEOS");
            }
            // Check to see if DIET CONSULTATION selection has been made
            if (DietYesButton.Checked == false && DietNoButton.Checked == false)
            {
                errorMessage("DIET CONSULTATION");
            }
            // Check to see if PERSONAL TRAINER selection has been made
            if (TrainerYesButton.Checked == false && TrainerNoButton.Checked == false)
            {
                errorMessage("PERSONAL TRAINER");
            }
            // Check to see if 24/7 ACCESS selection has been made
            if (AccessYesButton.Checked == false && AccessNoButton.Checked == false)
            {
                errorMessage("24/7 ACCESS");
            }
            // Check to see if FREQUENCY OF PAYMENT selection has been made
            if (FOPWeeklyButton.Checked == false && FOPMonthlyButton.Checked == false)
            {
                errorMessage("FREQUENCY OF PAYMENT");
            }
            // Check to see if if DIRECT DEBIT selection has been made 
            if (DDYesButton.Checked == false && DDNoButton.Checked == false)
            {
                errorMessage("DIRECT DEBIT");
            }
            // Check to see if a membership DURATION selection has been made
            if (Duration3Button.Checked == false && Duration12Button.Checked == false && Duration24Button.Checked == false)
            {
                errorMessage("MEMBERSHIP DURATION");
            }
            //Check to see if a membership TYPE selection has been made
            if (BasicButton.Checked == false && RegularButton.Checked == false && PremiumButton.Checked == false)
            {
                errorMessage("TYPE OF MEMBERSHIP");
            }
            // Check to see if only integers are used for Mobile Number
            if (!long.TryParse(MobileNumberBox.Text, out mobileNumberTest))
            {
                NotificationBox.Text = "\r\nWHOOPS!!! \r\n\r\nLooks like you entered your MOBILE NUMBER incorrectly";
                Success = false;
            }
            // Check to see if user has entered MOBILE NUMBER
            if (MobileNumberBox.Text.Length == 0)
            {
                errorMessage("MOBILE NUMBER");
            }
            // Check to see if user has entered ADDRESS
            if (AddressBox.Text.Length == 0)
            {
                errorMessage("ADDRESS");
            }
            // Check to see if user has entered LAST NAME
            if (LastNameBox.Text.Length == 0)
            {
                errorMessage("LAST NAME");
            }
            // Check to see if user has entered FIRST NAME
            if (FirstNameBox.Text.Length == 0)
            {
                errorMessage("FIRST NAME");
            }

            // If form is filled out correctly bool variable SUCCESS will = TRUE and...
            // Calculations will be done / Success message will be displayed / Member information will be written to file
            if (Success == true)
            {
                // Multiply price for TYPE and DURATION of membership then convert to string and display
                MCTB = (typeDbl * weeks);
                MembershipCostTotalBox.Text = " $" + MCTB.ToString();

                // Calaculate the EXTRA CHARGES to be applied then convert to a string and display
                ECB = ((accessDbl + trainerDbl + dietDbl + videoDbl) * weeks);
                ExtraChargesTotalBox.Text = " $" + ECB.ToString();

                // Calculate the TOTAL DISCOUNT that is to be applied then convert to a string and dsiplay
                TDB = durationDiscount + debitDbl;
                TotalDiscountBox.Text = " $" + TDB.ToString();

                // Calaculate the NET MEMBERSHIP COST then convert to string and display
                NMCB = (MCTB + ECB) - TDB;
                NetMembershipCostBox.Text = "$" + NMCB.ToString();

                // Calculates and rounds the RGEGULAR PAYMENT AMOUNT to 2 decimal places then convert to string and display
                RPAB = Math.Round((NMCB / freqDbl), 2);
                RegularPaymentAmountBox.Text = "$" + RPAB.ToString();

                // Success message 
                NotificationBox.Text = ("\r\nYour TOTALS have been successfully calculated\r\n" +
                    "\r\nIf you are happy please press the SUBMIT BUTTON to save your details and complete the enrolment process.");
            }
        }

        //++++++++++++++++++++++++++++ SUBMIT BUTTON +++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Create new row in "Member" table and set name and score
            CityGymDBDataSet.MemberRow newRow = cityGymDBDataSet.Member.NewMemberRow();
            newRow.MemberID = cityGymDBDataSet.Member.Count + 1;     // Set ID 1 higher than amount of rows found
            newRow.FirstName = firstNameBox;
            newRow.LastName = lastNameBox;
            newRow.PaymentFrequency = freqChar;
            newRow.AccessExtra = accessChar;                            
            newRow.TrainerExtra = trainerChar;                          
            newRow.DietExtra = dietChar;                                
            newRow.VideoExtra = videoChar;                              
            newRow.RegularPaymentAmount = Convert.ToDecimal(RPAB);
            newRow.MembershipID = Int32.Parse(typeChar);

            // Option 1 for adding row into the Member table
            cityGymDBDataSet.Member.AddMemberRow(newRow);

            // Saves the new row in the dataset and updates it
            memberTableAdapter.Update(cityGymDBDataSet.Member);

            // Success message 
            NotificationBox.Text = ("\r\nCongratulations\r\n" + "\r\nYou have successfully saved your details and completeted the enrolment process\r\n" +
                "\r\nWELCOME TO CITY GYM!!!");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // CLEAR BUTTON clears TEXT BOXES and unchecks all RADIO BUTTONS leaving form ready to use again
            ClearForm(this);
            // Shows CITY GYM LOGO in NOTIFICATION BOX
            CityGymLogo.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            // Return to main menu
            Forms.menuSwitchTo.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Go to Search
            Forms.searchSwitchTo.Show();
            this.Hide();
        }

        private void BookingsButton_Click(object sender, EventArgs e)
        {
            // Go to Fitness
            Forms.fitnessSwitchTo.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            Environment.Exit(0); 
        }

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
                if (c is Panel)
                {
                    ClearForm(c);
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

    }
}
