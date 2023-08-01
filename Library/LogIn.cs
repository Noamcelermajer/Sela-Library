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
    public partial class LogIn : Form
    {
        private LibraryManager _manager;
        bool _Librarian = false;
        public LogIn(LibraryManager manager, string type)
        {
            this._manager = manager;
            InitializeComponent();
            if (type == "user")
            {
                label1.Text = "User LogIn";
            }
            else
            {
                _Librarian = true;
                label1.Text = "Librarian LogIn";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Text = "Register";
            }
            else
            {
                button1.Text = "Log In";
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                label5.Text = "please fill both fields to continue";
                label5.Visible = true;
                if (button1.Location.X == 1 && button1.Location.Y == 1)
                {
                    button1.Location = new Point(1, 550);
                }
                else if (button1.Location.X == 1 && button1.Location.Y == 550)
                {
                    button1.Location = new Point(330, 550);
                }
                else if (button1.Location.X == 330 && button1.Location.Y == 550)
                {
                    button1.Location = new Point(330, 1);
                }
                else
                {
                    button1.Location = new Point(1, 1);
                }
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    label5.Visible = false;
                    if (_manager.RegisterUser(textBox1.Text, textBox2.Text, _Librarian))
                    {
                        MainPage m1 = new MainPage(_manager, _Librarian, textBox1.Text);
                        this.Hide();
                        m1.ShowDialog();
                    }
                    else
                    {
                        label5.Text = "your details already exist, \n please uncheck the register check box";
                        label5.Visible = true;
                    }
                }
                else
                {
                    label5.Visible = false;
                    if (_manager.FindUser(textBox1.Text, textBox2.Text, _Librarian))
                    {
                        MainPage m1 = new MainPage(_manager, _Librarian, textBox1.Text);
                        this.Hide();
                        m1.ShowDialog();
                    }
                    else
                    {
                        label5.Text = "the user couldn't be found, \n please check again your username and password";
                        label5.Visible = true;
                    }
                }
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                label5.Text = "please fill both fields to continue";
                label5.Visible = true;
                if (button1.Location.X == 1 && button1.Location.Y == 1)
                {
                    button1.Location = new Point(1, 550);
                }
                else if (button1.Location.X == 1 && button1.Location.Y == 550)
                {
                    button1.Location = new Point(330, 550);
                }
                else if (button1.Location.X == 330 && button1.Location.Y == 550)
                {
                    button1.Location = new Point(330, 1);
                }
                else
                {
                    button1.Location = new Point(1, 1);
                }
            }
        }


    }
}
