using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class CreateAccountController
    {
        public void CreateAccount(Bank bank, int UserID, string moneyType)
        {
            bank.addAcc(UserID + 1, moneyType);
        }
    }
}
