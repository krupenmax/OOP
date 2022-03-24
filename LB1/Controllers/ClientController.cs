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
            ActiveClient.ClientTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[row.Length - 1]["urName"], row[row.Length - 1]["accNum"], row[row.Length - 1]["UserID"], row[row.Length - 1]["moneyType"], row[row.Length - 1]["balance"], row[row.Length - 1]["creationTime"] });
        }
        
        public void getAccounts()
        {
            ActiveClient.getAccounts(Program.database.BankSet[0]);
            ActiveClient.getAccounts(Program.database.BankSet[1]);
            ActiveClient.getAccounts(Program.database.BankSet[2]);
        }
        
        public Account getActiveAcc(string accNum, string urName)
        {
            Account acc = new Account();
            DataRow[] row = ActiveClient.ClientTables.Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (accNum == Convert.ToString(row[i]["accNum"]) && urName == Convert.ToString(row[i]["urName"]))
                {
                    acc.accNum = Convert.ToString(row[i]["accNum"]);
                    acc.UserID = Convert.ToInt16(row[i]["UserID"]);
                    acc.moneyType = Convert.ToString(row[i]["moneyType"]);
                    acc.balance = Convert.ToInt16(row[i]["balance"]);
                    acc.creationTime = Convert.ToDateTime(row[i]["creationTime"]);

                    break;
                }
            }
            return acc;
        }
        public void deleteAcc(string accNum, string urName)
        {
            ActiveClient.deleteAccount(accNum, urName);
        }
    }
}
