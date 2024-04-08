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
            emailsListBox = new ListBox();
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
            panel1.Controls.Add(emailsListBox);
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 379);
            panel1.TabIndex = 3;
            // 
            // emailsListBox
            // 
            emailsListBox.FormattingEnabled = true;
            emailsListBox.ItemHeight = 15;
            emailsListBox.Location = new Point(3, 11);
            emailsListBox.Name = "emailsListBox";
            emailsListBox.Size = new Size(795, 364);
            emailsListBox.TabIndex = 0;
            // 
            // SimpleEmailHarvesterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
