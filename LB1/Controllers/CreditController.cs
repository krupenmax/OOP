using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    public class CreditController
    {
        ClientController clientController;
        public CreditController(ClientController clientController)
        {
            this.clientController = clientController;
        }

        public void getCreditsToBox(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = clientController.ActiveClient.getClientTables().Data.Tables["Credits"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(Convert.ToString(row[i]["creditNum"]) + ", " + Convert.ToString(row[i]["urName"]));
            }
        }

        public Credit getActiveCredit(string creditNum, string urName)
        {
            return clientController.getActiveCredit(creditNum, urName);
        }

        public PayByInstalments getActivePayment(string creditNum, string urName)
        {
            return clientController.getActivePayment(creditNum, urName);
        }
    }
}
