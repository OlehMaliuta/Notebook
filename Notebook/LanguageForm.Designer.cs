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
            this.settings_button = new System.Windows.Forms.Button();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.languageWindow_label = new System.Windows.Forms.Label();
            this.language_comboBox = new System.Windows.Forms.ComboBox();
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
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(201, 187);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(125, 33);
            this.settings_button.TabIndex = 26;
            this.settings_button.Text = "меню налаштування";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Location = new System.Drawing.Point(43, 187);
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
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 232);
            this.Controls.Add(this.language_comboBox);
            this.Controls.Add(this.languageWindow_label);
            this.Controls.Add(this.changeLanguage_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.mainMenu_button);
            this.Name = "LanguageForm";
            this.Text = "LanguageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeLanguage_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button mainMenu_button;
        private System.Windows.Forms.Label languageWindow_label;
        private System.Windows.Forms.ComboBox language_comboBox;
    }
}