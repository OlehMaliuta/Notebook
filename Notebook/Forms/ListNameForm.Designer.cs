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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListNameForm));
            this.listNameTextBox = new System.Windows.Forms.TextBox();
            this.listNameWindowLabel = new System.Windows.Forms.Label();
            this.giveListNameButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNameTextBox
            // 
            this.listNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listNameTextBox.Location = new System.Drawing.Point(33, 68);
            this.listNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listNameTextBox.Name = "listNameTextBox";
            this.listNameTextBox.Size = new System.Drawing.Size(444, 22);
            this.listNameTextBox.TabIndex = 0;
            // 
            // listNameWindowLabel
            // 
            this.listNameWindowLabel.AutoSize = true;
            this.listNameWindowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listNameWindowLabel.Location = new System.Drawing.Point(30, 38);
            this.listNameWindowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listNameWindowLabel.Name = "listNameWindowLabel";
            this.listNameWindowLabel.Size = new System.Drawing.Size(172, 16);
            this.listNameWindowLabel.TabIndex = 1;
            this.listNameWindowLabel.Text = "Введіть назву списку:";
            // 
            // giveListNameButton
            // 
            this.giveListNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.giveListNameButton.Location = new System.Drawing.Point(336, 136);
            this.giveListNameButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.giveListNameButton.Name = "giveListNameButton";
            this.giveListNameButton.Size = new System.Drawing.Size(141, 44);
            this.giveListNameButton.TabIndex = 2;
            this.giveListNameButton.Text = "створити";
            this.giveListNameButton.UseVisualStyleBackColor = true;
            this.giveListNameButton.Click += new System.EventHandler(this.GiveListNameButtonClick);
            // 
            // goBackButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(33, 136);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "goBackButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 44);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // ListNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 214);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.giveListNameButton);
            this.Controls.Add(this.listNameWindowLabel);
            this.Controls.Add(this.listNameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListNameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListNameFormFormClosing);
            this.Load += new System.EventHandler(this.ListNameFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listNameTextBox;
        private System.Windows.Forms.Label listNameWindowLabel;
        private System.Windows.Forms.Button giveListNameButton;
        private System.Windows.Forms.Button cancelButton;
    }
}