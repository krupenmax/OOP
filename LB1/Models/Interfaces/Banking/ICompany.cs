using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    interface ICompany
    {
        string Type { get; set; }
        string urName { get; set; }
        uint UNP { get; set; }
        uint BIK { get; set; }
        string adress { get; set; }
    }
}
