using System.Collections.Generic;
using Sioen.WebForms45.Models;

namespace Sioen.WebForms45.Repositories
{
    public class UserRepository
    {
        private static readonly IList<User> Users;

        static UserRepository()
        {
            Users = new List<User>()
                {
                    new User("John"),
                    new User("Paul"),
                    new User("Ringo"),
                    new User("George"),
                    new User("Kurt"),
                    new User("Dave"),
                    new User("Krist"),
                    new User("John"),
                    new User("Thom"),
                    new User("Jonny"),
                    new User("Phil"),
                    new User("Colin"),
                    new User("Ed")
                };
        }

        public IList<User> GetAllUsers()
        {
            return Users;
        }
    }
}