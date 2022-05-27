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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.disable_button = new System.Windows.Forms.Button();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.sorting_comboBox = new System.Windows.Forms.ComboBox();
            this.birthdayWindow1_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.leftList_button = new System.Windows.Forms.Button();
            this.enterList_button = new System.Windows.Forms.Button();
            this.able_button = new System.Windows.Forms.Button();
            this.birthday_dataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatingListDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatingListDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rename = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.settings_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.birthday_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // disable_button
            // 
            this.disable_button.Location = new System.Drawing.Point(822, 211);
            this.disable_button.Name = "disable_button";
            this.disable_button.Size = new System.Drawing.Size(114, 33);
            this.disable_button.TabIndex = 23;
            this.disable_button.Text = "відмінити функцію";
            this.disable_button.UseVisualStyleBackColor = true;
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Location = new System.Drawing.Point(1097, 620);
            this.mainMenu_button.Name = "mainMenu_button";
            this.mainMenu_button.Size = new System.Drawing.Size(114, 33);
            this.mainMenu_button.TabIndex = 22;
            this.mainMenu_button.Text = "головне меню";
            this.mainMenu_button.UseVisualStyleBackColor = true;
            this.mainMenu_button.Click += new System.EventHandler(this.mainMenu_button_Click);
            // 
            // sorting_comboBox
            // 
            this.sorting_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sorting_comboBox.FormattingEnabled = true;
            this.sorting_comboBox.Location = new System.Drawing.Point(975, 455);
            this.sorting_comboBox.Name = "sorting_comboBox";
            this.sorting_comboBox.Size = new System.Drawing.Size(157, 21);
            this.sorting_comboBox.TabIndex = 21;
            // 
            // birthdayWindow1_label
            // 
            this.birthdayWindow1_label.AutoSize = true;
            this.birthdayWindow1_label.Location = new System.Drawing.Point(871, 458);
            this.birthdayWindow1_label.Name = "birthdayWindow1_label";
            this.birthdayWindow1_label.Size = new System.Drawing.Size(84, 13);
            this.birthdayWindow1_label.TabIndex = 20;
            this.birthdayWindow1_label.Text = "Сортування за:";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(773, 393);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(438, 20);
            this.search_textBox.TabIndex = 19;
            // 
            // leftList_button
            // 
            this.leftList_button.Location = new System.Drawing.Point(1059, 114);
            this.leftList_button.Name = "leftList_button";
            this.leftList_button.Size = new System.Drawing.Size(110, 23);
            this.leftList_button.TabIndex = 14;
            this.leftList_button.Text = "вийти зі списку";
            this.leftList_button.UseVisualStyleBackColor = true;
            // 
            // enterList_button
            // 
            this.enterList_button.Location = new System.Drawing.Point(822, 114);
            this.enterList_button.Name = "enterList_button";
            this.enterList_button.Size = new System.Drawing.Size(114, 23);
            this.enterList_button.TabIndex = 13;
            this.enterList_button.Text = "увійти до списку";
            this.enterList_button.UseVisualStyleBackColor = true;
            // 
            // able_button
            // 
            this.able_button.Location = new System.Drawing.Point(1059, 211);
            this.able_button.Name = "able_button";
            this.able_button.Size = new System.Drawing.Size(104, 33);
            this.able_button.TabIndex = 24;
            this.able_button.Text = "вімкнути функцію";
            this.able_button.UseVisualStyleBackColor = true;
            // 
            // birthday_dataGridView
            // 
            this.birthday_dataGridView.AllowUserToAddRows = false;
            this.birthday_dataGridView.AllowUserToDeleteRows = false;
            this.birthday_dataGridView.AllowUserToResizeColumns = false;
            this.birthday_dataGridView.AllowUserToResizeRows = false;
            this.birthday_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.birthday_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.birthday_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthday_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birthday_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.creatingListDate,
            this.updatingListDate,
            this.open,
            this.rename,
            this.delete});
            this.birthday_dataGridView.EnableHeadersVisualStyles = false;
            this.birthday_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.birthday_dataGridView.Name = "birthday_dataGridView";
            this.birthday_dataGridView.ReadOnly = true;
            this.birthday_dataGridView.RowHeadersVisible = false;
            this.birthday_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.birthday_dataGridView.Size = new System.Drawing.Size(736, 641);
            this.birthday_dataGridView.TabIndex = 25;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // creatingListDate
            // 
            this.creatingListDate.HeaderText = "Дата створення";
            this.creatingListDate.Name = "creatingListDate";
            this.creatingListDate.ReadOnly = true;
            this.creatingListDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.creatingListDate.Width = 86;
            // 
            // updatingListDate
            // 
            this.updatingListDate.HeaderText = "Дата оновлення";
            this.updatingListDate.Name = "updatingListDate";
            this.updatingListDate.ReadOnly = true;
            this.updatingListDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.updatingListDate.Width = 87;
            // 
            // open
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.DefaultCellStyle = dataGridViewCellStyle5;
            this.open.HeaderText = "*Відкрити*";
            this.open.Name = "open";
            this.open.ReadOnly = true;
            this.open.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.open.Text = "...";
            this.open.Width = 65;
            // 
            // rename
            // 
            this.rename.HeaderText = "*Переіменувати*";
            this.rename.Name = "rename";
            this.rename.ReadOnly = true;
            this.rename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rename.Width = 97;
            // 
            // delete
            // 
            this.delete.HeaderText = "*Видалити*";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Width = 69;
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(773, 620);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(125, 33);
            this.settings_button.TabIndex = 27;
            this.settings_button.Text = "меню налаштування";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // BirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 663);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.birthday_dataGridView);
            this.Controls.Add(this.able_button);
            this.Controls.Add(this.disable_button);
            this.Controls.Add(this.mainMenu_button);
            this.Controls.Add(this.sorting_comboBox);
            this.Controls.Add(this.birthdayWindow1_label);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.leftList_button);
            this.Controls.Add(this.enterList_button);
            this.Name = "BirthdayForm";
            this.Text = "BirthdayForm";
            ((System.ComponentModel.ISupportInitialize)(this.birthday_dataGridView)).EndInit();
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
        private System.Windows.Forms.Button able_button;
        private System.Windows.Forms.DataGridView birthday_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatingListDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatingListDate;
        private System.Windows.Forms.DataGridViewButtonColumn open;
        private System.Windows.Forms.DataGridViewButtonColumn rename;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button settings_button;
    }
}