using Logic.Enums;
using Logic.Managers;
using Logic.Base;
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
    public partial class DiscountsPage : Form
    {
        private LibraryManager _libraryManager;
        public DiscountsPage(LibraryManager libraryManager)
        {
            _libraryManager = libraryManager;
            InitializeComponent();
            foreach (var fillter in Enum.GetNames(typeof(Filters)))
            {
                FillterComboBox.Items.Add(fillter);
            }
            RefreshDiscounts();
        }
        private void RefreshDiscounts()
        {
            List<Discount> discounts = _libraryManager.GetDiscounts();
            listBox1.Items.Clear();
            foreach (var discount in discounts)
            {
                listBox1.Items.Add(discount);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveButton.Enabled = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Discount discount = (Discount)listBox1.SelectedItem;
            _libraryManager.RemoveDiscount(discount);
            MessageBox.Show("discount have been removed succefully");
            RefreshDiscounts();
        }
        private void FillterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddButton.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                int per;
                if (!int.TryParse(textBox2.Text, out per))
                {
                    MessageBox.Show("percentage have to be full number");
                }
                else
                {
                    string name = (string)FillterComboBox.SelectedItem;
                    Filters f1 = Enum.Parse<Filters>(name);
                    _libraryManager.AddDiscount(f1, textBox1.Text, per);
                    RefreshDiscounts();
                    MessageBox.Show("discount have been saved succefully");
                }

            }
        }
    }
}
