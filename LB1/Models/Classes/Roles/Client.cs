using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    public class Client : User, IClient
    {
        public string passportData { get; set; }
        public string idNumber { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public int UserID { get; set; }

        public TableSet ClientTables = new TableSet();

        public Client()
        {
            ClientTables.BuildAccountTable();
        }

        public void getAccounts(Bank bank)
        {
            DataRow[] row = bank.bankData.Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToInt16(row[i]["UserID"]) == UserID)
                {
                    ClientTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[i]["accNum"], row[i]["UserID"], row[i]["moneyType"], row[i]["balance"], row[i]["creationTime"] });
                }
            }
        }
    }
}
