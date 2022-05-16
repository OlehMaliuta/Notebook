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
            this.birthdaySettings_button = new System.Windows.Forms.Button();
            this.languageSettings_button = new System.Windows.Forms.Button();
            this.goBack_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birthdaySettings_button
            // 
            this.birthdaySettings_button.Location = new System.Drawing.Point(115, 84);
            this.birthdaySettings_button.Name = "birthdaySettings_button";
            this.birthdaySettings_button.Size = new System.Drawing.Size(193, 23);
            this.birthdaySettings_button.TabIndex = 0;
            this.birthdaySettings_button.Text = "дні народження";
            this.birthdaySettings_button.UseVisualStyleBackColor = true;
            // 
            // languageSettings_button
            // 
            this.languageSettings_button.Location = new System.Drawing.Point(108, 142);
            this.languageSettings_button.Name = "languageSettings_button";
            this.languageSettings_button.Size = new System.Drawing.Size(200, 23);
            this.languageSettings_button.TabIndex = 1;
            this.languageSettings_button.Text = "зміна мови";
            this.languageSettings_button.UseVisualStyleBackColor = true;
            // 
            // goBack_button
            // 
            this.goBack_button.Location = new System.Drawing.Point(171, 267);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(75, 23);
            this.goBack_button.TabIndex = 8;
            this.goBack_button.Text = "назад";
            this.goBack_button.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 348);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.languageSettings_button);
            this.Controls.Add(this.birthdaySettings_button);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button birthdaySettings_button;
        private System.Windows.Forms.Button languageSettings_button;
        private System.Windows.Forms.Button goBack_button;
    }
}