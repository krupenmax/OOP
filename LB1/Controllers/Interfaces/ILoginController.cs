using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    interface ILoginController
    {
        Client Login(string login, string password);
    }
}
