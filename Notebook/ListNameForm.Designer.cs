namespace Notebook
{
    partial class ListNameForm
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
            this.listName_textBox = new System.Windows.Forms.TextBox();
            this.listNameWindow_label = new System.Windows.Forms.Label();
            this.giveListName_button = new System.Windows.Forms.Button();
            this.goBack_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listName_textBox
            // 
            this.listName_textBox.Location = new System.Drawing.Point(79, 108);
            this.listName_textBox.Name = "listName_textBox";
            this.listName_textBox.Size = new System.Drawing.Size(524, 20);
            this.listName_textBox.TabIndex = 0;
            // 
            // listNameWindow_label
            // 
            this.listNameWindow_label.AutoSize = true;
            this.listNameWindow_label.Location = new System.Drawing.Point(76, 78);
            this.listNameWindow_label.Name = "listNameWindow_label";
            this.listNameWindow_label.Size = new System.Drawing.Size(118, 13);
            this.listNameWindow_label.TabIndex = 1;
            this.listNameWindow_label.Text = "Введіть назву списку:";
            // 
            // giveListName_button
            // 
            this.giveListName_button.Location = new System.Drawing.Point(400, 227);
            this.giveListName_button.Name = "giveListName_button";
            this.giveListName_button.Size = new System.Drawing.Size(75, 23);
            this.giveListName_button.TabIndex = 2;
            this.giveListName_button.Text = "створити";
            this.giveListName_button.UseVisualStyleBackColor = true;
            this.giveListName_button.Click += new System.EventHandler(this.giveListName_button_Click);
            // 
            // goBack_button
            // 
            this.goBack_button.Location = new System.Drawing.Point(177, 226);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(75, 23);
            this.goBack_button.TabIndex = 3;
            this.goBack_button.Text = "назад";
            this.goBack_button.UseVisualStyleBackColor = true;
            this.goBack_button.Click += new System.EventHandler(this.goBack_button_Click);
            // 
            // ListNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 329);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.giveListName_button);
            this.Controls.Add(this.listNameWindow_label);
            this.Controls.Add(this.listName_textBox);
            this.Name = "ListNameForm";
            this.Text = "ListNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listName_textBox;
        private System.Windows.Forms.Label listNameWindow_label;
        private System.Windows.Forms.Button giveListName_button;
        private System.Windows.Forms.Button goBack_button;
    }
}