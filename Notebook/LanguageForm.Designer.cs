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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageForm));
            this.changeLanguage_button = new System.Windows.Forms.Button();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.languageWindow_label = new System.Windows.Forms.Label();
            this.language_comboBox = new System.Windows.Forms.ComboBox();
            this.goBack_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeLanguage_button
            // 
            this.changeLanguage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeLanguage_button.Location = new System.Drawing.Point(363, 179);
            this.changeLanguage_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changeLanguage_button.Name = "changeLanguage_button";
            this.changeLanguage_button.Size = new System.Drawing.Size(134, 41);
            this.changeLanguage_button.TabIndex = 27;
            this.changeLanguage_button.Text = "прийняти зміни";
            this.changeLanguage_button.UseVisualStyleBackColor = true;
            this.changeLanguage_button.Click += new System.EventHandler(this.changeLanguage_button_Click);
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu_button.Location = new System.Drawing.Point(192, 179);
            this.mainMenu_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainMenu_button.Name = "mainMenu_button";
            this.mainMenu_button.Size = new System.Drawing.Size(133, 41);
            this.mainMenu_button.TabIndex = 25;
            this.mainMenu_button.Text = "головне меню";
            this.mainMenu_button.UseVisualStyleBackColor = true;
            this.mainMenu_button.Click += new System.EventHandler(this.mainMenu_button_Click);
            // 
            // languageWindow_label
            // 
            this.languageWindow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageWindow_label.Location = new System.Drawing.Point(54, 92);
            this.languageWindow_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageWindow_label.Name = "languageWindow_label";
            this.languageWindow_label.Size = new System.Drawing.Size(149, 18);
            this.languageWindow_label.TabIndex = 28;
            this.languageWindow_label.Text = "Вибрати мову:";
            this.languageWindow_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // language_comboBox
            // 
            this.language_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.language_comboBox.FormattingEnabled = true;
            this.language_comboBox.Items.AddRange(new object[] {
            "Українська",
            "Русский",
            "English"});
            this.language_comboBox.Location = new System.Drawing.Point(234, 89);
            this.language_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.language_comboBox.Name = "language_comboBox";
            this.language_comboBox.Size = new System.Drawing.Size(182, 24);
            this.language_comboBox.TabIndex = 29;
            // 
            // goBack_button
            // 
            this.goBack_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack_button.Location = new System.Drawing.Point(25, 179);
            this.goBack_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(135, 41);
            this.goBack_button.TabIndex = 30;
            this.goBack_button.Text = "назад";
            this.goBack_button.UseVisualStyleBackColor = true;
            this.goBack_button.Click += new System.EventHandler(this.goBack_button_Click);
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 232);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.language_comboBox);
            this.Controls.Add(this.languageWindow_label);
            this.Controls.Add(this.changeLanguage_button);
            this.Controls.Add(this.mainMenu_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LanguageForm";
            this.Text = "LanguageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanguageForm_FormClosing);
            this.Load += new System.EventHandler(this.LanguageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeLanguage_button;
        private System.Windows.Forms.Button mainMenu_button;
        private System.Windows.Forms.Label languageWindow_label;
        private System.Windows.Forms.ComboBox language_comboBox;
        private System.Windows.Forms.Button goBack_button;
    }
}