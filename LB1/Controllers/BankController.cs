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
        
        public Credit findCredit(string accNum, string urName)
        {
            return getBank(urName).findCredit(accNum);
        }

        public PayByInstalments findInstalment(string accNum, string urName)
        {
            return getBank(urName).findInstalment(accNum);
        }

        public void approveCredit(string creditNum, string urName)
        {
            getBank(urName).approveCredit(creditNum);
        }

        public void approveInstalment(string creditNum, string urName)
        {
            getBank(urName).approveInstalment(creditNum);
        }
    }
}
