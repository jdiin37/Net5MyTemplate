using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginImpl : ILogin
    {
        public bool UserLogin(string userAccount, string userPassword)
        {
            if(userAccount == "1" && userPassword == "1")
            {
                return true;
            }
            return false;
        }
    }
}
