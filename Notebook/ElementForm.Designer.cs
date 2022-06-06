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
            this.infoFieldType_comboBox = new System.Windows.Forms.ComboBox();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.fieldName_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeElement_button
            // 
            this.changeElement_button.Location = new System.Drawing.Point(551, 367);
            this.changeElement_button.Name = "changeElement_button";
            this.changeElement_button.Size = new System.Drawing.Size(75, 23);
            this.changeElement_button.TabIndex = 0;
            this.changeElement_button.Text = "створити";
            this.changeElement_button.UseVisualStyleBackColor = true;
            this.changeElement_button.Click += new System.EventHandler(this.changeElement_button_Click);
            // 
            // goBack_button
            // 
            this.goBack_button.Location = new System.Drawing.Point(420, 367);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(75, 23);
            this.goBack_button.TabIndex = 1;
            this.goBack_button.Text = "назад";
            this.goBack_button.UseVisualStyleBackColor = true;
            this.goBack_button.Click += new System.EventHandler(this.goBack_button_Click);
            // 
            // infoFieldType_comboBox
            // 
            this.infoFieldType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.infoFieldType_comboBox.FormattingEnabled = true;
            this.infoFieldType_comboBox.Items.AddRange(new object[] {
            "ім\'я",
            "телефон",
            "дата народження",
            "анкетні дані",
            "місце проживання",
            "місце роботи/навчання",
            "характер знайомства",
            "посада знайомих",
            "ділові якості",
            "додаткова інформація"});
            this.infoFieldType_comboBox.Location = new System.Drawing.Point(462, 176);
            this.infoFieldType_comboBox.Name = "infoFieldType_comboBox";
            this.infoFieldType_comboBox.Size = new System.Drawing.Size(121, 21);
            this.infoFieldType_comboBox.TabIndex = 2;
            this.infoFieldType_comboBox.SelectedIndexChanged += new System.EventHandler(this.infoFieldType_comboBox_SelectedIndexChanged);
            // 
            // info_textBox
            // 
            this.info_textBox.Location = new System.Drawing.Point(33, 82);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.Size = new System.Drawing.Size(324, 337);
            this.info_textBox.TabIndex = 3;
            this.info_textBox.TextChanged += new System.EventHandler(this.info_textBox_TextChanged);
            // 
            // fieldName_label
            // 
            this.fieldName_label.AutoSize = true;
            this.fieldName_label.Location = new System.Drawing.Point(174, 35);
            this.fieldName_label.Name = "fieldName_label";
            this.fieldName_label.Size = new System.Drawing.Size(35, 13);
            this.fieldName_label.TabIndex = 4;
            this.fieldName_label.Text = "label1";
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.fieldName_label);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.infoFieldType_comboBox);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.changeElement_button);
            this.Name = "ElementForm";
            this.Text = "ElementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElementForm_FormClosing);
            this.Load += new System.EventHandler(this.ElementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeElement_button;
        private System.Windows.Forms.Button goBack_button;
        private System.Windows.Forms.ComboBox infoFieldType_comboBox;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.Label fieldName_label;
    }
}