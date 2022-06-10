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
            this.exit_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.sortingElements_comboBox = new System.Windows.Forms.ComboBox();
            this.listWindow2_label = new System.Windows.Forms.Label();
            this.searchElement_textBox = new System.Windows.Forms.TextBox();
            this.searchElement_comboBox = new System.Windows.Forms.ComboBox();
            this.listWindow1_label = new System.Windows.Forms.Label();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.elements_dataGridView = new System.Windows.Forms.DataGridView();
            this.createDocxFile_button = new System.Windows.Forms.Button();
            this.createTxtFile_button = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elements_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addElement_button
            // 
            this.addElement_button.Location = new System.Drawing.Point(943, 69);
            this.addElement_button.Name = "addElement_button";
            this.addElement_button.Size = new System.Drawing.Size(110, 104);
            this.addElement_button.TabIndex = 2;
            this.addElement_button.Text = "додати елемент";
            this.addElement_button.UseVisualStyleBackColor = true;
            this.addElement_button.Click += new System.EventHandler(this.addElement_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1110, 594);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(118, 57);
            this.exit_button.TabIndex = 16;
            this.exit_button.Text = "вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(772, 594);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(118, 59);
            this.settings_button.TabIndex = 15;
            this.settings_button.Text = "налаштування";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // sortingElements_comboBox
            // 
            this.sortingElements_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingElements_comboBox.FormattingEnabled = true;
            this.sortingElements_comboBox.Location = new System.Drawing.Point(980, 492);
            this.sortingElements_comboBox.Name = "sortingElements_comboBox";
            this.sortingElements_comboBox.Size = new System.Drawing.Size(157, 21);
            this.sortingElements_comboBox.TabIndex = 14;
            // 
            // listWindow2_label
            // 
            this.listWindow2_label.AutoSize = true;
            this.listWindow2_label.Location = new System.Drawing.Point(839, 495);
            this.listWindow2_label.Name = "listWindow2_label";
            this.listWindow2_label.Size = new System.Drawing.Size(84, 13);
            this.listWindow2_label.TabIndex = 13;
            this.listWindow2_label.Text = "Сортування за:";
            // 
            // searchElement_textBox
            // 
            this.searchElement_textBox.Location = new System.Drawing.Point(783, 368);
            this.searchElement_textBox.Name = "searchElement_textBox";
            this.searchElement_textBox.Size = new System.Drawing.Size(428, 20);
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
            this.searchElement_comboBox.Location = new System.Drawing.Point(980, 437);
            this.searchElement_comboBox.Name = "searchElement_comboBox";
            this.searchElement_comboBox.Size = new System.Drawing.Size(157, 21);
            this.searchElement_comboBox.TabIndex = 18;
            // 
            // listWindow1_label
            // 
            this.listWindow1_label.AutoSize = true;
            this.listWindow1_label.Location = new System.Drawing.Point(853, 440);
            this.listWindow1_label.Name = "listWindow1_label";
            this.listWindow1_label.Size = new System.Drawing.Size(58, 13);
            this.listWindow1_label.TabIndex = 17;
            this.listWindow1_label.Text = "Пошук за:";
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Location = new System.Drawing.Point(926, 594);
            this.mainMenu_button.Name = "mainMenu_button";
            this.mainMenu_button.Size = new System.Drawing.Size(146, 57);
            this.mainMenu_button.TabIndex = 19;
            this.mainMenu_button.Text = "головне меню";
            this.mainMenu_button.UseVisualStyleBackColor = true;
            this.mainMenu_button.Click += new System.EventHandler(this.mainMenu_button_Click);
            // 
            // elements_dataGridView
            // 
            this.elements_dataGridView.AllowUserToAddRows = false;
            this.elements_dataGridView.AllowUserToDeleteRows = false;
            this.elements_dataGridView.AllowUserToResizeColumns = false;
            this.elements_dataGridView.AllowUserToResizeRows = false;
            this.elements_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.elements_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.elements_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elements_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elements_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.birthday,
            this.open,
            this.delete});
            this.elements_dataGridView.EnableHeadersVisualStyles = false;
            this.elements_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.elements_dataGridView.Name = "elements_dataGridView";
            this.elements_dataGridView.ReadOnly = true;
            this.elements_dataGridView.RowHeadersVisible = false;
            this.elements_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elements_dataGridView.Size = new System.Drawing.Size(736, 641);
            this.elements_dataGridView.TabIndex = 21;
            this.elements_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elements_dataGridView_CellClick);
            // 
            // createDocxFile_button
            // 
            this.createDocxFile_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createDocxFile_button.Location = new System.Drawing.Point(1036, 208);
            this.createDocxFile_button.Name = "createDocxFile_button";
            this.createDocxFile_button.Size = new System.Drawing.Size(144, 93);
            this.createDocxFile_button.TabIndex = 23;
            this.createDocxFile_button.Text = "зберегти у список форматі .docx";
            this.createDocxFile_button.UseVisualStyleBackColor = true;
            // 
            // createTxtFile_button
            // 
            this.createTxtFile_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createTxtFile_button.Location = new System.Drawing.Point(814, 208);
            this.createTxtFile_button.Name = "createTxtFile_button";
            this.createTxtFile_button.Size = new System.Drawing.Size(144, 93);
            this.createTxtFile_button.TabIndex = 22;
            this.createTxtFile_button.Text = "зберегти список у форматі .txt";
            this.createTxtFile_button.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Ім\'я";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // birthday
            // 
            this.birthday.HeaderText = "дата народження";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 110;
            // 
            // open
            // 
            this.open.HeaderText = "Детальніше";
            this.open.Name = "open";
            this.open.ReadOnly = true;
            this.open.Width = 73;
            // 
            // delete
            // 
            this.delete.HeaderText = "Видалити";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 61;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 663);
            this.Controls.Add(this.createDocxFile_button);
            this.Controls.Add(this.createTxtFile_button);
            this.Controls.Add(this.elements_dataGridView);
            this.Controls.Add(this.mainMenu_button);
            this.Controls.Add(this.searchElement_comboBox);
            this.Controls.Add(this.listWindow1_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.sortingElements_comboBox);
            this.Controls.Add(this.listWindow2_label);
            this.Controls.Add(this.searchElement_textBox);
            this.Controls.Add(this.addElement_button);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elements_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addElement_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.ComboBox sortingElements_comboBox;
        private System.Windows.Forms.Label listWindow2_label;
        private System.Windows.Forms.TextBox searchElement_textBox;
        private System.Windows.Forms.ComboBox searchElement_comboBox;
        private System.Windows.Forms.Label listWindow1_label;
        private System.Windows.Forms.Button mainMenu_button;
        private System.Windows.Forms.DataGridView elements_dataGridView;
        private System.Windows.Forms.Button createDocxFile_button;
        private System.Windows.Forms.Button createTxtFile_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewButtonColumn open;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}