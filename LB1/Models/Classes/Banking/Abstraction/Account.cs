using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class Account : IAccount
    {
        public string accNum { get; set; }
        public int UserID { get; set; }
        public string moneyType { get; set; }
        public float balance { get; set; }
    }
}
