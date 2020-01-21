using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager
{
    class LoginData
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    class LoginResult
    {
        public bool Result { get; set; }
        public bool ErrorPassword { get; set; }
        public bool ErrorLogin { get; set; }
        public string Message { get; set; }
        public UserDTO User { get; set; }
    }

}
