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
            ActiveClient.addAccToClient(bank);
        }
        

        public void getAccounts()
        {
            ActiveClient.getAccounts(Program.database.BankSet[0]);
            ActiveClient.getAccounts(Program.database.BankSet[1]);
            ActiveClient.getAccounts(Program.database.BankSet[2]);
        }

        public void getCredits()
        {
            ActiveClient.getCredits(Program.database.BankSet[0]);
            ActiveClient.getCredits(Program.database.BankSet[1]);
            ActiveClient.getCredits(Program.database.BankSet[2]);
        }

        public void getInstalmentPayments()
        {
            ActiveClient.getInstalmentPayments(Program.database.BankSet[0]);
            ActiveClient.getInstalmentPayments(Program.database.BankSet[1]);
            ActiveClient.getInstalmentPayments(Program.database.BankSet[2]);
        }

        public void getSalaryProjects()
        {
            CompaniesController companiesController = new CompaniesController();
            DataRow[] row = database.tableSet.Data.Tables["Companies"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                Company company = companiesController.getCompany(Convert.ToString(row[i]["urName"]));
                ActiveClient.getSalaryProjects(company);
            }
        }

        public Account getActiveAcc(string accNum, string urName)
        {
            return ActiveClient.getActiveAcc(accNum, urName);
        }

        public Credit getActiveCredit(string creditNum, string urName)
        {
            return ActiveClient.getActiveCredit(creditNum, urName);
        }

        public PayByInstalments getActivePayment(string creditNum, string urName)
        {
            return ActiveClient.getActivePayment(creditNum, urName);
        }

        public void deleteAcc(string accNum, string urName)
        {
            ActiveClient.deleteAccount(accNum, urName);
        }

        public void addCreditToClient(Bank bank)
        {
            ActiveClient.addCreditToClient(bank);
        }

        public void addInstalmentPaymentToClient(Bank bank)
        {
            ActiveClient.addInstalmentPaymentToClient(bank);
        }

        public void addSalaryProject(Company company)
        {
            ActiveClient.addSalaryProject(company);
        }
    }
}
