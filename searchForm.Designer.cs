
namespace assign3_database_application
{
    partial class searchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            this.MainMenuSearchButton = new System.Windows.Forms.Button();
            this.ExitSearchButton = new System.Windows.Forms.Button();
            this.CityGymLogoFitness = new System.Windows.Forms.PictureBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cityGymDBDataSet = new assign3_database_application.CityGymDBDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new assign3_database_application.CityGymDBDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new assign3_database_application.CityGymDBDataSetTableAdapters.TableAdapterManager();
            this.fitnessBookingTableAdapter = new assign3_database_application.CityGymDBDataSetTableAdapters.FitnessBookingTableAdapter();
            this.membershipTableAdapter = new assign3_database_application.CityGymDBDataSetTableAdapters.MembershipTableAdapter();
            this.fitnessBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MembershipButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.IDSearchBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchNameButton = new System.Windows.Forms.Button();
            this.FirstNameSearchBox = new System.Windows.Forms.TextBox();
            this.SearchTypeButton = new System.Windows.Forms.Button();
            this.TypeSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoFitness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuSearchButton
            // 
            this.MainMenuSearchButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuSearchButton.Location = new System.Drawing.Point(57, 326);
            this.MainMenuSearchButton.Name = "MainMenuSearchButton";
            this.MainMenuSearchButton.Size = new System.Drawing.Size(167, 35);
            this.MainMenuSearchButton.TabIndex = 0;
            this.MainMenuSearchButton.Text = "Main Menu";
            this.MainMenuSearchButton.UseVisualStyleBackColor = true;
            this.MainMenuSearchButton.Click += new System.EventHandler(this.MainMenuSearchButton_Click);
            // 
            // ExitSearchButton
            // 
            this.ExitSearchButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitSearchButton.Location = new System.Drawing.Point(591, 409);
            this.ExitSearchButton.Name = "ExitSearchButton";
            this.ExitSearchButton.Size = new System.Drawing.Size(181, 35);
            this.ExitSearchButton.TabIndex = 1;
            this.ExitSearchButton.Text = "Exit";
            this.ExitSearchButton.UseVisualStyleBackColor = true;
            this.ExitSearchButton.Click += new System.EventHandler(this.ExitSearchButton_Click);
            // 
            // CityGymLogoFitness
            // 
            this.CityGymLogoFitness.Image = ((System.Drawing.Image)(resources.GetObject("CityGymLogoFitness.Image")));
            this.CityGymLogoFitness.Location = new System.Drawing.Point(272, 326);
            this.CityGymLogoFitness.Name = "CityGymLogoFitness";
            this.CityGymLogoFitness.Size = new System.Drawing.Size(280, 118);
            this.CityGymLogoFitness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CityGymLogoFitness.TabIndex = 2;
            this.CityGymLogoFitness.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(540, 73);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(195, 31);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search by ID";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(609, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Please enter a member ID or First Name or Membership Type...";
            // 
            // cityGymDBDataSet
            // 
            this.cityGymDBDataSet.DataSetName = "CityGymDBDataSet";
            this.cityGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.cityGymDBDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FitnessBookingTableAdapter = this.fitnessBookingTableAdapter;
            this.tableAdapterManager.MembershipTableAdapter = this.membershipTableAdapter;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.UpdateOrder = assign3_database_application.CityGymDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fitnessBookingTableAdapter
            // 
            this.fitnessBookingTableAdapter.ClearBeforeFill = true;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // fitnessBookingBindingSource
            // 
            this.fitnessBookingBindingSource.DataMember = "FitnessBooking";
            this.fitnessBookingBindingSource.DataSource = this.cityGymDBDataSet;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.cityGymDBDataSet;
            // 
            // MembershipButton
            // 
            this.MembershipButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipButton.Location = new System.Drawing.Point(63, 409);
            this.MembershipButton.Name = "MembershipButton";
            this.MembershipButton.Size = new System.Drawing.Size(167, 35);
            this.MembershipButton.TabIndex = 14;
            this.MembershipButton.Text = "Membership";
            this.MembershipButton.UseVisualStyleBackColor = true;
            this.MembershipButton.Click += new System.EventHandler(this.MembershipButton_Click);
            // 
            // BookingButton
            // 
            this.BookingButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingButton.Location = new System.Drawing.Point(589, 326);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(181, 35);
            this.BookingButton.TabIndex = 15;
            this.BookingButton.Text = "Fitness Classes";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // IDSearchBox
            // 
            this.IDSearchBox.Location = new System.Drawing.Point(346, 82);
            this.IDSearchBox.Name = "IDSearchBox";
            this.IDSearchBox.Size = new System.Drawing.Size(171, 22);
            this.IDSearchBox.TabIndex = 16;
            this.IDSearchBox.TextChanged += new System.EventHandler(this.IDSearchBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(55, 49);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(715, 247);
            this.OutputBox.TabIndex = 17;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(537, 246);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(195, 31);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchNameButton
            // 
            this.SearchNameButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNameButton.Location = new System.Drawing.Point(540, 129);
            this.SearchNameButton.Name = "SearchNameButton";
            this.SearchNameButton.Size = new System.Drawing.Size(195, 32);
            this.SearchNameButton.TabIndex = 19;
            this.SearchNameButton.Text = "Search By Name";
            this.SearchNameButton.UseVisualStyleBackColor = true;
            this.SearchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // FirstNameSearchBox
            // 
            this.FirstNameSearchBox.Location = new System.Drawing.Point(346, 139);
            this.FirstNameSearchBox.Name = "FirstNameSearchBox";
            this.FirstNameSearchBox.Size = new System.Drawing.Size(171, 22);
            this.FirstNameSearchBox.TabIndex = 21;
            // 
            // SearchTypeButton
            // 
            this.SearchTypeButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTypeButton.Location = new System.Drawing.Point(537, 181);
            this.SearchTypeButton.Name = "SearchTypeButton";
            this.SearchTypeButton.Size = new System.Drawing.Size(198, 34);
            this.SearchTypeButton.TabIndex = 22;
            this.SearchTypeButton.Text = "Search by Type";
            this.SearchTypeButton.UseVisualStyleBackColor = true;
            this.SearchTypeButton.Click += new System.EventHandler(this.SearchTypeButton_Click);
            // 
            // TypeSearchBox
            // 
            this.TypeSearchBox.Location = new System.Drawing.Point(346, 193);
            this.TypeSearchBox.Name = "TypeSearchBox";
            this.TypeSearchBox.Size = new System.Drawing.Size(171, 22);
            this.TypeSearchBox.TabIndex = 23;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 513);
            this.Controls.Add(this.IDSearchBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TypeSearchBox);
            this.Controls.Add(this.SearchTypeButton);
            this.Controls.Add(this.FirstNameSearchBox);
            this.Controls.Add(this.SearchNameButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.MembershipButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CityGymLogoFitness);
            this.Controls.Add(this.ExitSearchButton);
            this.Controls.Add(this.MainMenuSearchButton);
            this.Name = "searchForm";
            this.Text = "City Gym Member Search";
            this.Load += new System.EventHandler(this.searchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoFitness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuSearchButton;
        private System.Windows.Forms.Button ExitSearchButton;
        private System.Windows.Forms.PictureBox CityGymLogoFitness;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private CityGymDBDataSet cityGymDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private CityGymDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private CityGymDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CityGymDBDataSetTableAdapters.FitnessBookingTableAdapter fitnessBookingTableAdapter;
        private System.Windows.Forms.BindingSource fitnessBookingBindingSource;
        private CityGymDBDataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private System.Windows.Forms.Button MembershipButton;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.TextBox IDSearchBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchNameButton;
        private System.Windows.Forms.TextBox FirstNameSearchBox;
        private System.Windows.Forms.Button SearchTypeButton;
        private System.Windows.Forms.TextBox TypeSearchBox;
    }
}