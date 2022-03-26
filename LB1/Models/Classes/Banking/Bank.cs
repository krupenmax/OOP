using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericParsing;
using System.Data;

namespace LB1
{
    public class Bank
    {
        string Type;
        string urName;
        uint UNP;
        uint BIK;
        string adress;
        TableSet bankData = new TableSet();

        public TableSet getBankData()
        {
            return bankData;
        }

        public void setBankData(TableSet bankData)
        {
            this.bankData = bankData;
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

        public void getBank()
        {   
            bankData.BuildAccountTable();
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("Accounts.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    bankData.Data.Tables["Accounts"].Rows.Add(new object[] { urName, parser["accNum"], Convert.ToInt16(parser["UserID"]), parser["moneyType"], Convert.ToSingle(parser["balance"]), DateTime.Now });
                }
            }
        }
        public void addAcc(int UserID, string moneyType)
        {
            int accNum = 0;
            int i = 1;
            DataRow[] row = bankData.Data.Tables["Accounts"].Select();
            while (true)
            {
                bool Check = false;
                for (int j = 0; j < row.Length; j++)
                {
                    if (Convert.ToString(i) == Convert.ToString(row[j]["accNum"]))
                    {
                        Check = true;
                    }
                }
                if (Check == false)
                {
                    accNum = i;
                    break;
                }
                i++;
            }
            bankData.Data.Tables["Accounts"].Rows.Add(new object[] { urName, accNum, UserID, moneyType, 0, DateTime.Now });
        }
        
        public void deleteAcc(string accNum)
        {
            DataRow[] row = bankData.Data.Tables["Accounts"].Select("accNum = " + accNum);
            row[0].Delete();
            bankData.Data.Tables["Accounts"].AcceptChanges();
        }

        public Account findAcc(string accNum)
        {
            DataRow[] row = bankData.Data.Tables["Accounts"].Select("accNum = " + accNum);
            Account acc = new Account();
            acc.setAccNum(accNum);
            acc.setMoneyType(Convert.ToString(row[0]["moneyType"]));
            acc.setBalance(Convert.ToDouble(row[0]["balance"]));
            acc.setUserID(Convert.ToInt16(row[0]["UserID"]));
            acc.setCreationTime(Convert.ToDateTime(row[0]["creationTime"]));
            acc.setUrName(Convert.ToString(row[0]["urName"]));
            return acc;
        }

        public void overwriteAcc(Account acc, string accNum)
        {
            DataRow[] row = bankData.Data.Tables["Accounts"].Select("accNum = " + accNum);
            row[0]["accNum"] = acc.getAccNum();
            row[0]["userID"] = acc.getUserID();
            row[0]["moneyType"] = acc.getMoneyType();
            row[0]["balance"] = acc.getBalance();
            row[0]["creationTime"] = acc.getCreationTime();
            bankData.Data.Tables["Accounts"].AcceptChanges();
        }
    }
}
