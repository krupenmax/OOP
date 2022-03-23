using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    interface IClient : IUser
    {
        string passportData { get; set; }
        string idNumber { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
    }
}
