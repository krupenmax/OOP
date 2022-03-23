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
                    BankSet[i].Type = parser["Type"];
                    BankSet[i].urName = parser["urName"];
                    BankSet[i].UNP = Convert.ToUInt32(parser["UNP"]);
                    BankSet[i].BIK = Convert.ToUInt32(parser["BIK"]);
                    BankSet[i].adress = parser["adress"];
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
                NewClient.login = Convert.ToString(row[0]["login"]);
                NewClient.password = Convert.ToString(row[0]["password"]);
                NewClient.firstName = Convert.ToString(row[0]["firstName"]);
                NewClient.secondName = Convert.ToString(row[0]["secondName"]);
                NewClient.fatherName = Convert.ToString(row[0]["fatherName"]);
                NewClient.passportData = Convert.ToString(row[0]["passportData"]);
                NewClient.idNumber = Convert.ToString(row[0]["idNumber"]);
                NewClient.phoneNumber = Convert.ToString(row[0]["phoneNumber"]);
                NewClient.email = Convert.ToString(row[0]["email"]);
            }
            return NewClient;
        }
    }
}
