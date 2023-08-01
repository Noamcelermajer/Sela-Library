namespace Library
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            Librarian = new Button();
            User = new Button();
            SuspendLayout();
            // 
            // Librarian
            // 
            Librarian.BackColor = Color.FromArgb(224, 224, 224);
            resources.ApplyResources(Librarian, "Librarian");
            Librarian.Name = "Librarian";
            Librarian.UseVisualStyleBackColor = false;
            Librarian.Click += Librarian_Click;
            // 
            // User
            // 
            User.BackColor = Color.FromArgb(224, 224, 224);
            resources.ApplyResources(User, "User");
            User.Name = "User";
            User.UseVisualStyleBackColor = false;
            User.Click += User_Click;
            // 
            // UI
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(User);
            Controls.Add(Librarian);
            MaximizeBox = false;
            Name = "UI";
            ShowIcon = false;
            Load += UI_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Librarian;
        private Button User;
    }
}