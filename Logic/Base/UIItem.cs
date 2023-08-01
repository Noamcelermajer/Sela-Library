using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Base
{
    public class UIItem
    {
        public string Type { get; }
        public string Name { get; }
        public string Publisher { get; }
        public DateTime PublishingDate { get; }
        public double Price { get; }
        public string Genre { get; }
        public string ISBN { get; }
        public string Author { get; }
        public string Borrower { get; }
        public double Discount { get; }
        public UIItem(string name, string publisher, DateTime publishingDate, double price, string genere, string isbn, string borrower, double discount)
        {
            Type = "magazine";
            Name = name;
            Publisher = publisher;
            PublishingDate = publishingDate;
            Price = price;
            Genre = genere;
            ISBN = isbn;
            Borrower = borrower;
            Discount = discount;
        }
        public UIItem(string name, string publisher, DateTime publishingDate, double price, string genere, string isbn, string author, string borrower, double discount)
        {
            Type = "book";
            Name = name;
            Publisher = publisher;
            PublishingDate = publishingDate;
            Price = price;
            Genre = genere;
            ISBN = isbn;
            Author = author;
            Borrower = borrower;
            Discount = discount;
        }
        public override string ToString()
        {
            return $"item name: {Name}, renting price: {Discount :C}";
        }
    }
}
