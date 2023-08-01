using Logic.Base;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.Helpers
{
    public static class Validator
    {
        public static readonly List<string> bookGenere = new List<string>() { "action", "classic", "fantasy", "horror", "romance", "sci-fi", "cooking", "history", "biography" };
        public static readonly List<string> magazineGenere = new List<string>() { "science", "cooking", "history", "finance", "health" };
        public static bool ValidateItemName(string name)
        {
            if (name.Length < 2)
                return false;
            return true;
        }
        public static bool ValidatePublishingDate(string date)
        {
            DateTime d1;
            if (!DateTime.TryParse(date, out d1))
            {
                return false;
            }
            if (d1.Date > DateTime.Now.Date)
            {
                return false;
            }
            return true;
        }
        public static bool ValidatePrice(string price)
        {
            double newPrice;
            if (!double.TryParse(price, out newPrice))
            {
                return false;
            }
            if (newPrice <= 0)
            {
                return false;
            }
            return true;
        }
        public static bool ValidateAuthorName(string name)
        {

            if (!(name.All(x => char.IsLetter(x) || x == ' ')))
                return false;
            if (name.Length < 2 || name.Length > 25)
                return false;
            return true;
        }
        public static bool ValidateGenere(string type, string genere)
        {
            string[] generes = genere.Split(",");
            if (generes.Length == 0)
            {
                return false;
            }
            if (type == "book")
            {
                foreach (string gen in generes)
                {
                    if (!bookGenere.Contains(gen))
                    {
                        return false;
                    }
                }
            }
            else if (type == "magazine")
            {
                foreach (string gen in generes)
                {
                    if (!magazineGenere.Contains(gen))
                    {
                        return false;
                    }
                }
            }
            else
                return false;
            return true;
        }
    }
}
