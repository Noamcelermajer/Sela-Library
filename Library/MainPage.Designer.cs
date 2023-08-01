namespace Library
{
    partial class MainPage
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
            title = new Label();
            ItemBox = new ListBox();
            FillterComboBox = new ComboBox();
            ValueFillterComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            BorrowButton = new Button();
            ShowItemButton = new Button();
            AddButton = new Button();
            RemoveButton = new Button();
            FillterButton = new Button();
            ValueFillterTextBox = new TextBox();
            EditButton = new Button();
            ReturnButton = new Button();
            currentBorrowedlabel = new Label();
            discountButton = new Button();
            reportButton = new Button();
            borrowedLabel = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.Black;
            title.ImeMode = ImeMode.NoControl;
            title.Location = new Point(149, 119);
            title.Name = "title";
            title.Size = new Size(899, 70);
            title.TabIndex = 1;
            title.Text = "welcome *name* to my Library";
            // 
            // ItemBox
            // 
            ItemBox.AllowDrop = true;
            ItemBox.FormattingEnabled = true;
            ItemBox.ItemHeight = 20;
            ItemBox.Location = new Point(149, 505);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(643, 384);
            ItemBox.TabIndex = 2;
            ItemBox.SelectedIndexChanged += ItemBox_SelectedIndexChanged;
            // 
            // FillterComboBox
            // 
            FillterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FillterComboBox.FormattingEnabled = true;
            FillterComboBox.Location = new Point(246, 285);
            FillterComboBox.Name = "FillterComboBox";
            FillterComboBox.Size = new Size(388, 28);
            FillterComboBox.TabIndex = 3;
            FillterComboBox.SelectedIndexChanged += FillterComboBox_SelectedIndexChanged;
            // 
            // ValueFillterComboBox
            // 
            ValueFillterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ValueFillterComboBox.Enabled = false;
            ValueFillterComboBox.FormattingEnabled = true;
            ValueFillterComboBox.Location = new Point(246, 380);
            ValueFillterComboBox.Name = "ValueFillterComboBox";
            ValueFillterComboBox.Size = new Size(388, 28);
            ValueFillterComboBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 285);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Fillter by:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 391);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Fillterd value:";
            // 
            // BorrowButton
            // 
            BorrowButton.Enabled = false;
            BorrowButton.Location = new Point(823, 653);
            BorrowButton.Name = "BorrowButton";
            BorrowButton.Size = new Size(142, 61);
            BorrowButton.TabIndex = 7;
            BorrowButton.Text = "Borrow Item";
            BorrowButton.UseVisualStyleBackColor = true;
            BorrowButton.Click += BorrowButton_Click;
            // 
            // ShowItemButton
            // 
            ShowItemButton.Location = new Point(823, 739);
            ShowItemButton.Name = "ShowItemButton";
            ShowItemButton.Size = new Size(142, 61);
            ShowItemButton.TabIndex = 8;
            ShowItemButton.Text = "Show Full Details";
            ShowItemButton.UseVisualStyleBackColor = true;
            ShowItemButton.Click += ShowItemButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(1201, 828);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(142, 61);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add Item";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(1053, 828);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(142, 61);
            RemoveButton.TabIndex = 10;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // FillterButton
            // 
            FillterButton.Location = new Point(700, 269);
            FillterButton.Name = "FillterButton";
            FillterButton.Size = new Size(133, 53);
            FillterButton.TabIndex = 11;
            FillterButton.Text = "Fillter";
            FillterButton.UseVisualStyleBackColor = true;
            FillterButton.Click += FillterButton_Click;
            // 
            // ValueFillterTextBox
            // 
            ValueFillterTextBox.Location = new Point(246, 387);
            ValueFillterTextBox.Name = "ValueFillterTextBox";
            ValueFillterTextBox.Size = new Size(388, 27);
            ValueFillterTextBox.TabIndex = 12;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(905, 828);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(142, 61);
            EditButton.TabIndex = 13;
            EditButton.Text = "Edit Item";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(823, 572);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(142, 61);
            ReturnButton.TabIndex = 14;
            ReturnButton.Text = "Return Item";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // currentBorrowedlabel
            // 
            currentBorrowedlabel.AutoSize = true;
            currentBorrowedlabel.Location = new Point(883, 351);
            currentBorrowedlabel.Name = "currentBorrowedlabel";
            currentBorrowedlabel.Size = new Size(165, 20);
            currentBorrowedlabel.TabIndex = 15;
            currentBorrowedlabel.Text = "current borrowed book:";
            // 
            // discountButton
            // 
            discountButton.Location = new Point(1153, 420);
            discountButton.Name = "discountButton";
            discountButton.Size = new Size(129, 51);
            discountButton.TabIndex = 16;
            discountButton.Text = "discounts";
            discountButton.UseVisualStyleBackColor = true;
            discountButton.Visible = false;
            discountButton.Click += discountButton_Click;
            // 
            // reportButton
            // 
            reportButton.Location = new Point(823, 491);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(142, 51);
            reportButton.TabIndex = 17;
            reportButton.Text = "library report";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Visible = false;
            reportButton.Click += reportButton_Click;
            // 
            // borrowedLabel
            // 
            borrowedLabel.AutoSize = true;
            borrowedLabel.Location = new Point(1064, 351);
            borrowedLabel.Name = "borrowedLabel";
            borrowedLabel.Size = new Size(50, 20);
            borrowedLabel.TabIndex = 18;
            borrowedLabel.Text = "label4";
            borrowedLabel.Visible = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1351, 915);
            Controls.Add(borrowedLabel);
            Controls.Add(reportButton);
            Controls.Add(discountButton);
            Controls.Add(currentBorrowedlabel);
            Controls.Add(ReturnButton);
            Controls.Add(EditButton);
            Controls.Add(ValueFillterTextBox);
            Controls.Add(FillterButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ShowItemButton);
            Controls.Add(BorrowButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ValueFillterComboBox);
            Controls.Add(FillterComboBox);
            Controls.Add(ItemBox);
            Controls.Add(title);
            MaximizeBox = false;
            MaximumSize = new Size(1369, 962);
            MinimumSize = new Size(1369, 962);
            Name = "MainPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private ListBox ItemBox;
        private ComboBox FillterComboBox;
        private ComboBox ValueFillterComboBox;
        private Label label1;
        private Label label2;
        private Button BorrowButton;
        private Button ShowItemButton;
        private Button AddButton;
        private Button RemoveButton;
        private Button FillterButton;
        private TextBox ValueFillterTextBox;
        private Button EditButton;
        private Button ReturnButton;
        private Label currentBorrowedlabel;
        private Button discountButton;
        private Button reportButton;
        private Label borrowedLabel;
    }
}