namespace Notebook
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.changeLanguageButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.languageWindowLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeLanguageButton
            // 
            this.changeLanguageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeLanguageButton.Location = new System.Drawing.Point(363, 179);
            this.changeLanguageButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changeLanguageButton.Name = "changeLanguageButton";
            this.changeLanguageButton.Size = new System.Drawing.Size(134, 41);
            this.changeLanguageButton.TabIndex = 27;
            this.changeLanguageButton.Text = "Apply";
            this.changeLanguageButton.UseVisualStyleBackColor = true;
            this.changeLanguageButton.Click += new System.EventHandler(this.ChangeLanguageButtonClick);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuButton.Location = new System.Drawing.Point(192, 179);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(133, 41);
            this.mainMenuButton.TabIndex = 25;
            this.mainMenuButton.Text = "Main menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // languageWindowLabel
            // 
            this.languageWindowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageWindowLabel.Location = new System.Drawing.Point(103, 85);
            this.languageWindowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageWindowLabel.Name = "languageWindowLabel";
            this.languageWindowLabel.Size = new System.Drawing.Size(149, 18);
            this.languageWindowLabel.TabIndex = 28;
            this.languageWindowLabel.Text = "App language:";
            this.languageWindowLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(260, 82);
            this.languageComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(182, 24);
            this.languageComboBox.TabIndex = 29;
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(25, 179);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(135, 41);
            this.goBackButton.TabIndex = 30;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 232);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageWindowLabel);
            this.Controls.Add(this.changeLanguageButton);
            this.Controls.Add(this.mainMenuButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LanguageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanguageFormFormClosing);
            this.Load += new System.EventHandler(this.LanguageFormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeLanguageButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label languageWindowLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Button goBackButton;
    }
}