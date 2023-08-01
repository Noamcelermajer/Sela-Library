using Logic.Base;
using Logic.Helpers;
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
    public partial class AddOrEdit : Form
    {
        private LibraryManager _manager;
        private UIItem _edit;
        public AddOrEdit(LibraryManager manager, UIItem item)
        {
            _manager = manager;
            InitializeComponent();
            _edit = item;
            FillDetails();
            label1.Text = "Edit existing item";

        }
        public AddOrEdit(LibraryManager manager)
        {
            _manager = manager;
            InitializeComponent();
            AddOrEditButton.Enabled = false;
        }
        private void FillDetails()
        {

            if (_edit.Type == "book")
            {
                BookRadio.Checked = true;
                AuthorBox.Visible = true;
                AuthorLabel.Visible = true;
                AuthorBox.Text = _edit.Author;
            }
            else
            {
                MagazineRadio.Checked = true;
            }
            BookRadio.Enabled = false;
            MagazineRadio.Enabled = false;
            AddOrEditButton.Enabled = true;
            if (_edit.Borrower != "")
            {
                BorrowedLabel.Visible = true;
                BorrowedBox.Visible = true;
                BorrowedBox.Text = _edit.Borrower;
            }
            NameBox.Text = _edit.Name;
            PublisherBox.Text = _edit.Publisher;
            dateTimeBox.Value = _edit.PublishingDate;
            PriceBox.Text = _edit.Price.ToString();
        }
        private void MagazineRadio_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            foreach (var genere in Validator.magazineGenere)
            {
                listBox3.Items.Add(genere);
            }
            BookRadio.Checked = !MagazineRadio.Checked;
            AddOrEditButton.Enabled = true;
            AuthorBox.Visible = false;
            AuthorLabel.Visible = false;


        }

        private void BookRadio_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            foreach (var genere in Validator.bookGenere)
            {
                listBox3.Items.Add(genere);
            }
            MagazineRadio.Checked = !BookRadio.Checked;
            AddOrEditButton.Enabled = true;
            AuthorBox.Visible = true;
            AuthorLabel.Visible = true;

        }

        private void AddOrEditButton_Click(object sender, EventArgs e)
        {
            string isbn = Guid.Empty.ToString();
            string type, name, publisher, date, price, genere="", author = "";

            if (_edit != null)
            {
                isbn = _edit.ISBN.ToString();
            }
            if (BookRadio.Checked == true)
            {
                type = "book";
                author = AuthorBox.Text;
            }
            else
            {
                type = "magazine";
            }
            name = NameBox.Text;
            publisher = PublisherBox.Text;
            date = dateTimeBox.Value.ToString();
            price = PriceBox.Text;
            StringBuilder sb = new StringBuilder("");
            foreach (var item in listBox3.SelectedItems)
            {
                sb.Append(item.ToString() + ",");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
                genere = sb.ToString();
            }

            if (_edit != null)
            {
                genere = _edit.Genre;
            }
            try
            {
                _manager.AddOrEditItem(isbn, type, name, publisher, date, price, genere, author);
                MessageBox.Show("item has been saved succesfuly");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
