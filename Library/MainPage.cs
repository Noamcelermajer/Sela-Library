using Logic.Base;
using Logic.Enums;
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
    public partial class MainPage : Form
    {
        private LibraryManager _manager;
        private bool _isLibrarian;
        public MainPage(LibraryManager manager, bool isLibrarian, string name)
        {
            _manager = manager;
            _isLibrarian = isLibrarian;
            InitializeComponent();
            title.Text = $"Welcome {name} to my Library";
            ValueFillterComboBox.Enabled = false;
            foreach (var fillter in Enum.GetNames(typeof(Filters)))
            {
                FillterComboBox.Items.Add(fillter);
            }
            ValueFillterTextBox.Text = string.Empty;
            ValueFillterTextBox.Visible = false;
            if (isLibrarian)
            {
                ReturnButton.Visible = false;
                BorrowButton.Visible = false;
                EditButton.Enabled = false;
                RemoveButton.Enabled = false;
                borrowedLabel.Visible = false;
                currentBorrowedlabel.Visible = false;
                discountButton.Visible = true;
                reportButton.Visible = true;
            }
            else
            {
                string borrowedBook = _manager.GetBorrowed();
                if (borrowedBook != string.Empty)
                {
                    BorrowButton.Enabled = false;
                    ReturnButton.Enabled = true;
                }
                else
                {
                    ReturnButton.Enabled = false;
                }
                AddButton.Visible = false;
                RemoveButton.Visible = false;
                EditButton.Visible = false;
            }
            ShowItemButton.Enabled = false;
            List<UIItem> items = _manager.GetItems(Filters.none, _isLibrarian);
            FillItemList(items);
            borrowedLabel.Text = _manager.GetBorrowed();
            if (borrowedLabel.Text == "")
                ReturnButton.Enabled = false;
            else
            {
                borrowedLabel.Visible = true;
            }
        }
        private void FillItemList(List<UIItem> fillWith)
        {
            ItemBox.Items.Clear();
            foreach (var item in fillWith)
            {
                ItemBox.Items.Add(item);
            }
            BorrowButton.Enabled = false;
            EditButton.Enabled = false;
            RemoveButton.Enabled = false;
            ShowItemButton.Enabled = false;

        }
        private void FillterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueFillterTextBox.Clear();
            switch (FillterComboBox.SelectedIndex)
            {
                case 0:
                    ValueFillterComboBox.Enabled = false;
                    ValueFillterComboBox.Visible = true;
                    ValueFillterTextBox.Visible = false;
                    break;
                case 1:
                    ValueFillterComboBox.Visible = false;
                    ValueFillterTextBox.Visible = true;
                    break;
                case 2:
                    ValueFillterComboBox.Visible = false;
                    ValueFillterTextBox.Visible = true;
                    break;
                case 3:
                    ValueFillterComboBox.Items.Clear();
                    foreach (var genere in Validator.bookGenere)
                    {
                        ValueFillterComboBox.Items.Add(genere);
                    }
                    foreach (var genere in Validator.magazineGenere)
                    {
                        ValueFillterComboBox.Items.Add(genere);
                    }
                    ValueFillterComboBox.Enabled = true;
                    ValueFillterComboBox.Visible = true;
                    ValueFillterTextBox.Visible = false;
                    break;
                case 4:
                    ValueFillterComboBox.Visible = false;
                    ValueFillterTextBox.Visible = true;
                    break;
                case 5:
                    ValueFillterComboBox.Visible = false;
                    ValueFillterTextBox.Visible = true;
                    break;
                case 6:
                    ValueFillterComboBox.Items.Clear();
                    ValueFillterComboBox.Items.Add("book");
                    ValueFillterComboBox.Items.Add("magazine");
                    ValueFillterComboBox.Enabled = true;
                    ValueFillterComboBox.Visible = true;
                    ValueFillterTextBox.Visible = false;
                    break;
            }
        }
        private void FillterButton_Click(object sender, EventArgs e)
        {
            List<UIItem> items;
            switch (FillterComboBox.SelectedIndex)
            {
                case 0:
                    items = _manager.GetItems(Filters.none, _isLibrarian);
                    FillItemList(items);
                    break;
                case 1:
                    items = _manager.GetItems(Filters.name, _isLibrarian, ValueFillterTextBox.Text);
                    FillItemList(items);
                    break;
                case 2:
                    items = _manager.GetItems(Filters.author, _isLibrarian, ValueFillterTextBox.Text);
                    FillItemList(items);
                    break;
                case 3:
                    items = _manager.GetItems(Filters.genere, _isLibrarian, (string)ValueFillterComboBox.SelectedItem);
                    FillItemList(items);
                    break;
                case 4:
                    items = _manager.GetItems(Filters.publisher, _isLibrarian, ValueFillterTextBox.Text);
                    FillItemList(items);
                    break;
                case 5:
                    items = _manager.GetItems(Filters.releaseYear, _isLibrarian, ValueFillterTextBox.Text);
                    FillItemList(items);
                    break;
                case 6:
                    items = _manager.GetItems(Filters.type, _isLibrarian, (string)ValueFillterComboBox.SelectedItem);
                    FillItemList(items);
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddOrEdit p1 = new AddOrEdit(_manager);
            p1.ShowDialog();
            List<UIItem> items = _manager.GetItems(Filters.none, _isLibrarian);
            FillItemList(items);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            UIItem item = (UIItem)ItemBox.SelectedItem;
            AddOrEdit p1 = new AddOrEdit(_manager, item);
            p1.ShowDialog();
            List<UIItem> items = _manager.GetItems(Filters.none, _isLibrarian);
            FillItemList(items);
        }

        private void ItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            RemoveButton.Enabled = true;
            BorrowButton.Enabled = true;
            ShowItemButton.Enabled = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            UIItem item = (UIItem)ItemBox.SelectedItem;
            _manager.RemoveItem(item.ISBN.ToString());
            List<UIItem> items = _manager.GetItems(Filters.none, _isLibrarian);
            FillItemList(items);
        }

        private void ShowItemButton_Click(object sender, EventArgs e)
        {
            ItemDetails i1 = new ItemDetails((UIItem)ItemBox.SelectedItem, _isLibrarian);
            i1.ShowDialog();
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            DiscountsPage d1 = new DiscountsPage(_manager);
            d1.ShowDialog();
            List<UIItem> items = _manager.GetItems(Filters.none, _isLibrarian);
            FillItemList(items);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Report r = new Report(_manager);
            r.ShowDialog();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            UIItem temp = (UIItem)ItemBox.SelectedItem;
            try
            {
                _manager.Borrow(temp.ISBN);
                MessageBox.Show("you borrowed the book succesfully");
                borrowedLabel.Text = _manager.GetBorrowed();
                List<UIItem> items = _manager.GetItems(Filters.none, _isLibrarian);
                FillItemList(items);
                ReturnButton.Enabled = true;
                borrowedLabel.Text = _manager.GetBorrowed();
                borrowedLabel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            _manager.Return();
            ReturnButton.Enabled = false;
            MessageBox.Show("item has been returned");
            List<UIItem> items = _manager.GetItems(Filters.none, _isLibrarian);
            FillItemList(items);
            borrowedLabel.Visible = false;

        }
    }
}
