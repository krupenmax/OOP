using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ClientTables.BuiltBankTable();
            ClientTables.BuildAccountTable();
        }

        public void AddBank(Bank bank)
        {
            ClientTables.Data.Tables["Banks"].Rows.Add(new object[] { bank.Type, bank.urName, bank.UNP, bank.BIK, bank.adress });
        }
        public void AddAcc(string accNum)
        {

        }
        public void closeAccount()
        {

        }
        public void takeCredit()
        {

        }
        public void takePayByInstalments()
        {

        }
        public void requestForCompanySalary()
        {
             
        }
    }
}
