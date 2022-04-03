using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericParsing;
using System.Data;
using System.IO;
using System.Threading;

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
            bankData.BuildCreditTable();
            bankData.BuildInstalmentPayTable();
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("Accounts.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (Convert.ToString(parser["urName"]) == urName)
                    {
                        bankData.Data.Tables["Accounts"].Rows.Add(new object[] { urName, parser["accNum"], Convert.ToInt16(parser["UserID"]), parser["moneyType"], Convert.ToSingle(parser["balance"]), Convert.ToDateTime(parser["creationTime"]), Convert.ToBoolean(parser["isFreezed"]) });
                    }
                }

                parser.SetDataSource("Credits.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (Convert.ToString(parser["bank"]) == urName)
                    {
                        bankData.Data.Tables["Credits"].Rows.Add(new object[] { parser["creditNum"], parser["amount"], parser["percent"], parser["period"], parser["bank"], parser["UserID"], parser["isApproved"], parser["creationTime"], parser["moneyType"] });

                    }
                }

                parser.SetDataSource("InstalmentPayments.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (Convert.ToString(parser["bank"]) == urName)
                    {
                        bankData.Data.Tables["InstalmentPayments"].Rows.Add(new object[] { parser["creditNum"], parser["amount"], parser["percent"], parser["period"], parser["bank"], parser["UserID"], parser["isApproved"], parser["creationTime"], parser["moneyType"] });
                    }
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
            string path = "Accounts.txt";
            bankData.Data.Tables["Accounts"].Rows.Add(new object[] { urName, accNum, UserID, moneyType, 0, DateTime.Now, false });            
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write("\n\"" + urName + "\",\"" + accNum + "\",\"" + UserID + "\",\"" + moneyType + "\",\"" + 0 + "\",\"" + DateTime.Now + "\"," + "\"False\"");
            }
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
            if (row.Length != 0)
            {
                acc.setAccNum(accNum);
                acc.setMoneyType(Convert.ToString(row[0]["moneyType"]));
                acc.setBalance(Convert.ToDouble(row[0]["balance"]));
                acc.setUserID(Convert.ToInt16(row[0]["UserID"]));
                acc.setCreationTime(Convert.ToDateTime(row[0]["creationTime"]));
                acc.setUrName(Convert.ToString(row[0]["urName"]));
                acc.setIsFreezed(Convert.ToBoolean(row[0]["isFreezed"]));
            }
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
            row[0]["isFreezed"] = acc.getIsFreezed();
            bankData.Data.Tables["Accounts"].AcceptChanges();
        }

        public void addCredit(double amount, double percent, int period, int UserID, bool isApproved, DateTime creationTime, string moneyType)
        {
            int creditNum = 0;
            int i = 1;
            DataRow[] row = bankData.Data.Tables["Credits"].Select();
            while (true)
            {
                bool Check = false;
                for (int j = 0; j < row.Length; j++)
                {
                    if (Convert.ToString(i) == Convert.ToString(row[j]["creditNum"]))
                    {
                        Check = true;
                    }
                }
                if (Check == false)
                {
                    creditNum = i;
                    break;
                }
                i++;
            }
            bankData.Data.Tables["Credits"].Rows.Add(new object[] { creditNum, amount, percent, period, urName, UserID, isApproved, creationTime, moneyType });
        }

        public Credit findCredit(string creditNum, string urName)
        {
            DataRow[] row = bankData.Data.Tables["Credits"].Select(" creditNum = '" + creditNum + "' AND bank = '" + urName + "'");
            Credit credit = new Credit();
            credit.setCreditNum(Convert.ToString(row[0]["creditNum"]));
            credit.setAmount(Convert.ToDouble(row[0]["amount"]));
            credit.setPercent(Convert.ToDouble(row[0]["percent"]));
            credit.setPeriod(Convert.ToInt16(row[0]["period"]));
            credit.setUserID(Convert.ToInt16(row[0]["UserID"]));
            credit.setBank(Convert.ToString(row[0]["bank"]));
            credit.setIsApproved(Convert.ToBoolean(row[0]["isApproved"]));
            credit.setCreationTime(Convert.ToDateTime(row[0]["creationTime"]));
            return credit;
        }

        public void addInstalmentPayment(double amount, double percent, int period, int UserID, bool isApproved, DateTime creationTime)
        {
            int creditNum = 0;
            int i = 1;
            DataRow[] row = bankData.Data.Tables["InstalmentPayments"].Select();
            while (true)
            {
                bool Check = false;
                for (int j = 0; j < row.Length; j++)
                {
                    if (Convert.ToString(i) == Convert.ToString(row[j]["creditNum"]))
                    {
                        Check = true;
                    }
                }
                if (Check == false)
                {
                    creditNum = i;
                    break;
                }
                i++;
            }
            bankData.Data.Tables["InstalmentPayments"].Rows.Add(new object[] { creditNum, amount, percent, period, urName, UserID, isApproved, creationTime });
        }

        public PayByInstalments findInstalmentPayment(string creditNum, string urName)
        {
            DataRow[] row = bankData.Data.Tables["Credits"].Select(" creditNum = '" + creditNum + "' AND bank = '" + urName + "'");
            PayByInstalments instalmentPayment = new PayByInstalments();
            instalmentPayment.setCreditNum(Convert.ToString(row[0]["creditNum"]));
            instalmentPayment.setAmount(Convert.ToDouble(row[0]["amount"]));
            instalmentPayment.setPercent(Convert.ToDouble(row[0]["percent"]));
            instalmentPayment.setPeriod(Convert.ToInt16(row[0]["period"]));
            instalmentPayment.setUserID(Convert.ToInt16(row[0]["UserID"]));
            instalmentPayment.setBank(Convert.ToString(row[0]["bank"]));
            instalmentPayment.setIsApproved(Convert.ToBoolean(row[0]["isApproved"]));
            instalmentPayment.setCreationTime(Convert.ToDateTime(row[0]["creationTime"]));
            return instalmentPayment;
        }
    }
}
