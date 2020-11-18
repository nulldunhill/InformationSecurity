using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSecurity
{
    public class User
    {
        public User(string name, string password, bool isBlocked, bool isWithRestrictions)
        {
            Name = name;
            Password = password;
            IsBlocked = isBlocked;
            IsWithRestrictions = isWithRestrictions;
        }

        public string Name { get; set; }

        public string Password { get; set; }

        public bool IsBlocked { get; set; }

        public bool IsWithRestrictions { get; set; }
    }
}
