using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GenericParsing;
namespace LB1
{
    public class Database 
    {
        public TableSet tableSet = new TableSet();
        public Bank[] BankSet = new Bank[3];

        public void GetData()
        {
            tableSet.BuildClientTable();
            tableSet.BuiltCompanyTable();
            tableSet.BuiltBankTable();
            using (GenericParser parser = new GenericParser())
            {
                 parser.SetDataSource("Clients.txt");

                 parser.ColumnDelimiter = ',';
                 parser.FirstRowHasHeader = true;
                 parser.TextQualifier = '\"';

                 while (parser.Read())
                 {
                    tableSet.Data.Tables["Clients"].Rows.Add(new object[] { Convert.ToInt16(parser["UserID"]), parser["login"], parser["password"], parser["firstName"], parser["secondName"], parser["fatherName"], parser["passportData"], parser["idNumber"], parser["phoneNumber"], parser["email"] });
                 }

                parser.SetDataSource("Companies.txt");

                while (parser.Read())
                {
                    tableSet.Data.Tables["Companies"].Rows.Add(new object[] { parser["Type"], parser["urName"], parser["UNP"], parser["BIK"], parser["adress"] });
                }

                parser.SetDataSource("Banks.txt");
                int i = 0;
                while (parser.Read())
                {
                    tableSet.Data.Tables["Banks"].Rows.Add(new object[] { parser["Type"], parser["urName"], Convert.ToUInt32(parser["UNP"]), Convert.ToUInt32(parser["BIK"]), parser["adress"] });

                    BankSet[i] = new Bank();
                    BankSet[i].setType(parser["Type"]);
                    BankSet[i].setUrName(parser["urName"]);
                    BankSet[i].setUNP(Convert.ToUInt32(parser["UNP"]));
                    BankSet[i].setBIK(Convert.ToUInt32(parser["BIK"]));
                    BankSet[i].setAdress(parser["adress"]);
                    BankSet[i].getBank();
                    i++;
                }
            }
        }

        public void AddClient(int UserID, string login, string password, string firstName, string secondName, string fatherName, string passportData, string idNumber, string phoneNumber, string email)
        {
            tableSet.Data.Tables["Clients"].Rows.Add(new object[] { UserID, login, password, firstName, secondName, fatherName, passportData, idNumber, phoneNumber, email });
        }

        public Client FindByLogin(string login, string password)
        {
            Client NewClient = new Client();
            DataRow[] row = tableSet.Data.Tables["Clients"].Select(" login = '" + login + "' AND Password = '" + password + "'");
            if (row.Length != 0)
            {
                NewClient.setLogin(Convert.ToString(row[0]["login"]));
                NewClient.setPassword(Convert.ToString(row[0]["password"]));
                NewClient.setFirstName(Convert.ToString(row[0]["firstName"]));
                NewClient.setSecondName(Convert.ToString(row[0]["secondName"]));
                NewClient.setFatherName(Convert.ToString(row[0]["fatherName"]));
                NewClient.setPassportData(Convert.ToString(row[0]["passportData"]));
                NewClient.setIdNumber(Convert.ToString(row[0]["idNumber"]));
                NewClient.setPhoneNumber(Convert.ToString(row[0]["phoneNumber"]));
                NewClient.setEmail(Convert.ToString(row[0]["email"]));
            }
            return NewClient;
        }

        public void SetBanks(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = tableSet.Data.Tables["Banks"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(row[i]["urName"]);
            }
        }

        public Bank getBank(string bankName)
        {
            Bank bank = null;

            for (int i = 0; i < BankSet.Length; i++)
            {
                if (bankName == Convert.ToString(BankSet[i].getUrName()))
                {
                    bank = BankSet[i];
                }
            }
            return bank;
        }
    }
}
