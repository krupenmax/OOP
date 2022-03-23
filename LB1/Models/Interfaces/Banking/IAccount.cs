using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    interface IAccount
    {
        string accNum { get; set; }
        int UserID { get; set; }
        string moneyType { get; set; }
        float balance { get; set; }
        DateTime creationTime { get; set; }
    }
}
