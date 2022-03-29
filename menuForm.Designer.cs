
namespace assign3_database_application
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.MembershipFormPageButton = new System.Windows.Forms.Button();
            this.SearchMembersPageButton = new System.Windows.Forms.Button();
            this.FitnessClassesPageButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HelpPageButton = new System.Windows.Forms.Button();
            this.CityGymLogoMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // MembershipFormPageButton
            // 
            this.MembershipFormPageButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipFormPageButton.Location = new System.Drawing.Point(122, 189);
            this.MembershipFormPageButton.Name = "MembershipFormPageButton";
            this.MembershipFormPageButton.Size = new System.Drawing.Size(201, 35);
            this.MembershipFormPageButton.TabIndex = 1;
            this.MembershipFormPageButton.Text = "Membership Form\r\n";
            this.MembershipFormPageButton.UseVisualStyleBackColor = true;
            this.MembershipFormPageButton.Click += new System.EventHandler(this.MembershipFormPageButton_Click);
            // 
            // SearchMembersPageButton
            // 
            this.SearchMembersPageButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMembersPageButton.Location = new System.Drawing.Point(122, 257);
            this.SearchMembersPageButton.Name = "SearchMembersPageButton";
            this.SearchMembersPageButton.Size = new System.Drawing.Size(201, 38);
            this.SearchMembersPageButton.TabIndex = 2;
            this.SearchMembersPageButton.Text = "Search Members\r\n";
            this.SearchMembersPageButton.UseVisualStyleBackColor = true;
            this.SearchMembersPageButton.Click += new System.EventHandler(this.SearchMembersPageButton_Click);
            // 
            // FitnessClassesPageButton
            // 
            this.FitnessClassesPageButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitnessClassesPageButton.Location = new System.Drawing.Point(122, 324);
            this.FitnessClassesPageButton.Name = "FitnessClassesPageButton";
            this.FitnessClassesPageButton.Size = new System.Drawing.Size(201, 36);
            this.FitnessClassesPageButton.TabIndex = 3;
            this.FitnessClassesPageButton.Text = "Fitness Classes\r\n";
            this.FitnessClassesPageButton.UseVisualStyleBackColor = true;
            this.FitnessClassesPageButton.Click += new System.EventHandler(this.FitnessClassesPageButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(122, 518);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(201, 39);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit\r\n";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HelpPageButton
            // 
            this.HelpPageButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpPageButton.Location = new System.Drawing.Point(122, 459);
            this.HelpPageButton.Name = "HelpPageButton";
            this.HelpPageButton.Size = new System.Drawing.Size(201, 39);
            this.HelpPageButton.TabIndex = 5;
            this.HelpPageButton.Text = "Help";
            this.HelpPageButton.UseVisualStyleBackColor = true;
            this.HelpPageButton.Click += new System.EventHandler(this.HelpPageButton_Click);
            // 
            // CityGymLogoMain
            // 
            this.CityGymLogoMain.Image = ((System.Drawing.Image)(resources.GetObject("CityGymLogoMain.Image")));
            this.CityGymLogoMain.Location = new System.Drawing.Point(122, 41);
            this.CityGymLogoMain.Name = "CityGymLogoMain";
            this.CityGymLogoMain.Size = new System.Drawing.Size(201, 92);
            this.CityGymLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CityGymLogoMain.TabIndex = 6;
            this.CityGymLogoMain.TabStop = false;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 618);
            this.Controls.Add(this.CityGymLogoMain);
            this.Controls.Add(this.HelpPageButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FitnessClassesPageButton);
            this.Controls.Add(this.SearchMembersPageButton);
            this.Controls.Add(this.MembershipFormPageButton);
            this.Controls.Add(this.label1);
            this.Name = "menuForm";
            this.Text = "City Gym Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MembershipFormPageButton;
        private System.Windows.Forms.Button SearchMembersPageButton;
        private System.Windows.Forms.Button FitnessClassesPageButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HelpPageButton;
        private System.Windows.Forms.PictureBox CityGymLogoMain;
    }
}