namespace MemoMates
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
            this.addElementButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchElementTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.elementDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.createDocxFileButton = new System.Windows.Forms.Button();
            this.createTxtFileButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuSection = new System.Windows.Forms.ToolStripMenuItem();
            this.addElementTool = new System.Windows.Forms.ToolStripMenuItem();
            this.createTxtTool = new System.Windows.Forms.ToolStripMenuItem();
            this.createDocxTool = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addElementButton
            // 
            this.addElementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addElementButton.Location = new System.Drawing.Point(958, 69);
            this.addElementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(128, 104);
            this.addElementButton.TabIndex = 2;
            this.addElementButton.Text = "додати елемент";
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.AddElementButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(1126, 594);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 57);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.Location = new System.Drawing.Point(788, 593);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(138, 59);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.Text = "меню налаштування";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(813, 372);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(136, 21);
            this.searchLabel.TabIndex = 13;
            this.searchLabel.Text = "Search:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchElementTextBox
            // 
            this.searchElementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchElementTextBox.Location = new System.Drawing.Point(816, 396);
            this.searchElementTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchElementTextBox.Name = "searchElementTextBox";
            this.searchElementTextBox.Size = new System.Drawing.Size(431, 22);
            this.searchElementTextBox.TabIndex = 12;
            this.searchElementTextBox.TextChanged += new System.EventHandler(this.SearchElementTextBoxTextChanged);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuButton.Location = new System.Drawing.Point(958, 593);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(141, 57);
            this.mainMenuButton.TabIndex = 19;
            this.mainMenuButton.Text = "головне меню";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButtonClick);
            // 
            // elementDataGridView
            // 
            this.elementDataGridView.AllowUserToAddRows = false;
            this.elementDataGridView.AllowUserToDeleteRows = false;
            this.elementDataGridView.AllowUserToResizeColumns = false;
            this.elementDataGridView.AllowUserToResizeRows = false;
            this.elementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.elementDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.elementDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.birthday,
            this.creatingDate,
            this.updatingDate,
            this.open,
            this.delete});
            this.elementDataGridView.EnableHeadersVisualStyles = false;
            this.elementDataGridView.Location = new System.Drawing.Point(14, 69);
            this.elementDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.elementDataGridView.Name = "elementDataGridView";
            this.elementDataGridView.ReadOnly = true;
            this.elementDataGridView.RowHeadersVisible = false;
            this.elementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.elementDataGridView.Size = new System.Drawing.Size(766, 584);
            this.elementDataGridView.TabIndex = 21;
            this.elementDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElementDataGridViewCellClick);
            this.elementDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ElementDataGridViewColumnHeaderMouseClick);
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
            this.open.Image = global::MemoMates.Properties.Resources.note;
            this.open.Name = "open";
            this.open.ReadOnly = true;
            this.open.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.open.Width = 93;
            // 
            // delete
            // 
            this.delete.HeaderText = "*Видалити*";
            this.delete.Image = global::MemoMates.Properties.Resources.remove;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 79;
            // 
            // createDocxFileButton
            // 
            this.createDocxFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createDocxFileButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createDocxFileButton.Location = new System.Drawing.Point(1083, 208);
            this.createDocxFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createDocxFileButton.Name = "createDocxFileButton";
            this.createDocxFileButton.Size = new System.Drawing.Size(136, 93);
            this.createDocxFileButton.TabIndex = 23;
            this.createDocxFileButton.Text = "зберегти у список форматі .docx";
            this.createDocxFileButton.UseVisualStyleBackColor = true;
            this.createDocxFileButton.Click += new System.EventHandler(this.CreateDocxFileButtonClick);
            // 
            // createTxtFileButton
            // 
            this.createTxtFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTxtFileButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createTxtFileButton.Location = new System.Drawing.Point(824, 208);
            this.createTxtFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createTxtFileButton.Name = "createTxtFileButton";
            this.createTxtFileButton.Size = new System.Drawing.Size(136, 93);
            this.createTxtFileButton.TabIndex = 22;
            this.createTxtFileButton.Text = "зберегти список у файлі .txt";
            this.createTxtFileButton.UseVisualStyleBackColor = true;
            this.createTxtFileButton.Click += new System.EventHandler(this.CreateTxtFileButtonClick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuSection});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1260, 25);
            this.menuStrip.TabIndex = 24;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuSection
            // 
            this.fileMenuSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addElementTool,
            this.createTxtTool,
            this.createDocxTool,
            this.settingsTool,
            this.exitTool});
            this.fileMenuSection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenuSection.Name = "fileMenuSection";
            this.fileMenuSection.Size = new System.Drawing.Size(54, 21);
            this.fileMenuSection.Text = "Файл";
            // 
            // addElementTool
            // 
            this.addElementTool.Image = global::MemoMates.Properties.Resources.plus;
            this.addElementTool.Name = "addElementTool";
            this.addElementTool.Size = new System.Drawing.Size(268, 22);
            this.addElementTool.Text = "Додати елемент";
            this.addElementTool.Click += new System.EventHandler(this.AddElementToolClick);
            // 
            // createTxtTool
            // 
            this.createTxtTool.Image = global::MemoMates.Properties.Resources.TXT;
            this.createTxtTool.Name = "createTxtTool";
            this.createTxtTool.Size = new System.Drawing.Size(268, 22);
            this.createTxtTool.Text = "Зберегти список у файлі .txt";
            this.createTxtTool.Click += new System.EventHandler(this.CreateTxtToolClick);
            // 
            // createDocxTool
            // 
            this.createDocxTool.Image = global::MemoMates.Properties.Resources.DOCX;
            this.createDocxTool.Name = "createDocxTool";
            this.createDocxTool.Size = new System.Drawing.Size(268, 22);
            this.createDocxTool.Text = "Зберегти список у файлі .docx";
            this.createDocxTool.Click += new System.EventHandler(this.CreateDocxToolClick);
            // 
            // settingsTool
            // 
            this.settingsTool.Image = global::MemoMates.Properties.Resources.settings;
            this.settingsTool.Name = "settingsTool";
            this.settingsTool.Size = new System.Drawing.Size(268, 22);
            this.settingsTool.Text = "Налаштування";
            this.settingsTool.Click += new System.EventHandler(this.SettingsToolClick);
            // 
            // exitTool
            // 
            this.exitTool.Image = global::MemoMates.Properties.Resources.exit;
            this.exitTool.Name = "exitTool";
            this.exitTool.Size = new System.Drawing.Size(268, 22);
            this.exitTool.Text = "Вихід";
            this.exitTool.Click += new System.EventHandler(this.ExitToolClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "*Детальніше*";
            this.dataGridViewImageColumn1.Image = global::MemoMates.Properties.Resources.note;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 81;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "*Видалити*";
            this.dataGridViewImageColumn2.Image = global::MemoMates.Properties.Resources.remove;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 69;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 663);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.createDocxFileButton);
            this.Controls.Add(this.createTxtFileButton);
            this.Controls.Add(this.elementDataGridView);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchElementTextBox);
            this.Controls.Add(this.addElementButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListFormFormClosing);
            this.Load += new System.EventHandler(this.ListFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchElementTextBox;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.DataGridView elementDataGridView;
        private System.Windows.Forms.Button createDocxFileButton;
        private System.Windows.Forms.Button createTxtFileButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSection;
        private System.Windows.Forms.ToolStripMenuItem addElementTool;
        private System.Windows.Forms.ToolStripMenuItem createTxtTool;
        private System.Windows.Forms.ToolStripMenuItem createDocxTool;
        private System.Windows.Forms.ToolStripMenuItem settingsTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatingDate;
        private System.Windows.Forms.DataGridViewImageColumn open;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolStripMenuItem exitTool;
    }
}