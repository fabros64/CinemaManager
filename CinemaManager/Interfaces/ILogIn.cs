using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager
{
    interface ILogIn
    {
        LoginResult CheckUser(LoginData data);
    }
}
