using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    public class AccountInfoController
    {
        ClientController clientController;
        public AccountInfoController(ClientController clientController)
        {
            this.clientController = clientController;
        }
        public void setBox(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = clientController.ActiveClient.getClientTables().Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(Convert.ToString(row[i]["accNum"]) + ", " + Convert.ToString(row[i]["urName"]));
            }
        }

        public Account getActiveAccount(string accNum, string urName)
        {
            return clientController.getActiveAcc(accNum, urName);
        }

        public void freezeAcc(string accNum, string urName)
        {
            Account acc = getActiveAccount(accNum, urName);
            acc.setIsFreezed(true);
            clientController.ActiveClient.overwriteAcc(acc, accNum, urName);
        }

        public void activateAcc(string accNum, string urName)
        {
            Account acc = getActiveAccount(accNum, urName);
            acc.setIsFreezed(false);
            clientController.ActiveClient.overwriteAcc(acc, accNum, urName);
        }
    }
}
