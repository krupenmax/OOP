using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    class CreditLoadController
    {
        public void getCreditsToBox(System.Windows.Forms.ComboBox comboBox)
        {
            Program.database.BankSet[0].getCredits(comboBox);
            Program.database.BankSet[1].getCredits(comboBox);
            Program.database.BankSet[2].getCredits(comboBox);
        }

        public void getInstalmentToBox(System.Windows.Forms.ComboBox comboBox)
        {
            Program.database.BankSet[0].getInstalments(comboBox);
            Program.database.BankSet[1].getInstalments(comboBox);
            Program.database.BankSet[2].getInstalments(comboBox);
        }
    }
}
