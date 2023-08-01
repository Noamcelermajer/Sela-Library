    using Logic.Base;
    using Logic.Helpers;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Logic.Managers
    {
        internal class UsersManager
        {
            private List<User> users = new List<User>();
            public UsersManager()
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "User"));
                users = FileHandler.LoadUsers();
                users.Add(new User("admin", "admin", true));
            }

            internal User FindUser(string username, string password, bool librarian)
            {
                foreach (var user in users)
                {
                    if (user.Name == username && user.Password == password && user.IsLibrarian == librarian)
                    {
                        return user;
                    }
                }
                return null;
            }
            internal User RegisterUser(string username, string password, bool isLibrarian)
            {
                if (FindUser(username, password, isLibrarian) != null)
                {
                    return null;
                }
                User currentUser = new User(username, password, isLibrarian);
                users.Add(currentUser);
                string json = JsonConvert.SerializeObject(currentUser);
                FileHandler.SaveItem(json, currentUser.Name+".txt", 1);
                return currentUser;
            }             
        }
    }
