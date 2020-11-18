using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace InformationSecurity
{
    public enum AuthStatus
    {
        PasswordWrong = 0,
        Done = 1,
        UserNotFound = 2,
        UserFirstAuth = 3,
        UserBlocked = 4,
        PasswordIncorrect = 5,
    }

    class UserService : IUserService
    {
        private static UserService instance;

        public static UserService GetInstance()
        {
            if (instance == null)
                instance = new UserService();
            return instance;
        }


        private List<User> users;
        private User currentUser;
        private Regex passwordRegex = new Regex(@"[^A-Za-z0-9]+", RegexOptions.IgnoreCase);

        private UserService()
        {
            UsersFile.Init();

            users = UsersFile.Read();
            if (users.Count == 0)
            {
                users.Add(new User("ADMIN", "", false, false));
                UsersFile.Update(users);
            }
        }


        public List<User> GetUsers()
        {
            return users;
        }

        public User GetUser(string name)
        {
            return users.Find(user => user.Name.Equals(name));
        }

        public AuthStatus Auth(string name, string password)
        {
            var current = users.Find(user => user.Name.Equals(name));

            if (current == null)
            {
                return AuthStatus.UserNotFound;
            }

            if (current.IsBlocked)
            {
                return AuthStatus.UserBlocked;
            }

            if (current.Password.Length == 0)
            {
                if (current.IsWithRestrictions && passwordRegex.IsMatch(password))
                {
                    return AuthStatus.PasswordIncorrect;
                }

                return AuthStatus.UserFirstAuth;
            }

            if (!compare(current.Password, password))
            {
                return AuthStatus.PasswordWrong;
            }

            currentUser = current;
            return AuthStatus.Done;
        }

        public AuthStatus SavePassword(string name, string password)
        {
            var current = users.Find(user => user.Name.Equals(name));

            if (current == null)
            {
                return AuthStatus.UserNotFound;
            }

            current.Password = hash(password);
            UsersFile.Update(users);

            currentUser = current;
            return AuthStatus.Done;
        }

        public bool AddUser(string name, bool isBlocked, bool isWithRestrictions)
        {
            if (name.Equals("ADMIN") || users.Find(user => user.Name.Equals(name)) != null)
            {
                return false;
            }
            users.Add(new User(name, "", isBlocked, isWithRestrictions));
            UsersFile.Update(users);
            return true;
        }

        public bool UpdateUser(string name, bool isBlocked, bool isWithRestrictions)
        {
            var current = users.Find(user => user.Name.Equals(name));

            if (current == null)
            {
                return false;
            }

            current.IsBlocked = isBlocked;
            current.IsWithRestrictions = isWithRestrictions;
            UsersFile.Update(users);
            return true;
        }

        public AuthStatus UpdatePassword(string password)
        {
            var current = users.Find(currentUser => currentUser.Name.Equals(this.currentUser.Name));

            if (current == null)
            {
                return AuthStatus.UserNotFound;
            }

            if (current.IsWithRestrictions && passwordRegex.IsMatch(password))
            {
                return AuthStatus.PasswordIncorrect;
            }


            current.Password = hash(password);
            UsersFile.Update(users);
            return AuthStatus.Done;
        }

        public bool IsAdmin()
        {
            return currentUser.Name.Equals("ADMIN");
        }

        public bool IsCorrectPassword(string password)
        {
            return compare(currentUser.Password, password);
        }

        private string hash(string password)
        {
            using (var sha = new SHA1Cng())
            {
                var bytes = Encoding.ASCII.GetBytes(password);
                bytes = sha.ComputeHash(bytes);
                password = Encoding.ASCII.GetString(bytes);
            }

            return password;
        }

        private bool compare(string hash, string password)
        {
            using (var sha = new SHA1Cng())
            {
                var bytes = Encoding.ASCII.GetBytes(password);
                bytes = sha.ComputeHash(bytes);
                password = Encoding.ASCII.GetString(bytes);
            }

            return hash.Equals(password);
        }
    }
}
