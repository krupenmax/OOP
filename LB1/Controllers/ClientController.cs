using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    class ClientController : ILoginController
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
            ActiveClient.ClientTables.Data.Tables["Accounts"].Rows.Add(row[row.Length - 1]);
        }
    }
}
