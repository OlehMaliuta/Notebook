namespace Notebook
{
    partial class ElementForm
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
            this.changeElement_button = new System.Windows.Forms.Button();
            this.goBack_button = new System.Windows.Forms.Button();
            this.elementInfo_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.elementInfo_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // changeElement_button
            // 
            this.changeElement_button.Location = new System.Drawing.Point(601, 372);
            this.changeElement_button.Name = "changeElement_button";
            this.changeElement_button.Size = new System.Drawing.Size(75, 23);
            this.changeElement_button.TabIndex = 0;
            this.changeElement_button.Text = "створити";
            this.changeElement_button.UseVisualStyleBackColor = true;
            // 
            // goBack_button
            // 
            this.goBack_button.Location = new System.Drawing.Point(131, 371);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(75, 23);
            this.goBack_button.TabIndex = 1;
            this.goBack_button.Text = "назад";
            this.goBack_button.UseVisualStyleBackColor = true;
            // 
            // elementInfo_dataGridView
            // 
            this.elementInfo_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementInfo_dataGridView.Location = new System.Drawing.Point(27, 12);
            this.elementInfo_dataGridView.Name = "elementInfo_dataGridView";
            this.elementInfo_dataGridView.Size = new System.Drawing.Size(749, 315);
            this.elementInfo_dataGridView.TabIndex = 2;
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementInfo_dataGridView);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.changeElement_button);
            this.Name = "ElementForm";
            this.Text = "ElementForm";
            ((System.ComponentModel.ISupportInitialize)(this.elementInfo_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeElement_button;
        private System.Windows.Forms.Button goBack_button;
        private System.Windows.Forms.DataGridView elementInfo_dataGridView;
    }
}