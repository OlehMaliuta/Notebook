namespace Notebook
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lists_listBox = new System.Windows.Forms.ListBox();
            this.nameForList_button = new System.Windows.Forms.Button();
            this.searchList_textBox = new System.Windows.Forms.TextBox();
            this.mainWindow1_label = new System.Windows.Forms.Label();
            this.sortingLists_comboBox = new System.Windows.Forms.ComboBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.createDocxFile_button = new System.Windows.Forms.Button();
            this.createTxtFile_button = new System.Windows.Forms.Button();
            this.lists_dataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatingListDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatingListDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rename = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lists_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lists_listBox
            // 
            this.Lists_listBox.FormattingEnabled = true;
            resources.ApplyResources(this.Lists_listBox, "Lists_listBox");
            this.Lists_listBox.Name = "Lists_listBox";
            // 
            // nameForList_button
            // 
            resources.ApplyResources(this.nameForList_button, "nameForList_button");
            this.nameForList_button.Name = "nameForList_button";
            this.nameForList_button.UseVisualStyleBackColor = true;
            this.nameForList_button.Click += new System.EventHandler(this.nameForList_button_Click);
            // 
            // searchList_textBox
            // 
            resources.ApplyResources(this.searchList_textBox, "searchList_textBox");
            this.searchList_textBox.Name = "searchList_textBox";
            // 
            // mainWindow1_label
            // 
            resources.ApplyResources(this.mainWindow1_label, "mainWindow1_label");
            this.mainWindow1_label.Name = "mainWindow1_label";
            // 
            // sortingLists_comboBox
            // 
            this.sortingLists_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortingLists_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingLists_comboBox.FormattingEnabled = true;
            this.sortingLists_comboBox.Items.AddRange(new object[] {
            resources.GetString("sortingLists_comboBox.Items"),
            resources.GetString("sortingLists_comboBox.Items1"),
            resources.GetString("sortingLists_comboBox.Items2")});
            resources.ApplyResources(this.sortingLists_comboBox, "sortingLists_comboBox");
            this.sortingLists_comboBox.Name = "sortingLists_comboBox";
            // 
            // settings_button
            // 
            resources.ApplyResources(this.settings_button, "settings_button");
            this.settings_button.Name = "settings_button";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // exit_button
            // 
            resources.ApplyResources(this.exit_button, "exit_button");
            this.exit_button.Name = "exit_button";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // createDocxFile_button
            // 
            resources.ApplyResources(this.createDocxFile_button, "createDocxFile_button");
            this.createDocxFile_button.Name = "createDocxFile_button";
            this.createDocxFile_button.UseVisualStyleBackColor = true;
            // 
            // createTxtFile_button
            // 
            resources.ApplyResources(this.createTxtFile_button, "createTxtFile_button");
            this.createTxtFile_button.Name = "createTxtFile_button";
            this.createTxtFile_button.UseVisualStyleBackColor = true;
            // 
            // lists_dataGridView
            // 
            this.lists_dataGridView.AllowUserToAddRows = false;
            this.lists_dataGridView.AllowUserToDeleteRows = false;
            this.lists_dataGridView.AllowUserToResizeColumns = false;
            this.lists_dataGridView.AllowUserToResizeRows = false;
            this.lists_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lists_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.creatingListDate,
            this.updatingListDate,
            this.open,
            this.rename,
            this.delete});
            resources.ApplyResources(this.lists_dataGridView, "lists_dataGridView");
            this.lists_dataGridView.Name = "lists_dataGridView";
            this.lists_dataGridView.ReadOnly = true;
            this.lists_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lists_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lists_dataGridView_CellClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // creatingListDate
            // 
            resources.ApplyResources(this.creatingListDate, "creatingListDate");
            this.creatingListDate.Name = "creatingListDate";
            // 
            // updatingListDate
            // 
            resources.ApplyResources(this.updatingListDate, "updatingListDate");
            this.updatingListDate.Name = "updatingListDate";
            // 
            // open
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.open, "open");
            this.open.Name = "open";
            this.open.ReadOnly = true;
            this.open.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.open.Text = "...";
            // 
            // rename
            // 
            resources.ApplyResources(this.rename, "rename");
            this.rename.Name = "rename";
            this.rename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delete
            // 
            resources.ApplyResources(this.delete, "delete");
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lists_dataGridView);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.sortingLists_comboBox);
            this.Controls.Add(this.mainWindow1_label);
            this.Controls.Add(this.searchList_textBox);
            this.Controls.Add(this.createDocxFile_button);
            this.Controls.Add(this.createTxtFile_button);
            this.Controls.Add(this.nameForList_button);
            this.Controls.Add(this.Lists_listBox);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lists_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lists_listBox;
        private System.Windows.Forms.Button nameForList_button;
        private System.Windows.Forms.TextBox searchList_textBox;
        private System.Windows.Forms.Label mainWindow1_label;
        private System.Windows.Forms.ComboBox sortingLists_comboBox;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button createDocxFile_button;
        private System.Windows.Forms.Button createTxtFile_button;
        private System.Windows.Forms.DataGridView lists_dataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatingListDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatingListDate;
        private System.Windows.Forms.DataGridViewButtonColumn open;
        private System.Windows.Forms.DataGridViewButtonColumn rename;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}

