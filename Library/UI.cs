using Logic.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UI : Form
    {
        private LibraryManager manager;
        public UI(LibraryManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void Librarian_Click(object sender, EventArgs e)
        {
            LogIn librarianLogIn = new LogIn(manager, "librarian");
            this.Hide();
            librarianLogIn.ShowDialog();
            this.Show();
        }


        private void User_Click(object sender, EventArgs e)
        {
            LogIn userLogIn = new LogIn(manager, "user");
            this.Hide();
            userLogIn.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UI_Load(object sender, EventArgs e)
        {

        }
    }
}
