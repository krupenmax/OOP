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
                parser.SetDataSource("../../Models/Docs/Accounts.txt");

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

                parser.SetDataSource("../../Models/Docs/Credits.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (Convert.ToString(parser["urName"]) == urName)
                    {
                        bankData.Data.Tables["Credits"].Rows.Add(new object[] { parser["creditNum"], parser["amount"], parser["percent"], parser["period"], parser["urName"], parser["UserID"], parser["isApproved"], parser["creationTime"], parser["moneyType"] });

                    }
                }

                parser.SetDataSource("../../Models/Docs/InstalmentPayments.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (Convert.ToString(parser["urName"]) == urName)
                    {
                        bankData.Data.Tables["InstalmentPayments"].Rows.Add(new object[] { parser["creditNum"], parser["amount"], parser["percent"], parser["period"], parser["urName"], parser["UserID"], parser["isApproved"], parser["creationTime"], parser["moneyType"] });
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
            string path = "../../Models/Docs/Accounts.txt";
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
            bankData.Data.Tables["Credits"].Rows.Add(new object[] { creditNum, amount, percent, period, urName, UserID + 1, isApproved, creationTime, moneyType });

            string path = "../../Models/Docs/Credits.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("\"" + Convert.ToString(creditNum) + "\",\"" + Convert.ToString(amount) + "\",\"" + Convert.ToString(percent) + "\",\"" + Convert.ToString(period) + "\",\"" + urName + "\",\"" + Convert.ToString(UserID + 1)
                    + "\",\"" + Convert.ToString(isApproved) + "\",\"" + Convert.ToString(creationTime) + "\",\"" + moneyType + "\"");
            }
        }

        public void getCredits(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = bankData.Data.Tables["Credits"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToBoolean(row[i]["isApproved"]) == false)
                {
                    comboBox.Items.Add(row[i]["creditNum"] + ", " + row[i]["urName"]);
                }
            }
        }

        public void getInstalments(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = bankData.Data.Tables["InstalmentPayments"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToBoolean(row[i]["isApproved"]) == false)
                {
                    comboBox.Items.Add(row[i]["creditNum"] + ", " + row[i]["urName"]);
                }
            }
        }

        public Credit findCredit(string creditNum)
        {
            Credit credit = new Credit();
            DataRow[] row = bankData.Data.Tables["Credits"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (creditNum == Convert.ToString(row[i]["creditNum"]))
                {
                    credit.setCreditNum(Convert.ToString(row[i]["creditNum"]));
                    credit.setAmount(Convert.ToDouble(row[i]["amount"]));
                    credit.setPercent(Convert.ToDouble(row[i]["percent"]));
                    credit.setPeriod(Convert.ToInt16(row[i]["period"]));
                    credit.setUserID(Convert.ToInt16(row[i]["UserID"]));
                    credit.setBank(Convert.ToString(row[i]["urName"]));
                    credit.setIsApproved(Convert.ToBoolean(row[i]["isApproved"]));
                    credit.setCreationTime(Convert.ToDateTime(row[i]["creationTime"]));
                    credit.setMoneyType(Convert.ToString(row[i]["moneyType"]));
                }
            }

            return credit;
        }

        public void approveCredit(string creditNum)
        {
            string replaceStr = "";
            string newStr = "";
            DataRow[] row = bankData.Data.Tables["Credits"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["creditNum"]) == creditNum)
                {
                    replaceStr = "\"" + row[i]["creditNum"] + "\",\"" + row[i]["amount"] + "\",\"" + row[i]["percent"] + "\",\"" + row[i]["period"] + "\",\"" + row[i]["urName"] + "\",\"" + row[i]["UserID"] + "\",\"" + row[i]["isApproved"] + "\",\"" + row[i]["creationTime"] + "\",\"" + row[i]["moneyType"] + "\"";
                    row[i]["isApproved"] = "True";
                    newStr = "\"" + row[i]["creditNum"] + "\",\"" + row[i]["amount"] + "\",\"" + row[i]["percent"] + "\",\"" + row[i]["period"] + "\",\"" + row[i]["urName"] + "\",\"" + row[i]["UserID"] + "\",\"" + row[i]["isApproved"] + "\",\"" + row[i]["creationTime"] + "\",\"" + row[i]["moneyType"] + "\"";
                }
            }

            string path = "../../Models/Docs/Credits.txt";
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                str = reader.ReadToEnd();
            }

            str = str.Replace(replaceStr, newStr);

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(str);
            }
             
        }

        public void approveInstalment(string creditNum)
        {
            string replaceStr = "";
            string newStr = "";
            DataRow[] row = bankData.Data.Tables["InstalmentPayments"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["creditNum"]) == creditNum)
                {
                    replaceStr = "\"" + row[i]["creditNum"] + "\",\"" + row[i]["amount"] + "\",\"" + row[i]["percent"] + "\",\"" + row[i]["period"] + "\",\"" + row[i]["urName"] + "\",\"" + row[i]["UserID"] + "\",\"" + row[i]["isApproved"] + "\",\"" + row[i]["creationTime"] + "\",\"" + row[i]["moneyType"] + "\"";
                    row[i]["isApproved"] = "True";
                    newStr = "\"" + row[i]["creditNum"] + "\",\"" + row[i]["amount"] + "\",\"" + row[i]["percent"] + "\",\"" + row[i]["period"] + "\",\"" + row[i]["urName"] + "\",\"" + row[i]["UserID"] + "\",\"" + row[i]["isApproved"] + "\",\"" + row[i]["creationTime"] + "\",\"" + row[i]["moneyType"] + "\"";
                }
            }

            string path = "../../Models/Docs/InstalmentPayments.txt";
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                str = reader.ReadToEnd();
            }

            str = str.Replace(replaceStr, newStr);

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(str);
            }

        }

        public PayByInstalments findInstalment(string creditNum)
        {
            PayByInstalments payByInstalments = new PayByInstalments();
            DataRow[] row = bankData.Data.Tables["InstalmentPayments"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (creditNum == Convert.ToString(row[i]["creditNum"]))
                {
                    payByInstalments.setCreditNum(Convert.ToString(row[i]["creditNum"]));
                    payByInstalments.setAmount(Convert.ToDouble(row[i]["amount"]));
                    payByInstalments.setPercent(Convert.ToDouble(row[i]["percent"]));
                    payByInstalments.setPeriod(Convert.ToInt16(row[i]["period"]));
                    payByInstalments.setUserID(Convert.ToInt16(row[i]["UserID"]));
                    payByInstalments.setBank(Convert.ToString(row[i]["urName"]));
                    payByInstalments.setIsApproved(Convert.ToBoolean(row[i]["isApproved"]));
                    payByInstalments.setCreationTime(Convert.ToDateTime(row[i]["creationTime"]));
                    payByInstalments.setMoneyType(Convert.ToString(row[i]["moneyType"]));
                }
            }

            return payByInstalments;
        }

        public void addInstalmentPayment(double amount, double percent, int period, int UserID, bool isApproved, DateTime creationTime, string moneyType)
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
            bankData.Data.Tables["InstalmentPayments"].Rows.Add(new object[] { creditNum, amount, percent, period, urName, UserID + 1, isApproved, creationTime, moneyType });

            string path = "../../Models/Docs/InstalmentPayments.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("\"" + Convert.ToString(creditNum) + "\",\"" + Convert.ToString(amount) + "\",\"" + Convert.ToString(percent) + "\",\"" + Convert.ToString(period) + "\",\"" + urName + "\",\"" + Convert.ToString(UserID + 1)
                    + "\",\"" + Convert.ToString(isApproved) + "\",\"" + Convert.ToString(creationTime) + "\",\"" + moneyType + "\"");
            }
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
