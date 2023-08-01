using Logic.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ItemDetails : Form
    {
        private UIItem _item;
        bool _isLibrarian = false;
        public ItemDetails(UIItem item, bool isLibrarian)
        {
            InitializeComponent();
            this._item = item;
            this._isLibrarian = isLibrarian;
        }
        private void ItemDetails_Load(object sender, EventArgs e)
        {
            if (_item.Type == "book")
            {
                authorValue.Text = _item.Author;
                authorValue.Visible = true;
                AuthorLabel.Visible = true;
                typeValue.Text = "Book";
            }
            else
            {
                typeValue.Text = "Magazine";
            }
            ISBNLabel.Text = _item.ISBN;
            if (_isLibrarian)
            {
                borrowedValue.Text = _item.Borrower;
                borrowedValue.Visible = true;
                BorrowedLabel.Visible = true;
            }
            nameValue.Text = _item.Name;
            publisherValue.Text = _item.Publisher;
            dateTimeValue.Value = _item.PublishingDate;
            priceValue.Text = $"{_item.Price:C}";
            genereValue.Text = _item.Genre;
            if (_item.Discount != _item.Price)
            {
                DiscountedPriceValue.Text = $"{_item.Discount:C}";
            }
            else
            {
                DiscountedPriceValue.Visible = false;
                DiscountedPriceLabel.Visible = false;
            }
        }

        private void DiscountedPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
