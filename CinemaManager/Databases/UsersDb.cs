using CinemaManager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager
{
    class UsersDb : FileDatabaseManagement<User>, IUsersDB
    {
        public List<User> Users
        {
            get
            {
                return DBObjects;
            }           
        }
       

        public UsersDb(string fileName) : base(fileName)
        {             
        }

        protected override User ReadSingleTxtLineToDbObj(string[] lineMembers)
        {
            return new User()
            {
                Id = int.Parse(lineMembers[0].Trim(new char[] { '.' })),
                Name = lineMembers[1],
                Surname = lineMembers[2],
                Login = lineMembers[3],
                Password = lineMembers[4],
                IsAdmin = bool.Parse(lineMembers[5])
            };
        }

        public User GetUser(LoginData data)
        {
            foreach (User item in Users)
            {
                if (data.Login.Equals(item.Login))
                    return item;
            }
            return null;
        }

    }
}
