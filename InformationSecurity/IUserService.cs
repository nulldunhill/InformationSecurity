using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSecurity
{
    public interface IUserService
    {
        List<User> GetUsers();

        User GetUser(string name);

        AuthStatus Auth(string name, string password);

        AuthStatus SavePassword(string name, string password);

        bool AddUser(string name, bool isBlocked, bool isWithRestrictions);

        bool UpdateUser(string name, bool isBlocked, bool isWithRestrictions);

        AuthStatus UpdatePassword(string password);

        bool IsAdmin();

        bool isCorrectPassword(string password);
    }
}
