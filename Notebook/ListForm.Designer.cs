namespace Notebook
{
    partial class ListForm
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
            this.addElement_button = new System.Windows.Forms.Button();
            this.deleteElement_button = new System.Windows.Forms.Button();
            this.changeInfo_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.sortingElements_comboBox = new System.Windows.Forms.ComboBox();
            this.listWindow2_label = new System.Windows.Forms.Label();
            this.searchElement_textBox = new System.Windows.Forms.TextBox();
            this.searchElement_comboBox = new System.Windows.Forms.ComboBox();
            this.listWindow1_label = new System.Windows.Forms.Label();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.elements_dataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentionalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodSides = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elements_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addElement_button
            // 
            this.addElement_button.Location = new System.Drawing.Point(926, 96);
            this.addElement_button.Name = "addElement_button";
            this.addElement_button.Size = new System.Drawing.Size(110, 23);
            this.addElement_button.TabIndex = 2;
            this.addElement_button.Text = "додати елемент";
            this.addElement_button.UseVisualStyleBackColor = true;
            // 
            // deleteElement_button
            // 
            this.deleteElement_button.Location = new System.Drawing.Point(926, 174);
            this.deleteElement_button.Name = "deleteElement_button";
            this.deleteElement_button.Size = new System.Drawing.Size(110, 23);
            this.deleteElement_button.TabIndex = 3;
            this.deleteElement_button.Text = "видалити елемент";
            this.deleteElement_button.UseVisualStyleBackColor = true;
            // 
            // changeInfo_button
            // 
            this.changeInfo_button.Location = new System.Drawing.Point(926, 266);
            this.changeInfo_button.Name = "changeInfo_button";
            this.changeInfo_button.Size = new System.Drawing.Size(110, 23);
            this.changeInfo_button.TabIndex = 4;
            this.changeInfo_button.Text = "змінити дані";
            this.changeInfo_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1113, 611);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(98, 33);
            this.exit_button.TabIndex = 16;
            this.exit_button.Text = "вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(738, 611);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(98, 33);
            this.settings_button.TabIndex = 15;
            this.settings_button.Text = "налаштування";
            this.settings_button.UseVisualStyleBackColor = true;
            // 
            // sortingElements_comboBox
            // 
            this.sortingElements_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingElements_comboBox.FormattingEnabled = true;
            this.sortingElements_comboBox.Location = new System.Drawing.Point(939, 498);
            this.sortingElements_comboBox.Name = "sortingElements_comboBox";
            this.sortingElements_comboBox.Size = new System.Drawing.Size(157, 21);
            this.sortingElements_comboBox.TabIndex = 14;
            // 
            // listWindow2_label
            // 
            this.listWindow2_label.AutoSize = true;
            this.listWindow2_label.Location = new System.Drawing.Point(798, 501);
            this.listWindow2_label.Name = "listWindow2_label";
            this.listWindow2_label.Size = new System.Drawing.Size(84, 13);
            this.listWindow2_label.TabIndex = 13;
            this.listWindow2_label.Text = "Сортування за:";
            // 
            // searchElement_textBox
            // 
            this.searchElement_textBox.Location = new System.Drawing.Point(750, 368);
            this.searchElement_textBox.Name = "searchElement_textBox";
            this.searchElement_textBox.Size = new System.Drawing.Size(461, 20);
            this.searchElement_textBox.TabIndex = 12;
            this.searchElement_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchElement_comboBox
            // 
            this.searchElement_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchElement_comboBox.FormattingEnabled = true;
            this.searchElement_comboBox.Items.AddRange(new object[] {
            "ім\'ям",
            "телефоном",
            "датою народження",
            "анкетними даними",
            "місцем проживання",
            "місцем роботи/навчання",
            "характером знайомства"});
            this.searchElement_comboBox.Location = new System.Drawing.Point(939, 443);
            this.searchElement_comboBox.Name = "searchElement_comboBox";
            this.searchElement_comboBox.Size = new System.Drawing.Size(157, 21);
            this.searchElement_comboBox.TabIndex = 18;
            // 
            // listWindow1_label
            // 
            this.listWindow1_label.AutoSize = true;
            this.listWindow1_label.Location = new System.Drawing.Point(812, 446);
            this.listWindow1_label.Name = "listWindow1_label";
            this.listWindow1_label.Size = new System.Drawing.Size(58, 13);
            this.listWindow1_label.TabIndex = 17;
            this.listWindow1_label.Text = "Пошук за:";
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Location = new System.Drawing.Point(917, 611);
            this.mainMenu_button.Name = "mainMenu_button";
            this.mainMenu_button.Size = new System.Drawing.Size(119, 33);
            this.mainMenu_button.TabIndex = 19;
            this.mainMenu_button.Text = "головне меню";
            this.mainMenu_button.UseVisualStyleBackColor = true;
            // 
            // elements_dataGridView
            // 
            this.elements_dataGridView.AllowUserToAddRows = false;
            this.elements_dataGridView.AllowUserToDeleteRows = false;
            this.elements_dataGridView.AllowUserToResizeColumns = false;
            this.elements_dataGridView.AllowUserToResizeRows = false;
            this.elements_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elements_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.phone,
            this.birthday,
            this.personalData,
            this.residentionalAddress,
            this.locale,
            this.firstMeeting,
            this.goodSides,
            this.extraInfo});
            this.elements_dataGridView.Location = new System.Drawing.Point(12, 10);
            this.elements_dataGridView.Name = "elements_dataGridView";
            this.elements_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elements_dataGridView.Size = new System.Drawing.Size(700, 641);
            this.elements_dataGridView.TabIndex = 20;
            // 
            // name
            // 
            this.name.HeaderText = "Ім\'я";
            this.name.Name = "name";
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            // 
            // birthday
            // 
            this.birthday.HeaderText = "Дата народження";
            this.birthday.Name = "birthday";
            // 
            // personalData
            // 
            this.personalData.HeaderText = "Анкетні дані";
            this.personalData.Name = "personalData";
            // 
            // residentionalAddress
            // 
            this.residentionalAddress.HeaderText = "Місце проживання";
            this.residentionalAddress.Name = "residentionalAddress";
            // 
            // locale
            // 
            this.locale.HeaderText = "Місце роботи/ навчання";
            this.locale.Name = "locale";
            // 
            // firstMeeting
            // 
            this.firstMeeting.HeaderText = "Характер знайомства";
            this.firstMeeting.Name = "firstMeeting";
            // 
            // goodSides
            // 
            this.goodSides.HeaderText = "Ділові якості";
            this.goodSides.Name = "goodSides";
            // 
            // extraInfo
            // 
            this.extraInfo.HeaderText = "Інша інфор.";
            this.extraInfo.Name = "extraInfo";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 663);
            this.Controls.Add(this.elements_dataGridView);
            this.Controls.Add(this.mainMenu_button);
            this.Controls.Add(this.searchElement_comboBox);
            this.Controls.Add(this.listWindow1_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.sortingElements_comboBox);
            this.Controls.Add(this.listWindow2_label);
            this.Controls.Add(this.searchElement_textBox);
            this.Controls.Add(this.changeInfo_button);
            this.Controls.Add(this.deleteElement_button);
            this.Controls.Add(this.addElement_button);
            this.Name = "ListForm";
            this.Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)(this.elements_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addElement_button;
        private System.Windows.Forms.Button deleteElement_button;
        private System.Windows.Forms.Button changeInfo_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.ComboBox sortingElements_comboBox;
        private System.Windows.Forms.Label listWindow2_label;
        private System.Windows.Forms.TextBox searchElement_textBox;
        private System.Windows.Forms.ComboBox searchElement_comboBox;
        private System.Windows.Forms.Label listWindow1_label;
        private System.Windows.Forms.Button mainMenu_button;
        private System.Windows.Forms.DataGridView elements_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentionalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn locale;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstMeeting;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodSides;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraInfo;
    }
}