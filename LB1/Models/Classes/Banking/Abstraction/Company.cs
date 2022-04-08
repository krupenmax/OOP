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
    public class Company
    {
        string Type;
        string urName;
        uint UNP;
        uint BIK;
        string adress;
        string bank;
        int UserID;
        TableSet CompanyTables = new TableSet();
        BankController bankController = new BankController();


        public Company()
        {
            CompanyTables.BuildAccountTable();
            CompanyTables.BuildSalaryProjectTable();
        }

        public TableSet getCompanyTables()
        {
            return CompanyTables;
        }

        public void setCompanyTables(TableSet CompanyTables)
        {
            this.CompanyTables = CompanyTables;
        }

        public int getUserID()
        {
            return UserID;
        }

        public void setUserID(int UserID)
        {
            this.UserID = UserID;
        }
            
        public string getBank()
        {
            return bank;
        }

        public void setBank(string bank)
        {
            this.bank = bank;
        }

        public string getAdress()
        {
            return adress;
        }

        public void setAdress(string adress)
        {
            this.adress = adress;
        }

        public uint getBIK()
        {
            return BIK;
        }

        public void setBIK(uint BIK)
        {
            this.BIK = BIK;
        }

        public uint getUNP()
        {
            return UNP;
        }

        public void setUNP(uint UNP)
        {
            this.UNP = UNP;
        }

        public string getType()
        {
            return Type;
        }

        public void setType(string Type)
        {
            this.Type = Type;
        }

        public string getUrName()
        {
            return urName;
        }

        public void setUrName(string urName)
        {
            this.urName = urName;
        }


        public void loadData()
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SalaryProjects.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (parser["companyName"] == urName)
                    {
                        CompanyTables.Data.Tables["SalaryProjects"].Rows.Add(new object[] { parser["ID"], parser["companyName"], parser["period"], parser["amount"], parser["isApproved"], parser["UserID"] });
                    }
                }
            }

            /*DataRow[] row = bankController.getBank(bank).getBankData().Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["urName"]) == urName)
                {
                    CompanyTables.Data.Tables["Accounts"].Rows.Add(row[i]);
                }
            }*/
        }

        public Account getAnyAcc(int amount)
        {
            Account acc = null;
            DataRow[] row = CompanyTables.Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToInt16(row[i]["balance"]) >= amount)
                {
                    acc.setAccNum(Convert.ToString(row[i]["accNum"]));
                    acc.setUserID(Convert.ToInt16(row[i]["UserID"]));
                    acc.setMoneyType(Convert.ToString(row[i]["moneyType"]));
                    acc.setBalance(Convert.ToInt16(row[i]["balance"]));
                    acc.setCreationTime(Convert.ToDateTime(row[i]["creationTime"]));
                    acc.setUrName(Convert.ToString(row[i]["urName"]));
                    acc.setIsFreezed(Convert.ToBoolean(row[i]["isFreezed"]));
                    break;
                }
            }
            return acc;
        }

        public void addSalaryProject(int period, double amount, int UserID, string moneyType)
        {
            int ID = 0;
            int i = 1;
            DataRow[] row = CompanyTables.Data.Tables["SalaryProjects"].Select();
            while (true)
            {
                bool Check = false;
                for (int j = 0; j < row.Length; j++)
                {
                    if (Convert.ToString(i) == Convert.ToString(row[j]["ID"]))
                    {
                        Check = true;
                    }
                }
                if (Check == false)
                {
                    ID = i;
                    break;
                }
                i++;
            }
            CompanyTables.Data.Tables["SalaryProjects"].Rows.Add(new object[] { ID, urName, period, amount, false, UserID, moneyType});
            string path = "../../Models/Docs/SalaryProjects.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("\"" + Convert.ToString(ID) + "\",\"" + urName + "\",\"" + Convert.ToString(period) + "\",\"" + Convert.ToString(amount) + "\",\"" + "False" + "\",\"" + Convert.ToString(UserID + 1) + "\",\"" + moneyType + "\"");
            }
        }
    }
}
