using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Interfaces
{
    interface IUsersDB
    {
        User GetUser(LoginData data);
    }
}
