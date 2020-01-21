using CinemaManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager
{
    class LogInManager : ILogIn
    {

        public LoginResult CheckUser(LoginData data)
        {
            LoginResult loginResult = new LoginResult
            {
                Result = true,
                ErrorPassword = false,
                ErrorLogin = false,
                Message = ""
            };

            IUsersDB userDb = new UsersDb(ConstValue.UsersTable + ConstValue.CurrentExtensionDatabase);

            var user = userDb.GetUser(data);

            if (user == null) {

                loginResult.ErrorPassword = true;
                loginResult.ErrorLogin = true;
            }
            else
            {
                if (user.Login != data.Login)
                {
                    loginResult.ErrorLogin = true;
                }

                if (user.Password != data.Password)
                {
                    loginResult.ErrorPassword = true;
                }

                if (!loginResult.ErrorLogin && !loginResult.ErrorPassword)
                {
                    loginResult.User = user.ToUserDto();
                    return loginResult;
                }
            }
            

            loginResult.Message = CreateErrorMessage(loginResult);
            loginResult.Result = false;
            return loginResult;
        }

        private string CreateErrorMessage(LoginResult loginResult)
        {
            string message = "";
            if (loginResult.ErrorLogin && loginResult.ErrorPassword)
                message = ConstValue.LoginError + ConstValue.AndValue + ConstValue.PasswordError;
            else if (loginResult.ErrorLogin)
                message = ConstValue.LoginError;
            else if (loginResult.ErrorPassword)
                message = ConstValue.PasswordError;

            return message;
        }

    }
}
