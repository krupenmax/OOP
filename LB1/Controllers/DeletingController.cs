using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class DeletingController
    {
        string accNum;
        string urName;
        ClientController clientController;
        Bank bank;
        public DeletingController(string accNum, string urName, ClientController clientController, Bank bank)
        {
            this.accNum = accNum;
            this.urName = urName;
            this.clientController = clientController;
            this.bank = bank;
            deleteAcc(accNum, urName);          
        }
        public void deleteAcc(string accNum, string urName)
        {
            clientController.deleteAcc(accNum, urName);
            bank.deleteAcc(accNum);
        }
    }
}
