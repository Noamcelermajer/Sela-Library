using Logic.Base;
using Logic.Enums;
using Logic.Helpers;
using Newtonsoft.Json;

namespace Logic.Managers
{
    public class ItemManager
    {
        private List<Item> items = new List<Item>();
        public ItemManager()
        {
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Items"));
            items = FileHandler.LoadItems();
        }
        internal Item AddOrEditItem(string edit, string tempType, string tempName, string tempPublisher, string tempPublishingDate, string tempPrice, string tempGenere, string tempAuthor = "")
        {
            Item item;
            if (tempType != "book" && tempType != "magazine")
            {
                throw new ArgumentException("item type must be book or magazine");
            }
            string error = "";
            if (!Validator.ValidateItemName(tempName))
            {
                error += "name, ";
            }
            if (!Validator.ValidateAuthorName(tempPublisher))
            {
                error += "publisher, ";
            }
            if (!Validator.ValidatePublishingDate(tempPublishingDate))
            {
                error += "publishing date, ";
            }
            if (!Validator.ValidatePrice(tempPrice))
            {
                error += "price, ";
            }
            if (!Validator.ValidateGenere(tempType, tempGenere))
            {
                error += "genere, ";
            }
            if (tempType == "book")
            {
                if (!Validator.ValidateAuthorName(tempAuthor))
                {
                    error += "author, ";
                }
            }
            if (error != "")
            {
                throw new ArgumentException("the follow fields were not fields correctly: " + error);
            }
            string path = "", json = "";
            if (edit == Guid.Empty.ToString())
            {
                if (tempType == "book")
                {
                    items.Add(new Book(tempName, tempPublisher, DateTime.Parse(tempPublishingDate), double.Parse(tempPrice), tempAuthor, tempGenere));
                }
                else
                {
                    items.Add(new Magazine(tempName, tempPublisher, DateTime.Parse(tempPublishingDate), double.Parse(tempPrice), tempGenere));
                }
                item = items[items.Count - 1];
                json = JsonConvert.SerializeObject(item);
                path = item.ISBN.ToString() + ".txt";
            }
            else
            {
                 item = items.Find(x => x.ISBN.ToString() == edit);
                if (item is Book book)
                {
                    book.Name = tempName;
                    book.Publisher = tempPublisher;
                    book.Author = tempAuthor;
                    book.Genre = tempGenere;
                    book.PublishingDate = DateTime.Parse(tempPublishingDate);
                    book.Price = double.Parse(tempPrice);
                    json = JsonConvert.SerializeObject(book);
                }
                else
                {
                    item.Name = tempName;
                    item.Publisher = tempPublisher;
                    item.Genre = tempGenere;
                    item.PublishingDate = DateTime.Parse(tempPublishingDate);
                    item.Price = double.Parse(tempPrice);
                    json = JsonConvert.SerializeObject(item);
                }
                path = edit + ".txt";
            }
            FileHandler.SaveItem(json, path, 0);
            return item;
        }
        internal void RemoveItem(string isbn)
        {
            if (items.Remove(items.Find(x => x.ISBN.ToString() == isbn)))
            {
                FileHandler.RemoveItem(isbn + ".txt");
            }
        }
        internal List<UIItem> GetItems(Filters fillter, bool IsLibrarian, string searchBy = "")
        {
            List<UIItem> tempItems = new List<UIItem>();

            switch (fillter)
            {
                case Filters.none:
                    foreach (var item in items)
                    {
                        tempItems.Add(ConvertToUi(item));
                    }
                    break;
                case Filters.name:
                    foreach (var item in items)
                    {
                        if (item.Name.Contains(searchBy))
                        {
                            tempItems.Add(ConvertToUi(item));
                        }
                    }
                    break;
                case Filters.author:
                    foreach (var item in items)
                    {
                        if (item is Book book)
                        {
                            if (book.Author.Contains(searchBy))
                            {
                                tempItems.Add(ConvertToUi(item));
                            }
                        }
                    }
                    break;
                case Filters.genere:
                    foreach (var item in items)
                    {
                        if (item.Genre.Contains(searchBy))
                        {
                            tempItems.Add(ConvertToUi(item));
                        }
                    }
                    break;
                case Filters.publisher:
                    foreach (var item in items)
                    {
                        if (item.Publisher.Contains(searchBy))
                        {
                            tempItems.Add(ConvertToUi(item));
                        }
                    }
                    break;
                case Filters.releaseYear:
                    foreach (var item in items)
                    {
                        if (item.PublishingDate.Year.ToString() == searchBy)
                        {
                            tempItems.Add(ConvertToUi(item));
                        }
                    }
                    break;
                case Filters.type:
                    if (searchBy == "book")
                    {
                        foreach (Book book in items.OfType<Book>())
                        {
                            tempItems.Add(ConvertToUi(book));
                        }
                    }
                    else
                    {
                        foreach (Magazine magazine in items.OfType<Magazine>())
                        {
                            tempItems.Add(ConvertToUi(magazine));
                        }
                    }
                    break;
            }
            if (!IsLibrarian)
            {
                tempItems.RemoveAll(x => x.Borrower != string.Empty);
            }
            return tempItems;
        }
        internal UIItem ConvertToUi(Item item)
        {
            if (item==null)
            {
                return null;
            }
            int discount;
            double discountedPrice;
            if (item.Discounts.Count==0)
            {
                discount = 0;
            }
            else
            {
                discount = item.Discounts.Max(x => x.DiscountPercent);
            }
            discountedPrice = ((100 - discount) * item.Price) / 100;
            if (item is Book book)
            {
                return new UIItem(book.Name, book.Publisher, book.PublishingDate, book.Price, book.Genre, book.ISBN, book.Author, book.Borrowed, discountedPrice);
            }
            else
            {
                return new UIItem(item.Name, item.Publisher, item.PublishingDate, item.Price, item.Genre, item.ISBN, item.Borrowed, discountedPrice);
            }
        }
        internal Item Find(Predicate<Item> find)
        {
            return items.Find(find);
        }
        internal void AddDiscount(Predicate<Item> check, Discount d1)
        {
            foreach (Item item in items)
            {
                if (check(item))
                {
                    item.AddDiscount(d1);
                    string json = JsonConvert.SerializeObject(item);
                    FileHandler.SaveItem(json, item.ISBN+".txt", 0);
                }
            }
        }
        internal void RemoveDiscount(Discount d1)
        {
            foreach (Item item in items)
            {
                Discount temp = item.Discounts.Find(x => x.Equals(d1));
                if (item.Discounts.Remove(temp))
                {
                    string json=JsonConvert.SerializeObject(item);
                    FileHandler.SaveItem(json, item.ISBN + ".txt", 0);
                }
            }
        }

    }
}
