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
            DataRow[] row = clientController.ActiveClient.ClientTables.Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(row[i]["accNum"]);
            }
        }
    }
}
