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
            this.Lists_listBox = new System.Windows.Forms.ListBox();
            this.addList_button = new System.Windows.Forms.Button();
            this.deleteList_button = new System.Windows.Forms.Button();
            this.searchList_textBox = new System.Windows.Forms.TextBox();
            this.mainWindow1_label = new System.Windows.Forms.Label();
            this.sortingLists_comboBox = new System.Windows.Forms.ComboBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.createDocxFile_button = new System.Windows.Forms.Button();
            this.createTxtFile_button = new System.Windows.Forms.Button();
            this.openList_button = new System.Windows.Forms.Button();
            this.renameList_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lists_listBox
            // 
            this.Lists_listBox.FormattingEnabled = true;
            resources.ApplyResources(this.Lists_listBox, "Lists_listBox");
            this.Lists_listBox.Name = "Lists_listBox";
            // 
            // addList_button
            // 
            resources.ApplyResources(this.addList_button, "addList_button");
            this.addList_button.Name = "addList_button";
            this.addList_button.UseVisualStyleBackColor = true;
            this.addList_button.Click += new System.EventHandler(this.addList_button_Click);
            // 
            // deleteList_button
            // 
            resources.ApplyResources(this.deleteList_button, "deleteList_button");
            this.deleteList_button.Name = "deleteList_button";
            this.deleteList_button.UseVisualStyleBackColor = true;
            this.deleteList_button.Click += new System.EventHandler(this.deleteList_button_Click);
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
            // openList_button
            // 
            resources.ApplyResources(this.openList_button, "openList_button");
            this.openList_button.Name = "openList_button";
            this.openList_button.UseVisualStyleBackColor = true;
            // 
            // renameList_button
            // 
            resources.ApplyResources(this.renameList_button, "renameList_button");
            this.renameList_button.Name = "renameList_button";
            this.renameList_button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.sortingLists_comboBox);
            this.Controls.Add(this.mainWindow1_label);
            this.Controls.Add(this.searchList_textBox);
            this.Controls.Add(this.renameList_button);
            this.Controls.Add(this.openList_button);
            this.Controls.Add(this.createDocxFile_button);
            this.Controls.Add(this.createTxtFile_button);
            this.Controls.Add(this.deleteList_button);
            this.Controls.Add(this.addList_button);
            this.Controls.Add(this.Lists_listBox);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lists_listBox;
        private System.Windows.Forms.Button addList_button;
        private System.Windows.Forms.Button deleteList_button;
        private System.Windows.Forms.TextBox searchList_textBox;
        private System.Windows.Forms.Label mainWindow1_label;
        private System.Windows.Forms.ComboBox sortingLists_comboBox;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button createDocxFile_button;
        private System.Windows.Forms.Button createTxtFile_button;
        private System.Windows.Forms.Button openList_button;
        private System.Windows.Forms.Button renameList_button;
    }
}

