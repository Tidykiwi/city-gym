
namespace assign3_database_application
{
    partial class fitnessForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fitnessForm2));
            this.CityGymLogoFitness = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitFitnessButton = new System.Windows.Forms.Button();
            this.MainMenuFitnessButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MembershipButton = new System.Windows.Forms.Button();
            this.cityGymDBDataSet = new assign3_database_application.CityGymDBDataSet();
            this.fitnessBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessBookingTableAdapter = new assign3_database_application.CityGymDBDataSetTableAdapters.FitnessBookingTableAdapter();
            this.tableAdapterManager = new assign3_database_application.CityGymDBDataSetTableAdapters.TableAdapterManager();
            this.fitnessBookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BookButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SpinButton = new System.Windows.Forms.RadioButton();
            this.CardioButton = new System.Windows.Forms.RadioButton();
            this.PilatesButton = new System.Windows.Forms.RadioButton();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new assign3_database_application.CityGymDBDataSetTableAdapters.MemberTableAdapter();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoFitness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessBookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CityGymLogoFitness
            // 
            this.CityGymLogoFitness.Image = ((System.Drawing.Image)(resources.GetObject("CityGymLogoFitness.Image")));
            this.CityGymLogoFitness.Location = new System.Drawing.Point(113, 12);
            this.CityGymLogoFitness.Name = "CityGymLogoFitness";
            this.CityGymLogoFitness.Size = new System.Drawing.Size(208, 94);
            this.CityGymLogoFitness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CityGymLogoFitness.TabIndex = 0;
            this.CityGymLogoFitness.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fitness Class Bookings\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitFitnessButton
            // 
            this.ExitFitnessButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitFitnessButton.Location = new System.Drawing.Point(29, 583);
            this.ExitFitnessButton.Name = "ExitFitnessButton";
            this.ExitFitnessButton.Size = new System.Drawing.Size(207, 38);
            this.ExitFitnessButton.TabIndex = 3;
            this.ExitFitnessButton.Text = "Exit";
            this.ExitFitnessButton.UseVisualStyleBackColor = true;
            this.ExitFitnessButton.Click += new System.EventHandler(this.ExitFitnessButton_Click);
            // 
            // MainMenuFitnessButton
            // 
            this.MainMenuFitnessButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuFitnessButton.Location = new System.Drawing.Point(242, 642);
            this.MainMenuFitnessButton.Name = "MainMenuFitnessButton";
            this.MainMenuFitnessButton.Size = new System.Drawing.Size(199, 38);
            this.MainMenuFitnessButton.TabIndex = 4;
            this.MainMenuFitnessButton.Text = "Main Menu";
            this.MainMenuFitnessButton.UseVisualStyleBackColor = true;
            this.MainMenuFitnessButton.Click += new System.EventHandler(this.MainMenuFitnessButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Member ID and select a class:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(242, 583);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(199, 38);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Search Members";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MembershipButton
            // 
            this.MembershipButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipButton.Location = new System.Drawing.Point(29, 642);
            this.MembershipButton.Name = "MembershipButton";
            this.MembershipButton.Size = new System.Drawing.Size(207, 38);
            this.MembershipButton.TabIndex = 25;
            this.MembershipButton.Text = "Membership";
            this.MembershipButton.UseVisualStyleBackColor = true;
            this.MembershipButton.Click += new System.EventHandler(this.MembershipButton_Click);
            // 
            // cityGymDBDataSet
            // 
            this.cityGymDBDataSet.DataSetName = "CityGymDBDataSet";
            this.cityGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fitnessBookingBindingSource
            // 
            this.fitnessBookingBindingSource.DataMember = "FitnessBooking";
            this.fitnessBookingBindingSource.DataSource = this.cityGymDBDataSet;
            // 
            // fitnessBookingTableAdapter
            // 
            this.fitnessBookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FitnessBookingTableAdapter = this.fitnessBookingTableAdapter;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = assign3_database_application.CityGymDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fitnessBookingDataGridView
            // 
            this.fitnessBookingDataGridView.AutoGenerateColumns = false;
            this.fitnessBookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fitnessBookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.fitnessBookingDataGridView.DataSource = this.fitnessBookingBindingSource;
            this.fitnessBookingDataGridView.Location = new System.Drawing.Point(29, 430);
            this.fitnessBookingDataGridView.Name = "fitnessBookingDataGridView";
            this.fitnessBookingDataGridView.RowHeadersWidth = 51;
            this.fitnessBookingDataGridView.RowTemplate.Height = 24;
            this.fitnessBookingDataGridView.Size = new System.Drawing.Size(412, 134);
            this.fitnessBookingDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FitnessBookingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FitnessBookingID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn3.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // IDSearchBox
            // 
            this.IDSearchBox.Location = new System.Drawing.Point(221, 184);
            this.IDSearchBox.Name = "IDSearchBox";
            this.IDSearchBox.Size = new System.Drawing.Size(100, 22);
            this.IDSearchBox.TabIndex = 27;
            this.IDSearchBox.TextChanged += new System.EventHandler(this.IDSearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Member ID:";
            // 
            // BookButton
            // 
            this.BookButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.Location = new System.Drawing.Point(29, 256);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(142, 38);
            this.BookButton.TabIndex = 29;
            this.BookButton.Text = "Book Class";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(29, 314);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(412, 99);
            this.OutputBox.TabIndex = 30;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged_1);
            // 
            // SpinButton
            // 
            this.SpinButton.AutoSize = true;
            this.SpinButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinButton.Location = new System.Drawing.Point(44, 226);
            this.SpinButton.Name = "SpinButton";
            this.SpinButton.Size = new System.Drawing.Size(77, 24);
            this.SpinButton.TabIndex = 31;
            this.SpinButton.TabStop = true;
            this.SpinButton.Text = "SPIN";
            this.SpinButton.UseVisualStyleBackColor = true;
            this.SpinButton.CheckedChanged += new System.EventHandler(this.SpinButton_CheckedChanged_1);
            // 
            // CardioButton
            // 
            this.CardioButton.AutoSize = true;
            this.CardioButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardioButton.Location = new System.Drawing.Point(166, 226);
            this.CardioButton.Name = "CardioButton";
            this.CardioButton.Size = new System.Drawing.Size(105, 24);
            this.CardioButton.TabIndex = 32;
            this.CardioButton.TabStop = true;
            this.CardioButton.Text = "CARDIO";
            this.CardioButton.UseVisualStyleBackColor = true;
            this.CardioButton.CheckedChanged += new System.EventHandler(this.CardioButton_CheckedChanged_1);
            // 
            // PilatesButton
            // 
            this.PilatesButton.AutoSize = true;
            this.PilatesButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilatesButton.Location = new System.Drawing.Point(312, 226);
            this.PilatesButton.Name = "PilatesButton";
            this.PilatesButton.Size = new System.Drawing.Size(111, 24);
            this.PilatesButton.TabIndex = 33;
            this.PilatesButton.TabStop = true;
            this.PilatesButton.Text = "PILATES";
            this.PilatesButton.UseVisualStyleBackColor = true;
            this.PilatesButton.CheckedChanged += new System.EventHandler(this.PilatesButton_CheckedChanged_1);
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
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(290, 256);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(142, 38);
            this.ClearButton.TabIndex = 34;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // fitnessForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 814);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PilatesButton);
            this.Controls.Add(this.CardioButton);
            this.Controls.Add(this.SpinButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDSearchBox);
            this.Controls.Add(this.fitnessBookingDataGridView);
            this.Controls.Add(this.MembershipButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainMenuFitnessButton);
            this.Controls.Add(this.ExitFitnessButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityGymLogoFitness);
            this.Name = "fitnessForm2";
            this.Text = "City Gym Fitness Class Bookings";
            this.Load += new System.EventHandler(this.fitnessForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoFitness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGymDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessBookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CityGymLogoFitness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitFitnessButton;
        private System.Windows.Forms.Button MainMenuFitnessButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button MembershipButton;
        private CityGymDBDataSet cityGymDBDataSet;
        private System.Windows.Forms.BindingSource fitnessBookingBindingSource;
        private CityGymDBDataSetTableAdapters.FitnessBookingTableAdapter fitnessBookingTableAdapter;
        private CityGymDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fitnessBookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox IDSearchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.RadioButton SpinButton;
        private System.Windows.Forms.RadioButton CardioButton;
        private System.Windows.Forms.RadioButton PilatesButton;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private CityGymDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button ClearButton;
    }
}