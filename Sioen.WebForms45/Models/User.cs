using System;

namespace Sioen.WebForms45.Models
{
    public class User
    {
        public User(string name)
        {
            Name = name;
            UserId = Guid.NewGuid();
        }

        public Guid UserId { get; private set; }

        public String Name { get; set; }
    }
}