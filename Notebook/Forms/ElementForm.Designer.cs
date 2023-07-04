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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementForm));
            this.editElementButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.infoFieldTypeComboBox = new System.Windows.Forms.ComboBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.fieldNameLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.fieldTypeLabel = new System.Windows.Forms.Label();
            this.datePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeElementButton
            // 
            this.editElementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editElementButton.Location = new System.Drawing.Point(591, 385);
            this.editElementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editElementButton.Name = "changeElementButton";
            this.editElementButton.Size = new System.Drawing.Size(99, 34);
            this.editElementButton.TabIndex = 0;
            this.editElementButton.Text = "створити";
            this.editElementButton.UseVisualStyleBackColor = true;
            this.editElementButton.Click += new System.EventHandler(this.ChangeElementButtonClick);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(450, 385);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(97, 34);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // infoFieldTypeComboBox
            // 
            this.infoFieldTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.infoFieldTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoFieldTypeComboBox.FormattingEnabled = true;
            this.infoFieldTypeComboBox.Location = new System.Drawing.Point(521, 258);
            this.infoFieldTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.infoFieldTypeComboBox.Name = "infoFieldTypeComboBox";
            this.infoFieldTypeComboBox.Size = new System.Drawing.Size(163, 24);
            this.infoFieldTypeComboBox.TabIndex = 2;
            this.infoFieldTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.InfoFieldTypeComboBoxSelectedIndexChanged);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextBox.Location = new System.Drawing.Point(38, 82);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(377, 337);
            this.infoTextBox.TabIndex = 3;
            this.infoTextBox.TextChanged += new System.EventHandler(this.InfoTextBoxTextChanged);
            // 
            // fieldNameLabel
            // 
            this.fieldNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldNameLabel.Location = new System.Drawing.Point(38, 36);
            this.fieldNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fieldNameLabel.Name = "fieldNameLabel";
            this.fieldNameLabel.Size = new System.Drawing.Size(377, 20);
            this.fieldNameLabel.TabIndex = 4;
            this.fieldNameLabel.Text = "label1";
            this.fieldNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayLabel
            // 
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.Location = new System.Drawing.Point(28, 20);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(38, 18);
            this.dayLabel.TabIndex = 5;
            this.dayLabel.Text = "day:";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dayNumericUpDown
            // 
            this.dayNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayNumericUpDown.Location = new System.Drawing.Point(89, 18);
            this.dayNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dayNumericUpDown.Name = "dayNumericUpDown";
            this.dayNumericUpDown.Size = new System.Drawing.Size(94, 22);
            this.dayNumericUpDown.TabIndex = 6;
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthNumericUpDown.Location = new System.Drawing.Point(89, 57);
            this.monthNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(94, 22);
            this.monthNumericUpDown.TabIndex = 8;
            // 
            // monthLabel
            // 
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthLabel.Location = new System.Drawing.Point(14, 59);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(52, 18);
            this.monthLabel.TabIndex = 7;
            this.monthLabel.Text = "month:";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearNumericUpDown.Location = new System.Drawing.Point(89, 97);
            this.yearNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(94, 22);
            this.yearNumericUpDown.TabIndex = 10;
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(24, 97);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 18);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "year:";
            // 
            // fieldTypeLabel
            // 
            this.fieldTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldTypeLabel.Location = new System.Drawing.Point(442, 261);
            this.fieldTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fieldTypeLabel.Name = "fieldTypeLabel";
            this.fieldTypeLabel.Size = new System.Drawing.Size(59, 21);
            this.fieldTypeLabel.TabIndex = 11;
            this.fieldTypeLabel.Text = " Поле:";
            this.fieldTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.dayLabel);
            this.datePanel.Controls.Add(this.dayNumericUpDown);
            this.datePanel.Controls.Add(this.yearNumericUpDown);
            this.datePanel.Controls.Add(this.monthLabel);
            this.datePanel.Controls.Add(this.yearLabel);
            this.datePanel.Controls.Add(this.monthNumericUpDown);
            this.datePanel.Location = new System.Drawing.Point(119, 143);
            this.datePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(204, 139);
            this.datePanel.TabIndex = 12;
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.fieldTypeLabel);
            this.Controls.Add(this.fieldNameLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.infoFieldTypeComboBox);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.editElementButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ElementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElementFormFormClosing);
            this.Load += new System.EventHandler(this.ElementFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.datePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.ComboBox infoFieldTypeComboBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label fieldNameLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.NumericUpDown dayNumericUpDown;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label fieldTypeLabel;
        private System.Windows.Forms.Panel datePanel;
    }
}