using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    class InstalmentController
    {
        ClientController clientController;
        public InstalmentController(ClientController clientController)
        {
            this.clientController = clientController;
        }

        public void getInstalmentPaymentsToBox(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = clientController.ActiveClient.getClientTables().Data.Tables["InstalmentPayments"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(Convert.ToString(row[i]["creditNum"]) + ", " + Convert.ToString(row[i]["urName"]));
            }
        }
    }
}
