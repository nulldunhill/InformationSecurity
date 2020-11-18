using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InformationSecurity
{
    class UsersFile
    {
        private const string fileName = "users";

        private static DES _des;
        private const string key = "key1";
        private const string salt = "salt";

        public static void Init()
        {
            _des = DES.Create();

            var bytes = Encoding.ASCII.GetBytes(key + salt);

            _des.Key = bytes;
            _des.IV = bytes;
        }

        public static List<User> Read()
        {
            var des = DES.Create();
            des.Mode = CipherMode.CFB;

            var users = new List<User>();
            using (FileStream fs = new FileStream(fileName + ".cfb", FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    using (CryptoStream cs = new CryptoStream(fs, des.CreateDecryptor(_des.Key, _des.IV), 
                        CryptoStreamMode.Read))
                    {
                        using (var streamReader = new StreamReader(cs))
                        {
                            var textFromFile = streamReader.ReadLine();
                            users = JsonConvert.DeserializeObject<List<User>>(textFromFile);
                        }
                    }
                }
            }
            return users;
        }

        public static void Update(List<User> users)
        {
            var des = DES.Create();
            des.Mode = CipherMode.CFB;

            using (FileStream fs = new FileStream(fileName + ".cfb", FileMode.Create))
            {
                using (var cs = new CryptoStream(fs, des.CreateEncryptor(_des.Key, _des.IV), 
                    CryptoStreamMode.Write))
                {
                    using (var sw = new StreamWriter(cs))
                    {
                        string textToFile = JsonConvert.SerializeObject(users);
                        sw.WriteLine(textToFile);
                    }
                }
            }
        }
    }
}
