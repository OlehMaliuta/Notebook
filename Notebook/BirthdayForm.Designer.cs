namespace Notebook
{
    partial class BirthdayForm
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
            this.disable_button = new System.Windows.Forms.Button();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.sorting_comboBox = new System.Windows.Forms.ComboBox();
            this.birthdayWindow1_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.leftList_button = new System.Windows.Forms.Button();
            this.enterList_button = new System.Windows.Forms.Button();
            this.Lists_listBox = new System.Windows.Forms.ListBox();
            this.able_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disable_button
            // 
            this.disable_button.Location = new System.Drawing.Point(881, 620);
            this.disable_button.Name = "disable_button";
            this.disable_button.Size = new System.Drawing.Size(114, 33);
            this.disable_button.TabIndex = 23;
            this.disable_button.Text = "відмінити функцію";
            this.disable_button.UseVisualStyleBackColor = true;
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Location = new System.Drawing.Point(674, 620);
            this.mainMenu_button.Name = "mainMenu_button";
            this.mainMenu_button.Size = new System.Drawing.Size(114, 33);
            this.mainMenu_button.TabIndex = 22;
            this.mainMenu_button.Text = "головне меню";
            this.mainMenu_button.UseVisualStyleBackColor = true;
            // 
            // sorting_comboBox
            // 
            this.sorting_comboBox.FormattingEnabled = true;
            this.sorting_comboBox.Location = new System.Drawing.Point(939, 459);
            this.sorting_comboBox.Name = "sorting_comboBox";
            this.sorting_comboBox.Size = new System.Drawing.Size(157, 21);
            this.sorting_comboBox.TabIndex = 21;
            // 
            // birthdayWindow1_label
            // 
            this.birthdayWindow1_label.AutoSize = true;
            this.birthdayWindow1_label.Location = new System.Drawing.Point(798, 462);
            this.birthdayWindow1_label.Name = "birthdayWindow1_label";
            this.birthdayWindow1_label.Size = new System.Drawing.Size(84, 13);
            this.birthdayWindow1_label.TabIndex = 20;
            this.birthdayWindow1_label.Text = "Сортування за:";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(674, 393);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(537, 20);
            this.search_textBox.TabIndex = 19;
            // 
            // leftList_button
            // 
            this.leftList_button.Location = new System.Drawing.Point(885, 270);
            this.leftList_button.Name = "leftList_button";
            this.leftList_button.Size = new System.Drawing.Size(110, 23);
            this.leftList_button.TabIndex = 14;
            this.leftList_button.Text = "вийти зі списку";
            this.leftList_button.UseVisualStyleBackColor = true;
            // 
            // enterList_button
            // 
            this.enterList_button.Location = new System.Drawing.Point(881, 142);
            this.enterList_button.Name = "enterList_button";
            this.enterList_button.Size = new System.Drawing.Size(114, 23);
            this.enterList_button.TabIndex = 13;
            this.enterList_button.Text = "увійти до списку";
            this.enterList_button.UseVisualStyleBackColor = true;
            // 
            // Lists_listBox
            // 
            this.Lists_listBox.FormattingEnabled = true;
            this.Lists_listBox.Location = new System.Drawing.Point(12, 12);
            this.Lists_listBox.Name = "Lists_listBox";
            this.Lists_listBox.Size = new System.Drawing.Size(628, 641);
            this.Lists_listBox.TabIndex = 12;
            // 
            // able_button
            // 
            this.able_button.Location = new System.Drawing.Point(1093, 620);
            this.able_button.Name = "able_button";
            this.able_button.Size = new System.Drawing.Size(104, 33);
            this.able_button.TabIndex = 24;
            this.able_button.Text = "вімкнути функцію";
            this.able_button.UseVisualStyleBackColor = true;
            // 
            // BirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 663);
            this.Controls.Add(this.able_button);
            this.Controls.Add(this.disable_button);
            this.Controls.Add(this.mainMenu_button);
            this.Controls.Add(this.sorting_comboBox);
            this.Controls.Add(this.birthdayWindow1_label);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.leftList_button);
            this.Controls.Add(this.enterList_button);
            this.Controls.Add(this.Lists_listBox);
            this.Name = "BirthdayForm";
            this.Text = "BirthdayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disable_button;
        private System.Windows.Forms.Button mainMenu_button;
        private System.Windows.Forms.ComboBox sorting_comboBox;
        private System.Windows.Forms.Label birthdayWindow1_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button leftList_button;
        private System.Windows.Forms.Button enterList_button;
        private System.Windows.Forms.ListBox Lists_listBox;
        private System.Windows.Forms.Button able_button;
    }
}