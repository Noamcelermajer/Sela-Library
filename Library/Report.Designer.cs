namespace Library
{
    partial class Report
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
            AmountLabel = new Label();
            label4 = new Label();
            BooksLabel = new Label();
            BorrowedAmount = new Label();
            label7 = new Label();
            MagazineLabel = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 63);
            label1.Name = "label1";
            label1.Size = new Size(132, 24);
            label1.TabIndex = 0;
            label1.Text = "Daily Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 215);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Items amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(250, 215);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(38, 15);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 300);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Books amount:";
            // 
            // BooksLabel
            // 
            BooksLabel.AutoSize = true;
            BooksLabel.Location = new Point(250, 300);
            BooksLabel.Name = "BooksLabel";
            BooksLabel.Size = new Size(38, 15);
            BooksLabel.TabIndex = 4;
            BooksLabel.Text = "label5";
            // 
            // BorrowedAmount
            // 
            BorrowedAmount.AutoSize = true;
            BorrowedAmount.Location = new Point(250, 462);
            BorrowedAmount.Name = "BorrowedAmount";
            BorrowedAmount.Size = new Size(38, 15);
            BorrowedAmount.TabIndex = 8;
            BorrowedAmount.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 462);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 7;
            label7.Text = "Borrowed amounts:";
            // 
            // MagazineLabel
            // 
            MagazineLabel.AutoSize = true;
            MagazineLabel.Location = new Point(250, 377);
            MagazineLabel.Name = "MagazineLabel";
            MagazineLabel.Size = new Size(38, 15);
            MagazineLabel.TabIndex = 6;
            MagazineLabel.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(103, 377);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 5;
            label9.Text = "Magazines amount:";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 765);
            Controls.Add(BorrowedAmount);
            Controls.Add(label7);
            Controls.Add(MagazineLabel);
            Controls.Add(label9);
            Controls.Add(BooksLabel);
            Controls.Add(label4);
            Controls.Add(AmountLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(708, 804);
            MinimumSize = new Size(708, 804);
            Name = "Report";
            ShowIcon = false;
            Text = "Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label AmountLabel;
        private Label label4;
        private Label BooksLabel;
        private Label BorrowedAmount;
        private Label label7;
        private Label MagazineLabel;
        private Label label9;
    }
}