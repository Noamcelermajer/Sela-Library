using Logic.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Logic.Helpers
{
    public static class FileHandler
    {
        private static readonly string _generalItemPath = Path.Combine(Directory.GetCurrentDirectory(), "Items");
        private static readonly string _generalUserPath = Path.Combine(Directory.GetCurrentDirectory(), "User");
        private static readonly string _generalDiscountPath = Directory.GetCurrentDirectory();

        public static void SaveItem(string json, string path, int kind)
        {
            if (kind == 0)
            {
                path = Path.Combine(_generalItemPath, path);
                RemoveItem(path);
                File.WriteAllText(path, json);
            }
            else if (kind == 1)
            {
                path = Path.Combine(_generalUserPath, path);
                File.WriteAllText(path, json);
            }
            else
            {
                path = Path.Combine(_generalDiscountPath, path);
                File.WriteAllText(path, json);
            }
        }
        public static void RemoveItem(string path)
        {
            path = Path.Combine(_generalItemPath, path);
            File.Delete(path);
        }
        internal static List<Item> LoadItems()
        {
            string json;
            List<Item> items = new List<Item>();
            string[] files = Directory.GetFiles(_generalItemPath);
            foreach (var file in files)
            {
                json = File.ReadAllText(file);
                if (!json.Contains("Author"))
                {
                    items.Add(JsonConvert.DeserializeObject<Magazine>(json));
                }
                else
                {
                    items.Add(JsonConvert.DeserializeObject<Book>(json));
                }
            }
            return items;
        }
        internal static List<User> LoadUsers()
        {
            string json;
            List<User> users = new List<User>();
            string[] files = Directory.GetFiles(_generalUserPath);
            foreach (var file in files)
            {
                json = File.ReadAllText(file);
                User user = JsonConvert.DeserializeObject<User>(json);
                user.SetBorrowed();
                users.Add(user);

            }
            return users;
        }
        internal static List<Discount> LoadDiscounts()
        {
            string json;
            List<Discount> discounts = new List<Discount>();
            string path = Path.Combine(_generalDiscountPath, "Discounts.txt");
            if (File.Exists(path))
            {
                json = File.ReadAllText(path);
                discounts = JsonConvert.DeserializeObject<List<Discount>>(json);
            }

            return discounts;
        }
    }
}

