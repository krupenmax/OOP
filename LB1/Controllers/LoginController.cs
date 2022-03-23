using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class LoginController : ILoginController
    {
        Database database = Program.database;
        public Client Login(string login, string password)
        {
            return database.FindByLogin(login, password);
        }
    }
}
