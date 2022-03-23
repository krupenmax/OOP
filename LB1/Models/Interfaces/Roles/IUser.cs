using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    interface IUser
    {       
        string firstName { get; set; }
        string secondName { get; set; }
        string fatherName { get; set; }
        string login { get; set; }
        string password { get; set; }
    }
}
