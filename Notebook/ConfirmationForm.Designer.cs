namespace Notebook
{
    partial class ConfirmationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(99, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "...........................";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yes_button
            // 
            this.yes_button.Location = new System.Drawing.Point(171, 119);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(75, 23);
            this.yes_button.TabIndex = 1;
            this.yes_button.Text = "yes";
            this.yes_button.UseVisualStyleBackColor = true;
            // 
            // no_button
            // 
            this.no_button.Location = new System.Drawing.Point(40, 119);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(75, 23);
            this.no_button.TabIndex = 2;
            this.no_button.Text = "no";
            this.no_button.UseVisualStyleBackColor = true;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 170);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
    }
}