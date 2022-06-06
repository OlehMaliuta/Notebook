namespace Notebook
{
    partial class CreateFileForm
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
            this.goBack_button = new System.Windows.Forms.Button();
            this.loadFile_button = new System.Windows.Forms.Button();
            this.createFileWindow_label = new System.Windows.Forms.Label();
            this.listFilePath_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goBack_button
            // 
            this.goBack_button.Location = new System.Drawing.Point(156, 247);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(75, 23);
            this.goBack_button.TabIndex = 7;
            this.goBack_button.Text = "назад";
            this.goBack_button.UseVisualStyleBackColor = true;
            // 
            // loadFile_button
            // 
            this.loadFile_button.Location = new System.Drawing.Point(379, 248);
            this.loadFile_button.Name = "loadFile_button";
            this.loadFile_button.Size = new System.Drawing.Size(75, 23);
            this.loadFile_button.TabIndex = 6;
            this.loadFile_button.Text = "створити";
            this.loadFile_button.UseVisualStyleBackColor = true;
            // 
            // createFileWindow_label
            // 
            this.createFileWindow_label.AutoSize = true;
            this.createFileWindow_label.Location = new System.Drawing.Point(81, 42);
            this.createFileWindow_label.Name = "createFileWindow_label";
            this.createFileWindow_label.Size = new System.Drawing.Size(186, 13);
            this.createFileWindow_label.TabIndex = 5;
            this.createFileWindow_label.Text = "Введіть шлях завантаження файлу:";
            // 
            // listFilePath_textBox
            // 
            this.listFilePath_textBox.Location = new System.Drawing.Point(84, 72);
            this.listFilePath_textBox.Name = "listFilePath_textBox";
            this.listFilePath_textBox.Size = new System.Drawing.Size(524, 20);
            this.listFilePath_textBox.TabIndex = 4;
            // 
            // CreateFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 344);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.loadFile_button);
            this.Controls.Add(this.createFileWindow_label);
            this.Controls.Add(this.listFilePath_textBox);
            this.Name = "CreateFileForm";
            this.Text = "CreateFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBack_button;
        private System.Windows.Forms.Button loadFile_button;
        private System.Windows.Forms.Label createFileWindow_label;
        private System.Windows.Forms.TextBox listFilePath_textBox;
    }
}