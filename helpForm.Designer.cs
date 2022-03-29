
namespace assign3_database_application
{
    partial class helpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpForm));
            this.CityGymLogoHelp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpPageInfoBox = new System.Windows.Forms.RichTextBox();
            this.MainMenuHelpButton = new System.Windows.Forms.Button();
            this.ExitHelpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // CityGymLogoHelp
            // 
            this.CityGymLogoHelp.Image = ((System.Drawing.Image)(resources.GetObject("CityGymLogoHelp.Image")));
            this.CityGymLogoHelp.Location = new System.Drawing.Point(121, 29);
            this.CityGymLogoHelp.Name = "CityGymLogoHelp";
            this.CityGymLogoHelp.Size = new System.Drawing.Size(226, 96);
            this.CityGymLogoHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CityGymLogoHelp.TabIndex = 0;
            this.CityGymLogoHelp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Help Page\r\n";
            // 
            // HelpPageInfoBox
            // 
            this.HelpPageInfoBox.Location = new System.Drawing.Point(49, 186);
            this.HelpPageInfoBox.Name = "HelpPageInfoBox";
            this.HelpPageInfoBox.Size = new System.Drawing.Size(380, 319);
            this.HelpPageInfoBox.TabIndex = 3;
            this.HelpPageInfoBox.Text = resources.GetString("HelpPageInfoBox.Text");
            // 
            // MainMenuHelpButton
            // 
            this.MainMenuHelpButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuHelpButton.Location = new System.Drawing.Point(121, 520);
            this.MainMenuHelpButton.Name = "MainMenuHelpButton";
            this.MainMenuHelpButton.Size = new System.Drawing.Size(226, 41);
            this.MainMenuHelpButton.TabIndex = 4;
            this.MainMenuHelpButton.Text = "Main Menu";
            this.MainMenuHelpButton.UseVisualStyleBackColor = true;
            this.MainMenuHelpButton.Click += new System.EventHandler(this.MainMenuHelpButton_Click);
            // 
            // ExitHelpButton
            // 
            this.ExitHelpButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitHelpButton.Location = new System.Drawing.Point(121, 585);
            this.ExitHelpButton.Name = "ExitHelpButton";
            this.ExitHelpButton.Size = new System.Drawing.Size(226, 41);
            this.ExitHelpButton.TabIndex = 5;
            this.ExitHelpButton.Text = "Exit\r\n";
            this.ExitHelpButton.UseVisualStyleBackColor = true;
            this.ExitHelpButton.Click += new System.EventHandler(this.ExitHelpButton_Click);
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 643);
            this.Controls.Add(this.ExitHelpButton);
            this.Controls.Add(this.MainMenuHelpButton);
            this.Controls.Add(this.HelpPageInfoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityGymLogoHelp);
            this.Name = "helpForm";
            this.Text = "City Gym Help Page";
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogoHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CityGymLogoHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox HelpPageInfoBox;
        private System.Windows.Forms.Button MainMenuHelpButton;
        private System.Windows.Forms.Button ExitHelpButton;
    }
}