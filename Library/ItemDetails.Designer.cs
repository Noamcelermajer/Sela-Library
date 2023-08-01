namespace Library
{
    partial class ItemDetails
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
            BorrowedLabel = new Label();
            AuthorLabel = new Label();
            GenereLabel = new Label();
            PriceLabel = new Label();
            DateLabel = new Label();
            PublisherLabel = new Label();
            nameLabel = new Label();
            label1 = new Label();
            borrowedValue = new Label();
            authorValue = new Label();
            genereValue = new Label();
            priceValue = new Label();
            publisherValue = new Label();
            nameValue = new Label();
            typeValue = new Label();
            label10 = new Label();
            dateTimeValue = new DateTimePicker();
            DiscountedPriceValue = new Label();
            DiscountedPriceLabel = new Label();
            ISBNLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BorrowedLabel
            // 
            BorrowedLabel.AutoSize = true;
            BorrowedLabel.Location = new Point(51, 565);
            BorrowedLabel.Name = "BorrowedLabel";
            BorrowedLabel.Size = new Size(97, 20);
            BorrowedLabel.TabIndex = 16;
            BorrowedLabel.Text = "Borrowed By:";
            BorrowedLabel.Visible = false;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(51, 443);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(57, 20);
            AuthorLabel.TabIndex = 15;
            AuthorLabel.Text = "Author:";
            AuthorLabel.Visible = false;
            // 
            // GenereLabel
            // 
            GenereLabel.AutoSize = true;
            GenereLabel.Location = new Point(51, 391);
            GenereLabel.Name = "GenereLabel";
            GenereLabel.Size = new Size(51, 20);
            GenereLabel.TabIndex = 14;
            GenereLabel.Text = "Genre:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(51, 341);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(71, 20);
            PriceLabel.TabIndex = 13;
            PriceLabel.Text = "Full Price:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(51, 284);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(116, 20);
            DateLabel.TabIndex = 12;
            DateLabel.Text = "Publishing Date:";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Location = new Point(51, 232);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(72, 20);
            PublisherLabel.TabIndex = 11;
            PublisherLabel.Text = "Publisher:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(51, 181);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 39);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 17;
            label1.Text = "Item Details";
            // 
            // borrowedValue
            // 
            borrowedValue.AutoSize = true;
            borrowedValue.Location = new Point(161, 565);
            borrowedValue.Name = "borrowedValue";
            borrowedValue.Size = new Size(90, 20);
            borrowedValue.TabIndex = 24;
            borrowedValue.Text = "BorrowedBy";
            borrowedValue.Visible = false;
            // 
            // authorValue
            // 
            authorValue.AutoSize = true;
            authorValue.Location = new Point(161, 443);
            authorValue.Name = "authorValue";
            authorValue.Size = new Size(54, 20);
            authorValue.TabIndex = 23;
            authorValue.Text = "Author";
            authorValue.Visible = false;
            // 
            // genereValue
            // 
            genereValue.AutoSize = true;
            genereValue.Location = new Point(161, 391);
            genereValue.Name = "genereValue";
            genereValue.Size = new Size(48, 20);
            genereValue.TabIndex = 22;
            genereValue.Text = "Genre";
            // 
            // priceValue
            // 
            priceValue.AutoSize = true;
            priceValue.Location = new Point(161, 341);
            priceValue.Name = "priceValue";
            priceValue.Size = new Size(41, 20);
            priceValue.TabIndex = 21;
            priceValue.Text = "Price";
            // 
            // publisherValue
            // 
            publisherValue.AutoSize = true;
            publisherValue.Location = new Point(161, 232);
            publisherValue.Name = "publisherValue";
            publisherValue.Size = new Size(69, 20);
            publisherValue.TabIndex = 19;
            publisherValue.Text = "Publisher";
            // 
            // nameValue
            // 
            nameValue.AutoSize = true;
            nameValue.Location = new Point(161, 181);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(49, 20);
            nameValue.TabIndex = 18;
            nameValue.Text = "Name";
            // 
            // typeValue
            // 
            typeValue.AutoSize = true;
            typeValue.Location = new Point(161, 105);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(38, 20);
            typeValue.TabIndex = 26;
            typeValue.Text = "type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 105);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 25;
            label10.Text = "Type:";
            // 
            // dateTimeValue
            // 
            dateTimeValue.Enabled = false;
            dateTimeValue.Format = DateTimePickerFormat.Custom;
            dateTimeValue.Location = new Point(173, 279);
            dateTimeValue.Margin = new Padding(3, 4, 3, 4);
            dateTimeValue.Name = "dateTimeValue";
            dateTimeValue.Size = new Size(129, 27);
            dateTimeValue.TabIndex = 27;
            // 
            // DiscountedPriceValue
            // 
            DiscountedPriceValue.AutoSize = true;
            DiscountedPriceValue.Location = new Point(398, 341);
            DiscountedPriceValue.Name = "DiscountedPriceValue";
            DiscountedPriceValue.Size = new Size(41, 20);
            DiscountedPriceValue.TabIndex = 29;
            DiscountedPriceValue.Text = "Price";
            // 
            // DiscountedPriceLabel
            // 
            DiscountedPriceLabel.AutoSize = true;
            DiscountedPriceLabel.Location = new Point(269, 341);
            DiscountedPriceLabel.Name = "DiscountedPriceLabel";
            DiscountedPriceLabel.Size = new Size(123, 20);
            DiscountedPriceLabel.TabIndex = 28;
            DiscountedPriceLabel.Text = "Discounted Price:";
            DiscountedPriceLabel.Click += DiscountedPriceLabel_Click;
            // 
            // ISBNLabel
            // 
            ISBNLabel.AutoSize = true;
            ISBNLabel.Location = new Point(161, 139);
            ISBNLabel.Name = "ISBNLabel";
            ISBNLabel.Size = new Size(41, 20);
            ISBNLabel.TabIndex = 31;
            ISBNLabel.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 139);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 30;
            label3.Text = "ISBN";
            // 
            // ItemDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 757);
            Controls.Add(ISBNLabel);
            Controls.Add(label3);
            Controls.Add(DiscountedPriceValue);
            Controls.Add(DiscountedPriceLabel);
            Controls.Add(dateTimeValue);
            Controls.Add(typeValue);
            Controls.Add(label10);
            Controls.Add(borrowedValue);
            Controls.Add(authorValue);
            Controls.Add(genereValue);
            Controls.Add(priceValue);
            Controls.Add(publisherValue);
            Controls.Add(nameValue);
            Controls.Add(label1);
            Controls.Add(BorrowedLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(GenereLabel);
            Controls.Add(PriceLabel);
            Controls.Add(DateLabel);
            Controls.Add(PublisherLabel);
            Controls.Add(nameLabel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(708, 804);
            MinimumSize = new Size(708, 804);
            Name = "ItemDetails";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ItemDetails";
            Load += ItemDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BorrowedLabel;
        private Label AuthorLabel;
        private Label GenereLabel;
        private Label PriceLabel;
        private Label DateLabel;
        private Label PublisherLabel;
        private Label nameLabel;
        private Label label1;
        private Label borrowedValue;
        private Label authorValue;
        private Label genereValue;
        private Label priceValue;
        private Label publisherValue;
        private Label nameValue;
        private Label typeValue;
        private Label label10;
        private DateTimePicker dateTimeValue;
        private Label DiscountedPriceValue;
        private Label DiscountedPriceLabel;
        private Label ISBNLabel;
        private Label label3;
    }
}