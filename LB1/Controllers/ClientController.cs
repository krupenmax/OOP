using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    public class ClientController : ILoginController
    {
        public Client ActiveClient;
        Database database = Program.database;
        public Client Login(string login, string password)
        {
            return database.FindByLogin(login, password);
        }
        public void GetClient(string login, string password)
        {
            ActiveClient = Login(login, password);
        }
        public void addAccToClient(Bank bank)
        {
            DataRow[] row = bank.bankData.Data.Tables["Accounts"].Select();
            ActiveClient.ClientTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[row.Length - 1]["accNum"], row[row.Length - 1]["UserID"], row[row.Length - 1]["moneyType"], row[row.Length - 1]["balance"], row[row.Length - 1]["creationTime"] });
        }
        
        public void getAccounts()
        {
            ActiveClient.getAccounts(Program.database.BankSet[0]);
            ActiveClient.getAccounts(Program.database.BankSet[1]);
            ActiveClient.getAccounts(Program.database.BankSet[2]);
        }
    }
}
