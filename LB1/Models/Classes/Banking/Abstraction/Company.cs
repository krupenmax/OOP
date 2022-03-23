using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    abstract class Company : ICompany
    {
        public string Type { get; set; }
        public string urName { get; set; }
        public uint UNP { get; set; }
        public uint BIK { get; set; }
        public string adress { get; set; }
    }
}
