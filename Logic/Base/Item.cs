
using Logic.Enums;
using Newtonsoft.Json;

namespace Logic.Base
{
    [JsonObject]
    abstract internal class Item
    {
        [JsonProperty]
        internal string ISBN { get; private set; }
        [JsonProperty]
        internal string Name { get; set; }
        [JsonProperty]
        internal string Publisher { get; set; }
        [JsonProperty]
        internal DateTime PublishingDate { get; set; }
        [JsonProperty]
        internal double Price { get; set; }
        [JsonProperty]
        internal string Genre { get; set; }
        [JsonProperty]
        internal string Borrowed { get; set; }
        [JsonProperty]
        internal List<Discount> Discounts { get; set; }
        internal Item(string name, string publisher, DateTime publishingDate, double price, string genere)
        {
            Borrowed = "";
            ISBN = Guid.NewGuid().ToString() ;
            Name = name;
            Publisher = publisher;
            PublishingDate = publishingDate;
            Price = price;
            Genre = genere;
                Discounts= new List<Discount>();
        }
        [JsonConstructor]
        internal Item()
        {

        }
        internal void AddDiscount(Discount d1)
        {
            Discounts.Add(d1);
        }
    }
}