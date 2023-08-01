using Logic.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Base
{
    [JsonObject]
    internal class Book : Item
    {
        [JsonProperty]
        internal string Author { get; set; }
        public Book(string name, string publisher, DateTime publishingDate, double price, string author, string genere) : base(name, publisher, publishingDate, price, genere)
        {
            Author = author;
        }
        [JsonConstructor]
        internal Book()
        {
            
        }
        public override bool Equals(object? obj)
        {
            if (obj is Book item)
            {
                if (Name == item.Name && PublishingDate == item.PublishingDate && Author == item.Author)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
