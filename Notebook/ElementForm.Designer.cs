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
            this.day_label = new System.Windows.Forms.Label();
            this.day_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.month_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.month_label = new System.Windows.Forms.Label();
            this.year_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.year_label = new System.Windows.Forms.Label();
            this.fieldType_label = new System.Windows.Forms.Label();
            this.date_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.day_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_numericUpDown)).BeginInit();
            this.date_panel.SuspendLayout();
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
            "дата народження",
            "телефон",
            "анкетні дані",
            "місце проживання",
            "місце роботи/навчання",
            "характер знайомства",
            "посада знайомих",
            "ділові якості",
            "додаткова інформація"});
            this.infoFieldType_comboBox.Location = new System.Drawing.Point(501, 232);
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
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Location = new System.Drawing.Point(12, 20);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(24, 13);
            this.day_label.TabIndex = 5;
            this.day_label.Text = "day";
            // 
            // day_numericUpDown
            // 
            this.day_numericUpDown.Location = new System.Drawing.Point(76, 18);
            this.day_numericUpDown.Name = "day_numericUpDown";
            this.day_numericUpDown.Size = new System.Drawing.Size(81, 20);
            this.day_numericUpDown.TabIndex = 6;
            // 
            // month_numericUpDown
            // 
            this.month_numericUpDown.Location = new System.Drawing.Point(76, 57);
            this.month_numericUpDown.Name = "month_numericUpDown";
            this.month_numericUpDown.Size = new System.Drawing.Size(81, 20);
            this.month_numericUpDown.TabIndex = 8;
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.Location = new System.Drawing.Point(12, 59);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(36, 13);
            this.month_label.TabIndex = 7;
            this.month_label.Text = "month";
            // 
            // year_numericUpDown
            // 
            this.year_numericUpDown.Location = new System.Drawing.Point(76, 97);
            this.year_numericUpDown.Name = "year_numericUpDown";
            this.year_numericUpDown.Size = new System.Drawing.Size(81, 20);
            this.year_numericUpDown.TabIndex = 10;
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(12, 99);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(27, 13);
            this.year_label.TabIndex = 9;
            this.year_label.Text = "year";
            // 
            // fieldType_label
            // 
            this.fieldType_label.AutoSize = true;
            this.fieldType_label.Location = new System.Drawing.Point(417, 235);
            this.fieldType_label.Name = "fieldType_label";
            this.fieldType_label.Size = new System.Drawing.Size(35, 13);
            this.fieldType_label.TabIndex = 11;
            this.fieldType_label.Text = "label1";
            // 
            // date_panel
            // 
            this.date_panel.Controls.Add(this.day_label);
            this.date_panel.Controls.Add(this.day_numericUpDown);
            this.date_panel.Controls.Add(this.year_numericUpDown);
            this.date_panel.Controls.Add(this.month_label);
            this.date_panel.Controls.Add(this.year_label);
            this.date_panel.Controls.Add(this.month_numericUpDown);
            this.date_panel.Location = new System.Drawing.Point(106, 150);
            this.date_panel.Name = "date_panel";
            this.date_panel.Size = new System.Drawing.Size(175, 139);
            this.date_panel.TabIndex = 12;
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.date_panel);
            this.Controls.Add(this.fieldType_label);
            this.Controls.Add(this.fieldName_label);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.infoFieldType_comboBox);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.changeElement_button);
            this.Name = "ElementForm";
            this.Text = "ElementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElementForm_FormClosing);
            this.Load += new System.EventHandler(this.ElementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.day_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_numericUpDown)).EndInit();
            this.date_panel.ResumeLayout(false);
            this.date_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeElement_button;
        private System.Windows.Forms.Button goBack_button;
        private System.Windows.Forms.ComboBox infoFieldType_comboBox;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.Label fieldName_label;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.NumericUpDown day_numericUpDown;
        private System.Windows.Forms.NumericUpDown month_numericUpDown;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.NumericUpDown year_numericUpDown;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label fieldType_label;
        private System.Windows.Forms.Panel date_panel;
    }
}