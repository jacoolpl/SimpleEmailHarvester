namespace SimpleEmailHarvester
{
    partial class SimpleEmailHarvesterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                //driver2.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            queryText = new TextBox();
            ScanButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            URLsListBox = new ListBox();
            emailsListBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // queryText
            // 
            queryText.Location = new Point(76, 12);
            queryText.Name = "queryText";
            queryText.Size = new Size(712, 23);
            queryText.TabIndex = 0;
            // 
            // ScanButton
            // 
            ScanButton.Location = new Point(361, 41);
            ScanButton.Name = "ScanButton";
            ScanButton.Size = new Size(75, 23);
            ScanButton.TabIndex = 1;
            ScanButton.Text = "Scan";
            ScanButton.UseVisualStyleBackColor = true;
            ScanButton.Click += scanButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Phraze:";
            // 
            // panel1
            // 
            panel1.Controls.Add(URLsListBox);
            panel1.Controls.Add(emailsListBox);
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 379);
            panel1.TabIndex = 3;
            // 
            // URLsListBox
            // 
            URLsListBox.FormattingEnabled = true;
            URLsListBox.ItemHeight = 15;
            URLsListBox.Location = new Point(3, 11);
            URLsListBox.Name = "URLsListBox";
            URLsListBox.Size = new Size(352, 364);
            URLsListBox.TabIndex = 1;
            // 
            // emailsListBox
            // 
            emailsListBox.FormattingEnabled = true;
            emailsListBox.ItemHeight = 15;
            emailsListBox.Location = new Point(426, 11);
            emailsListBox.Name = "emailsListBox";
            emailsListBox.Size = new Size(372, 364);
            emailsListBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(280, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(426, 455);
            button2.Name = "button2";
            button2.Size = new Size(362, 23);
            button2.TabIndex = 5;
            button2.Text = "Save Emials";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(81, 456);
            button3.Name = "button3";
            button3.Size = new Size(108, 25);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SimpleEmailHarvesterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 489);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(ScanButton);
            Controls.Add(queryText);
            MaximizeBox = false;
            Name = "SimpleEmailHarvesterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimpleEmailHarvester";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox queryText;
        private Button ScanButton;
        private Label label1;
        private Panel panel1;
        private ListBox emailsListBox;
        private Button button1;
        private ListBox URLsListBox;
        private Button button2;
        private Button button3;
    }
}
