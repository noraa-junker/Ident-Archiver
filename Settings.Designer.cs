namespace Ident_Archiver
{
    partial class Settings
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ytdlpLocationTextBox = new TextBox();
            RepoTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "yt-dlp executable:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Repository location:";
            // 
            // button1
            // 
            button1.Location = new Point(623, 80);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(85, 43);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // ytdlpLocationTextBox
            // 
            ytdlpLocationTextBox.Location = new Point(187, 9);
            ytdlpLocationTextBox.Margin = new Padding(4);
            ytdlpLocationTextBox.Name = "ytdlpLocationTextBox";
            ytdlpLocationTextBox.Size = new Size(521, 27);
            ytdlpLocationTextBox.TabIndex = 3;
            // 
            // RepoTextBox
            // 
            RepoTextBox.Location = new Point(187, 44);
            RepoTextBox.Margin = new Padding(4);
            RepoTextBox.Name = "RepoTextBox";
            RepoTextBox.Size = new Size(521, 27);
            RepoTextBox.TabIndex = 4;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 127);
            Controls.Add(RepoTextBox);
            Controls.Add(ytdlpLocationTextBox);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            Text = "Settings";
            FormClosed += Settings_FormClosed;
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox ytdlpLocationTextBox;
        private TextBox RepoTextBox;
    }
}