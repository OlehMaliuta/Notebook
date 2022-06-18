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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lists_listBox = new System.Windows.Forms.ListBox();
            this.nameForListButton = new System.Windows.Forms.Button();
            this.searchListTextBox = new System.Windows.Forms.TextBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.sortingListsComboBox = new System.Windows.Forms.ComboBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.listDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatingListDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatingListDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rename = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lists_listBox
            // 
            this.Lists_listBox.FormattingEnabled = true;
            resources.ApplyResources(this.Lists_listBox, "Lists_listBox");
            this.Lists_listBox.Name = "Lists_listBox";
            // 
            // nameForListButton
            // 
            resources.ApplyResources(this.nameForListButton, "nameForListButton");
            this.nameForListButton.Name = "nameForListButton";
            this.nameForListButton.UseVisualStyleBackColor = true;
            this.nameForListButton.Click += new System.EventHandler(this.nameForListButton_Click);
            // 
            // searchListTextBox
            // 
            resources.ApplyResources(this.searchListTextBox, "searchListTextBox");
            this.searchListTextBox.Name = "searchListTextBox";
            this.searchListTextBox.TextChanged += new System.EventHandler(this.searchListTextBox_TextChanged);
            // 
            // sortLabel
            // 
            resources.ApplyResources(this.sortLabel, "sortLabel");
            this.sortLabel.Name = "sortLabel";
            // 
            // sortingListsComboBox
            // 
            this.sortingListsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortingListsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingListsComboBox.FormattingEnabled = true;
            this.sortingListsComboBox.Items.AddRange(new object[] {
            resources.GetString("sortingListsComboBox.Items"),
            resources.GetString("sortingListsComboBox.Items1"),
            resources.GetString("sortingListsComboBox.Items2")});
            resources.ApplyResources(this.sortingListsComboBox, "sortingListsComboBox");
            this.sortingListsComboBox.Name = "sortingListsComboBox";
            this.sortingListsComboBox.SelectedIndexChanged += new System.EventHandler(this.sortingListsComboBox_SelectedIndexChanged);
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listDataGridView
            // 
            this.listDataGridView.AllowUserToAddRows = false;
            this.listDataGridView.AllowUserToDeleteRows = false;
            this.listDataGridView.AllowUserToResizeColumns = false;
            this.listDataGridView.AllowUserToResizeRows = false;
            this.listDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.listDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.creatingListDate,
            this.updatingListDate,
            this.open,
            this.rename,
            this.delete});
            this.listDataGridView.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.listDataGridView, "listDataGridView");
            this.listDataGridView.Name = "listDataGridView";
            this.listDataGridView.ReadOnly = true;
            this.listDataGridView.RowHeadersVisible = false;
            this.listDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataGridView_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // creatingListDate
            // 
            resources.ApplyResources(this.creatingListDate, "creatingListDate");
            this.creatingListDate.Name = "creatingListDate";
            this.creatingListDate.ReadOnly = true;
            this.creatingListDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // updatingListDate
            // 
            resources.ApplyResources(this.updatingListDate, "updatingListDate");
            this.updatingListDate.Name = "updatingListDate";
            this.updatingListDate.ReadOnly = true;
            this.updatingListDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // open
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.rename.ReadOnly = true;
            this.rename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // delete
            // 
            resources.ApplyResources(this.delete, "delete");
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.sortingListsComboBox);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.searchListTextBox);
            this.Controls.Add(this.nameForListButton);
            this.Controls.Add(this.Lists_listBox);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lists_listBox;
        private System.Windows.Forms.Button nameForListButton;
        private System.Windows.Forms.TextBox searchListTextBox;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ComboBox sortingListsComboBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView listDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatingListDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatingListDate;
        private System.Windows.Forms.DataGridViewButtonColumn open;
        private System.Windows.Forms.DataGridViewButtonColumn rename;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}

