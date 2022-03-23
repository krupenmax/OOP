using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    class BankController
    {
        public void SetBanks(System.Windows.Forms.ComboBox comboBox)
        {
            Program.database.SetBanks(comboBox);
        }
        public Bank getBank(string bankName)
        {
            return Program.database.getBank(bankName);
        }
    }
}
