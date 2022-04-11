using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using GenericParsing;

namespace LB1
{
    public class SideSpecialist : Client
    {
        Company myCompany = new Company();
        public TableSet SideSpecialistTables = new TableSet();

        public SideSpecialist()
        {
            SideSpecialistTables.BuildAccountTable();
            SideSpecialistTables.BuildSalaryProjectTable();
        }

        public void login(string login, string password)
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialists.txt");
                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;

                while (parser.Read())
                {
                    if (login == parser["login"] && password == parser["password"])
                    {
                        this.setLogin(Convert.ToString(parser["login"]));
                        this.setPassword(Convert.ToString(parser["password"]));
                        this.setFirstName(Convert.ToString(parser["firstName"]));
                        this.setSecondName(Convert.ToString(parser["secondName"]));
                        this.setFatherName(Convert.ToString(parser["fatherName"]));
                        this.setPassportData(Convert.ToString(parser["passportData"]));
                        this.setIdNumber(Convert.ToString(parser["idNumber"]));
                        this.setPhoneNumber(Convert.ToString(parser["phoneNumber"]));
                        this.setEmail(Convert.ToString(parser["email"]));
                        this.setUserId(Convert.ToInt16(parser["UserID"]));
                        myCompany = Program.database.getCompany((Convert.ToString(parser["myCompany"])));
                    }
                }
            }
            loadData();
        }

        public void setMyCompany(Company myCompany)
        {
            this.myCompany = myCompany;
        }

        public Company getMyCompany()
        {
            return myCompany;
        }

        public void loadData()
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialistSlrPrjcts.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (parser["companyName"] == myCompany.getUrName())
                    {
                        SideSpecialistTables.Data.Tables["SalaryProjects"].Rows.Add(new object[] { parser["ID"], parser["companyName"], parser["period"], parser["amount"], parser["isApproved"], parser["UserID"], parser["moneyType"] });
                    }
                }

                parser.SetDataSource("../../Models/Docs/Accounts.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (Convert.ToInt16(parser["UserID"]) == getUserId())
                    {
                        SideSpecialistTables.Data.Tables["Accounts"].Rows.Add(new object[] { parser["urName"], parser["accNum"], parser["UserID"], parser["moneyType"], parser["balance"], parser["creationTime"], parser["isFreezed"] });
                    }
                }
            }
        }


        public delegate void salarylog(int ID);
        public static event salarylog getSalaryLog;

        public void salaryLog(int ID)
        {
            using (StreamWriter writer = new StreamWriter("../../Models/Docs/SideSpecialistLogs.txt", true))
            {
                writer.Write(DateTime.Now + ": " + getLogin() + " подал заявку на зарплатный проект под номером №" + Convert.ToString(ID) + "\n");
            }
        }

        public void addSalaryProject(int ID, int period, double amount, int UserID, string moneyType)
        {
            SideSpecialistTables.Data.Tables["SalaryProjects"].Rows.Add(new object[] { ID, myCompany.getUrName(), period, amount, false, UserID - 1, moneyType });
            string path = "../../Models/Docs/SideSpecialistSlrPrjcts.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("\"" + Convert.ToString(ID) + "\",\"" + myCompany.getUrName() + "\",\"" + Convert.ToString(period) + "\",\"" + Convert.ToString(amount) + "\",\"" + "False" + "\",\"" + Convert.ToString(UserID) + "\",\"" + moneyType + "\"");
            }

            getSalaryLog += salaryLog;
            getSalaryLog?.Invoke(ID);
            getSalaryLog -= salaryLog;
        }

        public delegate void logs(Bank bank, string accNum);
        public static event logs getLogs;

        public void accLogSide(Bank bank, string accNum)
        {
            string path = "../../Models/Docs/SideSpecialistLogs.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(DateTime.Now + ": " + getLogin() + " создал счет в банке \"" + bank.getUrName() + "\" под номером: №" + accNum);
            }
        }

        public void addAccount(Bank bank)
        {
            DataRow[] row = bank.getBankData().Data.Tables["Accounts"].Select();
            SideSpecialistTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[row.Length - 1]["urName"], row[row.Length - 1]["accNum"], row[row.Length - 1]["UserID"], row[row.Length - 1]["moneyType"], row[row.Length - 1]["balance"], row[row.Length - 1]["creationTime"], row[row.Length - 1]["isFreezed"] });
            getLogs += accLog;
            getLogs?.Invoke(bank, Convert.ToString(row[row.Length - 1]["accNum"]));
            getLogs -= accLog;

            getLogs += accLogSide;
            getLogs?.Invoke(bank, Convert.ToString(row[row.Length - 1]["accNum"]));
            getLogs -= accLogSide;
        }
    }
}
