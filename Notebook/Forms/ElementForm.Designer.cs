namespace Notebook
{
    partial class ElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementForm));
            this.editElementButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.extraInfoTextBox = new System.Windows.Forms.TextBox();
            this.extraInfoLabel = new System.Windows.Forms.Label();
            this.isDateOfBirthAllowedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // editElementButton
            // 
            this.editElementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editElementButton.Location = new System.Drawing.Point(130, 411);
            this.editElementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editElementButton.Name = "editElementButton";
            this.editElementButton.Size = new System.Drawing.Size(111, 44);
            this.editElementButton.TabIndex = 0;
            this.editElementButton.Text = "створити";
            this.editElementButton.UseVisualStyleBackColor = true;
            this.editElementButton.Click += new System.EventHandler(this.ChangeElementButtonClick);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(13, 411);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(109, 44);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 38);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(241, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(12, 88);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(241, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(12, 138);
            this.middleNameTextBox.MaxLength = 50;
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(241, 20);
            this.middleNameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.Location = new System.Drawing.Point(12, 19);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(89, 16);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First name *";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.Location = new System.Drawing.Point(12, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(88, 16);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last name *";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.middleNameLabel.Location = new System.Drawing.Point(12, 119);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(96, 16);
            this.middleNameLabel.TabIndex = 7;
            this.middleNameLabel.Text = "Middle name";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(15, 286);
            this.phoneNoTextBox.MaxLength = 200;
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(238, 20);
            this.phoneNoTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(15, 340);
            this.emailTextBox.MaxLength = 500;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(238, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoSize = true;
            this.phoneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.phoneNoLabel.Location = new System.Drawing.Point(15, 267);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Size = new System.Drawing.Size(106, 16);
            this.phoneNoLabel.TabIndex = 10;
            this.phoneNoLabel.Text = "Phone number";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(15, 321);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(107, 16);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email address";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(33, 212);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 12;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(31, 193);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(91, 16);
            this.dateOfBirthLabel.TabIndex = 13;
            this.dateOfBirthLabel.Text = "Date of birth";
            // 
            // extraInfoTextBox
            // 
            this.extraInfoTextBox.Location = new System.Drawing.Point(283, 38);
            this.extraInfoTextBox.MaxLength = 5000;
            this.extraInfoTextBox.Multiline = true;
            this.extraInfoTextBox.Name = "extraInfoTextBox";
            this.extraInfoTextBox.Size = new System.Drawing.Size(355, 322);
            this.extraInfoTextBox.TabIndex = 14;
            // 
            // extraInfoLabel
            // 
            this.extraInfoLabel.AutoSize = true;
            this.extraInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.extraInfoLabel.Location = new System.Drawing.Point(280, 19);
            this.extraInfoLabel.Name = "extraInfoLabel";
            this.extraInfoLabel.Size = new System.Drawing.Size(71, 16);
            this.extraInfoLabel.TabIndex = 15;
            this.extraInfoLabel.Text = "Extra info";
            // 
            // isDateOfBirthAllowedCheckBox
            // 
            this.isDateOfBirthAllowedCheckBox.AutoSize = true;
            this.isDateOfBirthAllowedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.isDateOfBirthAllowedCheckBox.Location = new System.Drawing.Point(12, 215);
            this.isDateOfBirthAllowedCheckBox.Name = "isDateOfBirthAllowedCheckBox";
            this.isDateOfBirthAllowedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isDateOfBirthAllowedCheckBox.TabIndex = 16;
            this.isDateOfBirthAllowedCheckBox.UseVisualStyleBackColor = true;
            this.isDateOfBirthAllowedCheckBox.CheckedChanged += new System.EventHandler(this.IsDateOfBirthAllowedCheckBoxCheckedChanged);
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 467);
            this.Controls.Add(this.isDateOfBirthAllowedCheckBox);
            this.Controls.Add(this.extraInfoLabel);
            this.Controls.Add(this.extraInfoTextBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNoLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.editElementButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ElementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElementFormFormClosing);
            this.Load += new System.EventHandler(this.ElementFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox extraInfoTextBox;
        private System.Windows.Forms.Label extraInfoLabel;
        private System.Windows.Forms.CheckBox isDateOfBirthAllowedCheckBox;
    }
}