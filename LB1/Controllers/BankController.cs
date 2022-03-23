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
        Bank ActiveBank;
        public void SetBanks(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = Program.database.tableSet.Data.Tables["Banks"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(row[i]["urName"]);
            }
        }
        public Bank getBank(string bankName)
        {
            Bank bank = null;

            for (int i = 0; i < Program.database.BankSet.Length; i++)
            {
                if (bankName == Convert.ToString(Program.database.BankSet[i].urName))
                {
                    bank = Program.database.BankSet[i];
                }
            }
            return bank;
        }
    }
}
