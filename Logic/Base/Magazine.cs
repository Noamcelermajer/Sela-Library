using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Logic.Enums;

namespace Logic.Base
{
    [JsonObject]
    internal class Magazine : Item
    {

        public Magazine(string name, string publisher, DateTime publishingDate, double price, string genere) : base(name, publisher, publishingDate, price,genere)
        {
        }
        [JsonConstructor]
        public Magazine()
        {
            
        }
    }
}
