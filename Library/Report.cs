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
    public partial class Report : Form
    {
        LibraryManager _manager=new LibraryManager();
        public Report(LibraryManager manager)
        {
            _manager = manager;
            InitializeComponent();
            List<string> list = manager.Report();
            AmountLabel.Text = list[0];
            BooksLabel.Text= list[1];
            MagazineLabel.Text= list[2];
            BorrowedAmount.Text = list[3];
        }


    }
}
