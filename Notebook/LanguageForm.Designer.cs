namespace Notebook
{
    partial class LanguageForm
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
            this.changeLanguage_button = new System.Windows.Forms.Button();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.languageWindow_label = new System.Windows.Forms.Label();
            this.language_comboBox = new System.Windows.Forms.ComboBox();
            this.goBack_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeLanguage_button
            // 
            this.changeLanguage_button.Location = new System.Drawing.Point(373, 187);
            this.changeLanguage_button.Name = "changeLanguage_button";
            this.changeLanguage_button.Size = new System.Drawing.Size(104, 33);
            this.changeLanguage_button.TabIndex = 27;
            this.changeLanguage_button.Text = "прийняти зміни";
            this.changeLanguage_button.UseVisualStyleBackColor = true;
            this.changeLanguage_button.Click += new System.EventHandler(this.changeLanguage_button_Click);
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Location = new System.Drawing.Point(204, 187);
            this.mainMenu_button.Name = "mainMenu_button";
            this.mainMenu_button.Size = new System.Drawing.Size(114, 33);
            this.mainMenu_button.TabIndex = 25;
            this.mainMenu_button.Text = "головне меню";
            this.mainMenu_button.UseVisualStyleBackColor = true;
            this.mainMenu_button.Click += new System.EventHandler(this.mainMenu_button_Click);
            // 
            // languageWindow_label
            // 
            this.languageWindow_label.AutoSize = true;
            this.languageWindow_label.Location = new System.Drawing.Point(134, 92);
            this.languageWindow_label.Name = "languageWindow_label";
            this.languageWindow_label.Size = new System.Drawing.Size(80, 13);
            this.languageWindow_label.TabIndex = 28;
            this.languageWindow_label.Text = "Вибрати мову:";
            // 
            // language_comboBox
            // 
            this.language_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language_comboBox.FormattingEnabled = true;
            this.language_comboBox.Items.AddRange(new object[] {
            "Українська",
            "Русский",
            "English"});
            this.language_comboBox.Location = new System.Drawing.Point(240, 89);
            this.language_comboBox.Name = "language_comboBox";
            this.language_comboBox.Size = new System.Drawing.Size(157, 21);
            this.language_comboBox.TabIndex = 29;
            // 
            // goBack_button
            // 
            this.goBack_button.Location = new System.Drawing.Point(39, 187);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(116, 33);
            this.goBack_button.TabIndex = 30;
            this.goBack_button.Text = "назад";
            this.goBack_button.UseVisualStyleBackColor = true;
            this.goBack_button.Click += new System.EventHandler(this.goBack_button_Click);
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 232);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.language_comboBox);
            this.Controls.Add(this.languageWindow_label);
            this.Controls.Add(this.changeLanguage_button);
            this.Controls.Add(this.mainMenu_button);
            this.Name = "LanguageForm";
            this.Text = "LanguageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanguageForm_FormClosing);
            this.Load += new System.EventHandler(this.LanguageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeLanguage_button;
        private System.Windows.Forms.Button mainMenu_button;
        private System.Windows.Forms.Label languageWindow_label;
        private System.Windows.Forms.ComboBox language_comboBox;
        private System.Windows.Forms.Button goBack_button;
    }
}