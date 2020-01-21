using CinemaManager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager
{
    public class User : DbModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public bool IsAdmin { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Login + " " + Password + " "
                + IsAdmin;
        }
    }

    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAdmin { get; set; }

    }


    public static class Helpers
    {
        public static UserDTO ToUserDto(this User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Login = user.Login,
                Name = user.Name,
                Surname = user.Surname,
                IsAdmin = user.IsAdmin
            };
        }
    }

}
