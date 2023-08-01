using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Base
{
    internal class User
    {
        [JsonProperty]
        internal string Name { get; set; }
        [JsonProperty]
        internal string Password { get; set; }
        [JsonProperty]
        internal bool IsLibrarian { get; set; }
        [JsonIgnore]
        private Item _borrowedItem;
        [JsonProperty]
        private string BorrowedDetails { get; set; }
        [JsonProperty]
        private string BorrowedType { get; set; }
        [JsonIgnore]
        internal Item BorrowedItem
        {
            get { return _borrowedItem; }

            set
            {
                _borrowedItem = value;
                if (value == null)
                {
                    BorrowedDetails = null;
                    BorrowedType = null;
                }
                else
                {

                    BorrowedDetails = JsonConvert.SerializeObject(value);
                    if (value is Book)
                    {
                        BorrowedType = "book";
                    }
                    else
                    {
                        BorrowedType = "magazine";
                    }
                }
            }
        }
        public User(string name, string password, bool isLibrarian)
        {
            Name = name;
            Password = password;
            IsLibrarian = isLibrarian;
        }

        internal void SetBorrowed()
        {
            if (BorrowedType != null)
            {
                if (BorrowedType == "book")
                {
                    BorrowedItem = JsonConvert.DeserializeObject<Book>(BorrowedDetails);
                }
                else
                {
                    BorrowedItem = JsonConvert.DeserializeObject<Magazine>(BorrowedDetails);
                }
            }
        }
    }
}

