using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GenericParsing;
using System.IO;
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
            tableSet.BuildSideSpecialistTable();
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/Banks.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

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

                parser.SetDataSource("../../Models/Docs/Companies.txt");

                while (parser.Read())
                {
                    tableSet.Data.Tables["Companies"].Rows.Add(new object[] { parser["Type"], parser["urName"], parser["UNP"], parser["BIK"], parser["adress"], parser["bank"], parser["UserID"] });
                }

                parser.SetDataSource("../../Models/Docs/Clients.txt");



                while (parser.Read())
                {
                    tableSet.Data.Tables["Clients"].Rows.Add(new object[] { Convert.ToInt16(parser["UserID"]), parser["login"], parser["password"], parser["firstName"], parser["secondName"], parser["fatherName"], parser["passportData"], parser["idNumber"], parser["phoneNumber"], parser["email"] });
                }

                parser.SetDataSource("../../Models/Docs/SideSpecialists.txt");



                while (parser.Read())
                {
                    tableSet.Data.Tables["SideSpecialists"].Rows.Add(new object[] { Convert.ToInt16(parser["UserID"]), parser["login"], parser["password"], parser["firstName"], parser["secondName"], parser["fatherName"], parser["passportData"], parser["idNumber"], parser["phoneNumber"], parser["email"], parser["myCompany"] });
                }

            }
        }

        public void AddClient(int UserID, string login, string password, string firstName, string secondName, string fatherName, string passportData, string idNumber, string phoneNumber, string email)
        {
            tableSet.Data.Tables["Clients"].Rows.Add(new object[] { UserID, login, password, firstName, secondName, fatherName, passportData, idNumber, phoneNumber, email });
            string path = "../../Models/Docs/Clients.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write("\n\"" + UserID + "\"" + ",\"" + login + "\"" + ",\"" + password + "\"" + ",\"" + firstName + "\"" + ",\"" + secondName + "\"" + ",\"" + fatherName + "\"" + ",\"" + passportData + "\"" + ",\"" + idNumber + "\"" + ",\"" + phoneNumber + "\"" + ",\"" + email + "\"");
            }
        }

        public void AddSideSpecialist(int UserID, string login, string password, string firstName, string secondName, string fatherName, string passportData, string idNumber, string phoneNumber, string email, string myCompany)
        {
            tableSet.Data.Tables["SideSpecialists"].Rows.Add(new object[] { UserID, login, password, firstName, secondName, fatherName, passportData, idNumber, phoneNumber, email, myCompany });
            string path = "../../Models/Docs/SideSpecialists.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write("\n\"" + UserID + "\"" + ",\"" + login + "\"" + ",\"" + password + "\"" + ",\"" + firstName + "\"" + ",\"" + secondName + "\"" + ",\"" + fatherName + "\"" + ",\"" + passportData + "\"" + ",\"" + idNumber + "\"" + ",\"" + phoneNumber + "\"" + ",\"" + email + "\",\"" + myCompany + "\"");
            }
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

        public Client FindClient(string login)
        {
            Client NewClient = new Client();
            DataRow[] row = tableSet.Data.Tables["Clients"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["login"]) == login)
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
            }
            return NewClient;
        }

        public SideSpecialist FindSideSpecialist(string login)
        {
            SideSpecialist newSpecialist = new SideSpecialist();
            DataRow[] row = tableSet.Data.Tables["SideSpecialists"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["login"]) == login)
                {
                    newSpecialist.setLogin(Convert.ToString(row[0]["login"]));
                    newSpecialist.setPassword(Convert.ToString(row[0]["password"]));
                    newSpecialist.setFirstName(Convert.ToString(row[0]["firstName"]));
                    newSpecialist.setSecondName(Convert.ToString(row[0]["secondName"]));
                    newSpecialist.setFatherName(Convert.ToString(row[0]["fatherName"]));
                    newSpecialist.setPassportData(Convert.ToString(row[0]["passportData"]));
                    newSpecialist.setIdNumber(Convert.ToString(row[0]["idNumber"]));
                    newSpecialist.setPhoneNumber(Convert.ToString(row[0]["phoneNumber"]));
                    newSpecialist.setEmail(Convert.ToString(row[0]["email"]));
                    CompaniesController companyController = new CompaniesController();
                    newSpecialist.setMyCompany(companyController.getCompany(Convert.ToString(row[0]["myCompany"])));
                }
            }
            return newSpecialist;
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

        public void getCompaniesToBox(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = tableSet.Data.Tables["Companies"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(Convert.ToString(row[i]["urName"]));
            }
        }

        public Company getCompany(string urName)
        {
            Company company = new Company();
            DataRow[] row = tableSet.Data.Tables["Companies"].Select();

            for (int i = 0; i < row.Length; i++)
            {
                if (urName == Convert.ToString(row[i]["urName"]))
                {
                    company.setType(Convert.ToString(row[i]["Type"]));
                    company.setUrName(urName);
                    company.setUNP(Convert.ToUInt16(row[i]["UNP"]));
                    company.setBIK(Convert.ToUInt16(row[i]["BIK"]));
                    company.setAdress(Convert.ToString(row[i]["adress"]));
                    company.setBank(Convert.ToString(row[i]["bank"]));
                    company.setUserID(Convert.ToInt16(row[i]["UserID"]));
                    company.loadData();
                }
            }
            return company;
        }
    }
}
