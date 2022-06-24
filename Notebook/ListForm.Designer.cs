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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.addElement_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.sortingElements_comboBox = new System.Windows.Forms.ComboBox();
            this.sort_label = new System.Windows.Forms.Label();
            this.searchElement_textBox = new System.Windows.Forms.TextBox();
            this.searchElement_comboBox = new System.Windows.Forms.ComboBox();
            this.search_label = new System.Windows.Forms.Label();
            this.mainMenu_button = new System.Windows.Forms.Button();
            this.elements_dataGridView = new System.Windows.Forms.DataGridView();
            this.createDocxFile_button = new System.Windows.Forms.Button();
            this.createTxtFile_button = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuSection = new System.Windows.Forms.ToolStripMenuItem();
            this.addElementTool = new System.Windows.Forms.ToolStripMenuItem();
            this.createTxtTool = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocxTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elements_dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addElement_button
            // 
            this.addElement_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addElement_button.Location = new System.Drawing.Point(958, 69);
            this.addElement_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addElement_button.Name = "addElement_button";
            this.addElement_button.Size = new System.Drawing.Size(128, 104);
            this.addElement_button.TabIndex = 2;
            this.addElement_button.Text = "додати елемент";
            this.addElement_button.UseVisualStyleBackColor = true;
            this.addElement_button.Click += new System.EventHandler(this.addElement_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(1126, 594);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(121, 57);
            this.exit_button.TabIndex = 16;
            this.exit_button.Text = "вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_button.Location = new System.Drawing.Point(788, 593);
            this.settings_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(138, 59);
            this.settings_button.TabIndex = 15;
            this.settings_button.Text = "меню налаштування";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // sortingElements_comboBox
            // 
            this.sortingElements_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingElements_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingElements_comboBox.FormattingEnabled = true;
            this.sortingElements_comboBox.Location = new System.Drawing.Point(997, 492);
            this.sortingElements_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortingElements_comboBox.Name = "sortingElements_comboBox";
            this.sortingElements_comboBox.Size = new System.Drawing.Size(182, 24);
            this.sortingElements_comboBox.TabIndex = 14;
            this.sortingElements_comboBox.SelectedIndexChanged += new System.EventHandler(this.sortingElements_comboBox_SelectedIndexChanged);
            // 
            // sort_label
            // 
            this.sort_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_label.Location = new System.Drawing.Point(824, 493);
            this.sort_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sort_label.Name = "sort_label";
            this.sort_label.Size = new System.Drawing.Size(136, 21);
            this.sort_label.TabIndex = 13;
            this.sort_label.Text = "Сортування за:";
            this.sort_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchElement_textBox
            // 
            this.searchElement_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchElement_textBox.Location = new System.Drawing.Point(810, 368);
            this.searchElement_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchElement_textBox.Name = "searchElement_textBox";
            this.searchElement_textBox.Size = new System.Drawing.Size(431, 22);
            this.searchElement_textBox.TabIndex = 12;
            this.searchElement_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchElement_textBox.TextChanged += new System.EventHandler(this.searchElement_textBox_TextChanged);
            // 
            // searchElement_comboBox
            // 
            this.searchElement_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchElement_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchElement_comboBox.FormattingEnabled = true;
            this.searchElement_comboBox.Location = new System.Drawing.Point(997, 437);
            this.searchElement_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchElement_comboBox.Name = "searchElement_comboBox";
            this.searchElement_comboBox.Size = new System.Drawing.Size(182, 24);
            this.searchElement_comboBox.TabIndex = 18;
            // 
            // search_label
            // 
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_label.Location = new System.Drawing.Point(827, 439);
            this.search_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(133, 18);
            this.search_label.TabIndex = 17;
            this.search_label.Text = "Пошук за:";
            this.search_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainMenu_button
            // 
            this.mainMenu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu_button.Location = new System.Drawing.Point(958, 593);
            this.mainMenu_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainMenu_button.Name = "mainMenu_button";
            this.mainMenu_button.Size = new System.Drawing.Size(141, 57);
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
            this.elements_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.elements_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.elements_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elements_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elements_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.birthday,
            this.creatingDate,
            this.updatingDate,
            this.open,
            this.delete});
            this.elements_dataGridView.EnableHeadersVisualStyles = false;
            this.elements_dataGridView.Location = new System.Drawing.Point(14, 69);
            this.elements_dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.elements_dataGridView.Name = "elements_dataGridView";
            this.elements_dataGridView.ReadOnly = true;
            this.elements_dataGridView.RowHeadersVisible = false;
            this.elements_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elements_dataGridView.Size = new System.Drawing.Size(766, 584);
            this.elements_dataGridView.TabIndex = 21;
            this.elements_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elements_dataGridView_CellClick);
            // 
            // createDocxFile_button
            // 
            this.createDocxFile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createDocxFile_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createDocxFile_button.Location = new System.Drawing.Point(1083, 208);
            this.createDocxFile_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createDocxFile_button.Name = "createDocxFile_button";
            this.createDocxFile_button.Size = new System.Drawing.Size(136, 93);
            this.createDocxFile_button.TabIndex = 23;
            this.createDocxFile_button.Text = "зберегти у список форматі .docx";
            this.createDocxFile_button.UseVisualStyleBackColor = true;
            this.createDocxFile_button.Click += new System.EventHandler(this.createDocxFile_button_Click);
            // 
            // createTxtFile_button
            // 
            this.createTxtFile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTxtFile_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createTxtFile_button.Location = new System.Drawing.Point(824, 208);
            this.createTxtFile_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createTxtFile_button.Name = "createTxtFile_button";
            this.createTxtFile_button.Size = new System.Drawing.Size(136, 93);
            this.createTxtFile_button.TabIndex = 22;
            this.createTxtFile_button.Text = "зберегти список у файлі .txt";
            this.createTxtFile_button.UseVisualStyleBackColor = true;
            this.createTxtFile_button.Click += new System.EventHandler(this.createTxtFile_button_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuSection});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip.TabIndex = 24;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuSection
            // 
            this.fileMenuSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addElementTool,
            this.createTxtTool,
            this.createDocxTool,
            this.exitTool});
            this.fileMenuSection.Name = "fileMenuSection";
            this.fileMenuSection.Size = new System.Drawing.Size(50, 20);
            this.fileMenuSection.Text = "Файл";
            // 
            // addElementTool
            // 
            this.addElementTool.Image = global::Notebook.Properties.Resources.plus;
            this.addElementTool.Name = "addElementTool";
            this.addElementTool.Size = new System.Drawing.Size(249, 22);
            this.addElementTool.Text = "Додати елемент";
            this.addElementTool.Click += new System.EventHandler(this.addElementTool_Click);
            // 
            // createTxtTool
            // 
            this.createTxtTool.Image = global::Notebook.Properties.Resources.TXT;
            this.createTxtTool.Name = "createTxtTool";
            this.createTxtTool.Size = new System.Drawing.Size(249, 22);
            this.createTxtTool.Text = "Зберегти список у файлі .txt";
            this.createTxtTool.Click += new System.EventHandler(this.createTxtTool_Click);
            // 
            // createDocxTool
            // 
            this.createDocxTool.Image = global::Notebook.Properties.Resources.DOCX;
            this.createDocxTool.Name = "createDocxTool";
            this.createDocxTool.Size = new System.Drawing.Size(249, 22);
            this.createDocxTool.Text = "Зберегти список у файлі .docx";
            this.createDocxTool.Click += new System.EventHandler(this.createDocxTool_Click);
            // 
            // exitTool
            // 
            this.exitTool.Image = global::Notebook.Properties.Resources.exit;
            this.exitTool.Name = "exitTool";
            this.exitTool.Size = new System.Drawing.Size(249, 22);
            this.exitTool.Text = "Вихід";
            this.exitTool.Click += new System.EventHandler(this.exitTool_Click);
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
            this.birthday.HeaderText = "Дата народження";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.birthday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.birthday.Width = 107;
            // 
            // creatingDate
            // 
            this.creatingDate.HeaderText = "Дата створення ел.";
            this.creatingDate.Name = "creatingDate";
            this.creatingDate.ReadOnly = true;
            this.creatingDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.creatingDate.Width = 102;
            // 
            // updatingDate
            // 
            this.updatingDate.HeaderText = "Дата оновлення ел.";
            this.updatingDate.Name = "updatingDate";
            this.updatingDate.ReadOnly = true;
            this.updatingDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.updatingDate.Width = 103;
            // 
            // open
            // 
            this.open.HeaderText = "*Детальніше*";
            this.open.Image = global::Notebook.Properties.Resources.note;
            this.open.Name = "open";
            this.open.ReadOnly = true;
            this.open.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.open.Width = 93;
            // 
            // delete
            // 
            this.delete.HeaderText = "*Видалити*";
            this.delete.Image = global::Notebook.Properties.Resources.remove;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 79;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 663);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.createDocxFile_button);
            this.Controls.Add(this.createTxtFile_button);
            this.Controls.Add(this.elements_dataGridView);
            this.Controls.Add(this.mainMenu_button);
            this.Controls.Add(this.searchElement_comboBox);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.sortingElements_comboBox);
            this.Controls.Add(this.sort_label);
            this.Controls.Add(this.searchElement_textBox);
            this.Controls.Add(this.addElement_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elements_dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addElement_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.ComboBox sortingElements_comboBox;
        private System.Windows.Forms.Label sort_label;
        private System.Windows.Forms.TextBox searchElement_textBox;
        private System.Windows.Forms.ComboBox searchElement_comboBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Button mainMenu_button;
        private System.Windows.Forms.DataGridView elements_dataGridView;
        private System.Windows.Forms.Button createDocxFile_button;
        private System.Windows.Forms.Button createTxtFile_button;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSection;
        private System.Windows.Forms.ToolStripMenuItem addElementTool;
        private System.Windows.Forms.ToolStripMenuItem createTxtTool;
        private System.Windows.Forms.ToolStripMenuItem createDocxTool;
        private System.Windows.Forms.ToolStripMenuItem exitTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatingDate;
        private System.Windows.Forms.DataGridViewImageColumn open;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}