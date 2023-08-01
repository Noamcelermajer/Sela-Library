namespace Library
{
    partial class AddOrEdit
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
            BookRadio = new RadioButton();
            MagazineRadio = new RadioButton();
            nameLabel = new Label();
            PublisherLabel = new Label();
            DateLabel = new Label();
            PriceLabel = new Label();
            GenereLabel = new Label();
            AuthorLabel = new Label();
            BorrowedLabel = new Label();
            NameBox = new TextBox();
            PublisherBox = new TextBox();
            PriceBox = new TextBox();
            AuthorBox = new TextBox();
            dateTimeBox = new DateTimePicker();
            BorrowedBox = new TextBox();
            AddOrEditButton = new Button();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 57);
            label1.Name = "label1";
            label1.Size = new Size(147, 24);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            // 
            // BookRadio
            // 
            BookRadio.AutoSize = true;
            BookRadio.Location = new Point(93, 121);
            BookRadio.Name = "BookRadio";
            BookRadio.Size = new Size(52, 19);
            BookRadio.TabIndex = 1;
            BookRadio.TabStop = true;
            BookRadio.Text = "Book";
            BookRadio.UseVisualStyleBackColor = true;
            BookRadio.CheckedChanged += BookRadio_CheckedChanged;
            // 
            // MagazineRadio
            // 
            MagazineRadio.AutoSize = true;
            MagazineRadio.Location = new Point(218, 121);
            MagazineRadio.Name = "MagazineRadio";
            MagazineRadio.Size = new Size(76, 19);
            MagazineRadio.TabIndex = 2;
            MagazineRadio.TabStop = true;
            MagazineRadio.Text = "Magazine";
            MagazineRadio.UseVisualStyleBackColor = true;
            MagazineRadio.CheckedChanged += MagazineRadio_CheckedChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(30, 196);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Location = new Point(30, 234);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(56, 15);
            PublisherLabel.TabIndex = 4;
            PublisherLabel.Text = "Publisher";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(30, 273);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(90, 15);
            DateLabel.TabIndex = 5;
            DateLabel.Text = "Publishing Date";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(30, 316);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 6;
            PriceLabel.Text = "Price";
            // 
            // GenereLabel
            // 
            GenereLabel.AutoSize = true;
            GenereLabel.Location = new Point(30, 359);
            GenereLabel.Name = "GenereLabel";
            GenereLabel.Size = new Size(44, 15);
            GenereLabel.TabIndex = 7;
            GenereLabel.Text = "Genre";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(30, 404);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(44, 15);
            AuthorLabel.TabIndex = 8;
            AuthorLabel.Text = "Author";
            AuthorLabel.Visible = false;
            // 
            // BorrowedLabel
            // 
            BorrowedLabel.AutoSize = true;
            BorrowedLabel.Location = new Point(30, 453);
            BorrowedLabel.Name = "BorrowedLabel";
            BorrowedLabel.Size = new Size(71, 15);
            BorrowedLabel.TabIndex = 9;
            BorrowedLabel.Text = "BorrowedBy";
            BorrowedLabel.Visible = false;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(126, 188);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(115, 23);
            NameBox.TabIndex = 10;
            // 
            // PublisherBox
            // 
            PublisherBox.Location = new Point(126, 226);
            PublisherBox.Name = "PublisherBox";
            PublisherBox.Size = new Size(115, 23);
            PublisherBox.TabIndex = 11;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(126, 308);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(115, 23);
            PriceBox.TabIndex = 12;
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(128, 396);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(115, 23);
            AuthorBox.TabIndex = 14;
            AuthorBox.Visible = false;
            // 
            // dateTimeBox
            // 
            dateTimeBox.Format = DateTimePickerFormat.Custom;
            dateTimeBox.Location = new Point(128, 269);
            dateTimeBox.Name = "dateTimeBox";
            dateTimeBox.Size = new Size(113, 23);
            dateTimeBox.TabIndex = 15;
            // 
            // BorrowedBox
            // 
            BorrowedBox.Enabled = false;
            BorrowedBox.Location = new Point(126, 445);
            BorrowedBox.Name = "BorrowedBox";
            BorrowedBox.Size = new Size(115, 23);
            BorrowedBox.TabIndex = 16;
            BorrowedBox.Visible = false;
            // 
            // AddOrEditButton
            // 
            AddOrEditButton.Location = new Point(333, 412);
            AddOrEditButton.Name = "AddOrEditButton";
            AddOrEditButton.Size = new Size(143, 62);
            AddOrEditButton.TabIndex = 17;
            AddOrEditButton.Text = "Save ";
            AddOrEditButton.UseVisualStyleBackColor = true;
            AddOrEditButton.Click += AddOrEditButton_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(126, 355);
            listBox3.Name = "listBox3";
            listBox3.ScrollAlwaysVisible = true;
            listBox3.SelectionMode = SelectionMode.MultiSimple;
            listBox3.Size = new Size(115, 19);
            listBox3.TabIndex = 23;
            // 
            // AddOrEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 576);
            Controls.Add(listBox3);
            Controls.Add(AddOrEditButton);
            Controls.Add(BorrowedBox);
            Controls.Add(dateTimeBox);
            Controls.Add(AuthorBox);
            Controls.Add(PriceBox);
            Controls.Add(PublisherBox);
            Controls.Add(NameBox);
            Controls.Add(BorrowedLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(GenereLabel);
            Controls.Add(PriceLabel);
            Controls.Add(DateLabel);
            Controls.Add(PublisherLabel);
            Controls.Add(nameLabel);
            Controls.Add(MagazineRadio);
            Controls.Add(BookRadio);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(622, 615);
            MinimumSize = new Size(622, 615);
            Name = "AddOrEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddOrEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton BookRadio;
        private RadioButton MagazineRadio;
        private Label nameLabel;
        private Label PublisherLabel;
        private Label DateLabel;
        private Label PriceLabel;
        private Label GenereLabel;
        private Label AuthorLabel;
        private Label BorrowedLabel;
        private TextBox NameBox;
        private TextBox PublisherBox;
        private TextBox PriceBox;
        private TextBox AuthorBox;
        private DateTimePicker dateTimeBox;
        private TextBox BorrowedBox;
        private Button AddOrEditButton;
        private ListBox listBox3;
    }
}