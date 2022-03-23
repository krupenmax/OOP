using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public abstract class User : IUser
    {
        public string password { get; set; }
        public string login { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string fatherName { get; set; }
    }
}
