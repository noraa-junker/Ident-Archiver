namespace Ident_Archiver
{
    partial class EditEntryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            EntryComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ShortNameTextBox = new TextBox();
            label3 = new Label();
            LongNameTextBox = new TextBox();
            label4 = new Label();
            WatermarkTextBox = new TextBox();
            label5 = new Label();
            DateTextBox = new TextBox();
            label6 = new Label();
            LangTextBox = new TextBox();
            label7 = new Label();
            OrganizationTextBox = new TextBox();
            label8 = new Label();
            STextBox = new TextBox();
            label9 = new Label();
            STTextBox = new TextBox();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // EntryComboBox
            // 
            EntryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EntryComboBox.FormattingEnabled = true;
            EntryComboBox.Location = new Point(145, 16);
            EntryComboBox.Name = "EntryComboBox";
            EntryComboBox.Size = new Size(507, 28);
            EntryComboBox.TabIndex = 0;
            EntryComboBox.SelectedIndexChanged += EntryComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Entry *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Short Name *";
            // 
            // ShortNameTextBox
            // 
            ShortNameTextBox.Location = new Point(145, 56);
            ShortNameTextBox.Name = "ShortNameTextBox";
            ShortNameTextBox.Size = new Size(507, 27);
            ShortNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 100);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Long Name *";
            // 
            // LongNameTextBox
            // 
            LongNameTextBox.Location = new Point(145, 96);
            LongNameTextBox.Name = "LongNameTextBox";
            LongNameTextBox.Size = new Size(507, 27);
            LongNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 140);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Watermark *";
            // 
            // WatermarkTextBox
            // 
            WatermarkTextBox.Location = new Point(145, 136);
            WatermarkTextBox.Name = "WatermarkTextBox";
            WatermarkTextBox.Size = new Size(507, 27);
            WatermarkTextBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 180);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 8;
            label5.Text = "Date *";
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(145, 176);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(507, 27);
            DateTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 220);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 10;
            label6.Text = "Language *";
            // 
            // LangTextBox
            // 
            LangTextBox.Location = new Point(145, 216);
            LangTextBox.Name = "LangTextBox";
            LangTextBox.Size = new Size(507, 27);
            LangTextBox.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 260);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 12;
            label7.Text = "Organization *";
            // 
            // OrganizationTextBox
            // 
            OrganizationTextBox.Location = new Point(145, 256);
            OrganizationTextBox.Name = "OrganizationTextBox";
            OrganizationTextBox.Size = new Size(507, 27);
            OrganizationTextBox.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 300);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 14;
            label8.Text = "Source URL";
            // 
            // STextBox
            // 
            STextBox.Location = new Point(145, 296);
            STextBox.Name = "STextBox";
            STextBox.Size = new Size(507, 27);
            STextBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 340);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 16;
            label9.Text = "Source Text";
            // 
            // STTextBox
            // 
            STTextBox.Location = new Point(145, 336);
            STTextBox.Name = "STTextBox";
            STTextBox.Size = new Size(507, 27);
            STTextBox.TabIndex = 8;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(16, 380);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(90, 40);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 436);
            Controls.Add(SaveButton);
            Controls.Add(STTextBox);
            Controls.Add(label9);
            Controls.Add(STextBox);
            Controls.Add(label8);
            Controls.Add(OrganizationTextBox);
            Controls.Add(label7);
            Controls.Add(LangTextBox);
            Controls.Add(label6);
            Controls.Add(DateTextBox);
            Controls.Add(label5);
            Controls.Add(WatermarkTextBox);
            Controls.Add(label4);
            Controls.Add(LongNameTextBox);
            Controls.Add(label3);
            Controls.Add(ShortNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EntryComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditEntryForm";
            Text = "Edit Entry Metadata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox EntryComboBox;
        private Label label1;
        private Label label2;
        private TextBox ShortNameTextBox;
        private Label label3;
        private TextBox LongNameTextBox;
        private Label label4;
        private TextBox WatermarkTextBox;
        private Label label5;
        private TextBox DateTextBox;
        private Label label6;
        private TextBox LangTextBox;
        private Label label7;
        private TextBox OrganizationTextBox;
        private Label label8;
        private TextBox STextBox;
        private Label label9;
        private TextBox STTextBox;
        private Button SaveButton;
    }
}
