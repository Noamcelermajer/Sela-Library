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
    public class Discount
    {
        public Filters Name { get; set; }
        public string Value { get; set; }
        public int DiscountPercent { get; set; }
        public Discount(Filters name, string value, int percentage)
        {
            Name = name;
            Value = value;
            DiscountPercent = percentage;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is Discount discount)
            {
                if (discount.Name == Name && discount.Value == Value && DiscountPercent == discount.DiscountPercent)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return $"paremeter:{Name}, value:{Value}, discount perecentage: {DiscountPercent}";
        }
    }
}
