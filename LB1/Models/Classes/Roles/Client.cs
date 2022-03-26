using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    public class Client : User
    {
        string passportData;
        string idNumber;
        string phoneNumber;
        string email;
        int UserID;

        TableSet ClientTables = new TableSet();
   
        public Client()
        {
            ClientTables.BuildAccountTable();
        }

        public TableSet getClientTables()
        {
            return ClientTables;
        }

        public void setClientTables(TableSet ClientTables)
        {
            this.ClientTables = ClientTables;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public int getUserId()
        {
            return UserID;
        }

        public void setUserId(int UserID)
        {
            this.UserID = UserID;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public string getIdNumber()
        {
            return idNumber;
        }

        public void setIdNumber(string idNumber)
        {
            this.idNumber = idNumber;
        }

        public string getPassportData()
        {
            return passportData;
        }

        public void setPassportData(string passportData)
        {
            this.passportData = passportData;
        }

        public void getAccounts(Bank bank)
        {
            DataRow[] row = bank.getBankData().Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToInt16(row[i]["UserID"]) == UserID)
                {
                    ClientTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[i]["urName"] , row[i]["accNum"], row[i]["UserID"], row[i]["moneyType"], row[i]["balance"], row[i]["creationTime"] });
                }
            }
        }
        public void deleteAccount(string accNum, string urName)
        {
            DataRow[] row = ClientTables.Data.Tables["Accounts"].Select(" accNum = '" + accNum + "' AND urName = '" + urName + "'");
            row[0].Delete();
            ClientTables.Data.Tables["Accounts"].AcceptChanges();
        }

        public void addAccToClient(Bank bank)
        {
            DataRow[] row = bank.getBankData().Data.Tables["Accounts"].Select();
            ClientTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[row.Length - 1]["urName"], row[row.Length - 1]["accNum"], row[row.Length - 1]["UserID"], row[row.Length - 1]["moneyType"], row[row.Length - 1]["balance"], row[row.Length - 1]["creationTime"] });
        }

        public Account getActiveAcc(string accNum, string urName)
        {
            Account acc = new Account();
            DataRow[] row = ClientTables.Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (accNum == Convert.ToString(row[i]["accNum"]) && urName == Convert.ToString(row[i]["urName"]))
                {
                    acc.setAccNum(Convert.ToString(row[i]["accNum"]));
                    acc.setUserID(Convert.ToInt16(row[i]["UserID"]));
                    acc.setMoneyType(Convert.ToString(row[i]["moneyType"]));
                    acc.setBalance(Convert.ToInt16(row[i]["balance"]));
                    acc.setCreationTime(Convert.ToDateTime(row[i]["creationTime"]));
                    acc.setUrName(Convert.ToString(row[i]["urName"]));
                    break;
                }
            }
            return acc;
        }

        public void overwriteAcc(Account acc, string accNum, string urName)
        {
            DataRow[] row = ClientTables.Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (accNum == Convert.ToString(row[i]["accNum"]) && urName == Convert.ToString(row[i]["urName"]))
                {
                    row[i]["accNum"] = acc.getAccNum();
                    row[i]["userID"] = acc.getUserID();
                    row[i]["moneyType"] = acc.getMoneyType();
                    row[i]["balance"] = acc.getBalance();
                    row[i]["creationTime"] = acc.getCreationTime();
                    ClientTables.Data.Tables["Accounts"].AcceptChanges();
                }
            }
        }
    }
}
