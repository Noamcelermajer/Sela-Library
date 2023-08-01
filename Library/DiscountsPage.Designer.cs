namespace Library
{
    partial class DiscountsPage
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
            listBox1 = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            FillterComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(43, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(298, 504);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Enabled = false;
            AddButton.Location = new Point(369, 248);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(192, 46);
            AddButton.TabIndex = 1;
            AddButton.Text = "add discount";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Enabled = false;
            RemoveButton.Location = new Point(369, 164);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(192, 46);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "remove discount";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(491, 394);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(491, 454);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 4;
            // 
            // FillterComboBox
            // 
            FillterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FillterComboBox.FormattingEnabled = true;
            FillterComboBox.Location = new Point(491, 345);
            FillterComboBox.Name = "FillterComboBox";
            FillterComboBox.Size = new Size(175, 28);
            FillterComboBox.TabIndex = 5;
            FillterComboBox.SelectedIndexChanged += FillterComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 345);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 6;
            label1.Text = "discount parameter:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 401);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 7;
            label2.Text = "search value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 457);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 8;
            label3.Text = "discount percentage:";
            // 
            // DiscountsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 757);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FillterComboBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(listBox1);
            MaximizeBox = false;
            MaximumSize = new Size(708, 804);
            MinimumSize = new Size(708, 804);
            Name = "DiscountsPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "DiscountsPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button AddButton;
        private Button RemoveButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox FillterComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}