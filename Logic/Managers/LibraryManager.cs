using Logic.Base;
using Logic.Enums;
using Logic.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime.InteropServices;

namespace Logic.Managers
{
    public class LibraryManager
    {
        private ItemManager _itemManager;
        private UsersManager _usersManager;
        private User _currentUser;
        private List<Discount> _discounts;
        public LibraryManager()
        {
            _itemManager = new ItemManager();
            _usersManager = new UsersManager();
            _discounts = FileHandler.LoadDiscounts();
        }
        public void AddOrEditItem(string edit, string tempType, string tempName, string tempPublisher, string tempPublishingDate, string tempPrice, string tempGenere, string tempAuthor = "")
        {
            Item item = _itemManager.AddOrEditItem(edit, tempType, tempName, tempPublisher, tempPublishingDate, tempPrice, tempGenere, tempAuthor);
            NewBookDiscounts(item);
            string path = item.ISBN + ".txt";
            string json = JsonConvert.SerializeObject(item);
            FileHandler.SaveItem(json, path, 0);
        }
        public void RemoveItem(string isbn)
        {
            _itemManager.RemoveItem(isbn);
        }
        public List<UIItem> GetItems(Filters fillter, bool IsLibrarian, string searchBy = "")
        {
            return _itemManager.GetItems(fillter, IsLibrarian, searchBy);
        }
        public bool RegisterUser(string username, string password, bool isLibrarian)
        {
            _currentUser = _usersManager.RegisterUser(username, password, isLibrarian);
            if (_currentUser == null)
            {
                return false;
            }
            return true;
        }
        public bool FindUser(string username, string password, bool librarian)
        {
            _currentUser = _usersManager.FindUser(username, password, librarian);
            if (_currentUser != null)
            {
                return true;
            }
            return false;
        }
        public string GetBorrowed()
        {
            if (_currentUser.BorrowedItem == null)
            {
                return "";
            }
            return _currentUser.BorrowedItem.Name;
        }
        public void Borrow(string isbn)
        {
            if (_currentUser.BorrowedItem != null)
            {
                throw new Exception("cant borrow more than one item");
            }
            Item temp = _itemManager.Find(x => x.ISBN == isbn);
            temp.Borrowed = _currentUser.Name;
            _currentUser.BorrowedItem = temp;
            string json = JsonConvert.SerializeObject(temp);
            string path = temp.ISBN;
            FileHandler.SaveItem(json, path + ".txt", 0);
            json = JsonConvert.SerializeObject(_currentUser);
            FileHandler.SaveItem(json, _currentUser.Name + ".txt", 1);
        }
        public void Return()
        {
            if (_currentUser.BorrowedItem == null)
            {
                return;
            }
            Item temp = _itemManager.Find(x => x.ISBN == _currentUser.BorrowedItem.ISBN);
            temp.Borrowed = string.Empty;
            _currentUser.BorrowedItem = null;
            string json = JsonConvert.SerializeObject(temp);
            string path = temp.ISBN;
            FileHandler.SaveItem(json, path + ".txt", 0);
            json = JsonConvert.SerializeObject(_currentUser);
            FileHandler.SaveItem(json, _currentUser.Name + ".txt", 1);
        }
        public List<Discount> GetDiscounts()
        {
            return _discounts;
        }
        public void AddDiscount(Filters fillter, string value, int percentage)
        {


            Discount d1 = new Discount(fillter, value, percentage);
            foreach (var discount in _discounts)
            {
                if (d1.Equals(discount))
                {
                    return;
                }
            }
            switch (fillter)
            {
                case Filters.name:
                    _itemManager.AddDiscount(x => x.Name == value, d1);
                    break;
                case Filters.author:
                    _itemManager.AddDiscount(x => x is Book book && book.Author == value, d1);
                    break;
                case Filters.genere:
                    _itemManager.AddDiscount(x => x.Genre.Contains(value), d1);
                    break;
                case Filters.publisher:
                    _itemManager.AddDiscount(x => x.Publisher == value, d1);
                    break;
                case Filters.releaseYear:
                    _itemManager.AddDiscount(x => x.PublishingDate.Year.ToString() == value, d1);
                    break;
                case Filters.type:
                    if (value == "book")
                    {
                        _itemManager.AddDiscount(x => x is Book, d1);
                    }
                    else
                    {
                        _itemManager.AddDiscount(x => x is Magazine, d1);
                    }
                    break;
            }
            _discounts.Add(d1);
            string json = JsonConvert.SerializeObject(_discounts);
            FileHandler.SaveItem(json, "Discounts.txt", 2);
        }
        public void RemoveDiscount(Discount d1)
        {

            _itemManager.RemoveDiscount(d1);
            _discounts.Remove(d1);
            string json = JsonConvert.SerializeObject(_discounts);
            FileHandler.SaveItem(json, "Discounts.txt", 2);
        }
        internal void NewBookDiscounts(Item item)
        {
            foreach (var discount in _discounts)
            {
                switch (discount.Name)
                {
                    case Filters.name:
                        if (item.Name.Contains(discount.Value))
                        {
                            item.AddDiscount(discount);
                        }
                        break;
                    case Filters.author:
                        if (item is Book book)
                        {
                            if (book.Author.Contains(discount.Value))
                            {
                                item.AddDiscount(discount);
                            }
                        }
                        break;
                    case Filters.genere:
                        if (item.Genre.Equals(discount.Value))
                        {
                            item.AddDiscount(discount);
                        }
                        break;
                    case Filters.publisher:
                        if (item.Publisher.Contains(discount.Value))
                        {
                            item.AddDiscount(discount);
                        }
                        break;
                    case Filters.releaseYear:
                        if (item.PublishingDate.Year.ToString() == discount.Value)
                        {
                            item.AddDiscount(discount);
                        }
                        break;
                    case Filters.type:
                        if (discount.Value == "book" && item is Book)
                        {
                            item.AddDiscount(discount);
                        }
                        else if (discount.Value == "magazine" && item is Magazine)
                        {
                            item.AddDiscount(discount);
                        }
                        break;
                }
            }
        }
        public List<string> Report()
        {
            List<string> report = new List<string>();
            int countGeneral = 0;
            int conutBook = 0;
            int countMagazine = 0;
            int countBorrowed = 0;
            List<UIItem> list = _itemManager.GetItems(Filters.none, true, "");
            foreach (var item in list)
            {
                countGeneral++;
                if (item.Type == "book")
                {
                    conutBook++;
                }
                else
                {
                    countMagazine++;
                }
                if (item.Borrower != "")
                {
                    countBorrowed++;
                }
            }
            report.Add(countGeneral.ToString());
            report.Add(conutBook.ToString());
            report.Add(countMagazine.ToString());
            report.Add(countBorrowed.ToString());
            return report;
        }
    }
}
