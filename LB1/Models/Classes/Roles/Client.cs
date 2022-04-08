using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

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
            ClientTables.BuildCreditTable();
            ClientTables.BuildInstalmentPayTable();
            ClientTables.BuildSalaryProjectTable();
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
                if (Convert.ToInt16(row[i]["UserID"]) == UserID + 1)
                {
                    ClientTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[i]["urName"] , row[i]["accNum"], row[i]["UserID"], row[i]["moneyType"], row[i]["balance"], row[i]["creationTime"], row[i]["isFreezed"] });
                }
            }
        }

        public void getCredits(Bank bank)
        {
            DataRow[] row = bank.getBankData().Data.Tables["Credits"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToInt16(row[i]["UserID"]) == UserID)
                {
                    ClientTables.Data.Tables["Credits"].Rows.Add(new object[] { row[i]["creditNum"], row[i]["amount"], row[i]["percent"], row[i]["period"], bank.getUrName(), UserID, row[i]["isApproved"], row[i]["creationTime"], row[i]["moneyType"] });
                }
            }
        }

        public void getInstalmentPayments(Bank bank)
        {
            DataRow[] row = bank.getBankData().Data.Tables["InstalmentPayments"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToInt16(row[i]["UserID"]) == UserID)
                {
                    ClientTables.Data.Tables["InstalmentPayments"].Rows.Add(new object[] { row[i]["creditNum"], row[i]["amount"], row[i]["percent"], row[i]["period"], bank.getUrName(), UserID, row[i]["isApproved"], row[i]["creationTime"], row[i]["moneyType"] });
                }
            }
        }

        public void getSalaryProjects(Company company)
        {
            DataRow[] row = company.getCompanyTables().Data.Tables["SalaryProjects"].Select();
            for (int i = 0; i < row.Length; i++)
            {

                ClientTables.Data.Tables["SalaryProjects"].Rows.Add(new object[] { row[i]["ID"], row[i]["companyName"], row[i]["period"], row[i]["amount"], row[i]["isApproved"], row[i]["UserID"]});
            }
            
        }

        public void deleteAccount(string accNum, string urName)
        {
            DataRow[] row = ClientTables.Data.Tables["Accounts"].Select(" accNum = '" + accNum + "' AND urName = '" + urName + "'");
            row[0].Delete();
            ClientTables.Data.Tables["Accounts"].AcceptChanges();
        }

        public delegate void log(Bank bank, string accNum);
        public static event log getLog;

        public void accLog(Bank bank, string accNum)
        {
            string path = "../../Models/Docs/AccountLogs.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(getLogin() + " создал счет в банке " + bank.getUrName() + " под номером: №" + accNum);
            }
        }

        public void addAccToClient(Bank bank)
        {           
            DataRow[] row = bank.getBankData().Data.Tables["Accounts"].Select();
            ClientTables.Data.Tables["Accounts"].Rows.Add(new object[] { row[row.Length - 1]["urName"], row[row.Length - 1]["accNum"], row[row.Length - 1]["UserID"], row[row.Length - 1]["moneyType"], row[row.Length - 1]["balance"], row[row.Length - 1]["creationTime"], row[row.Length - 1]["isFreezed"] });
            getLog += accLog;
            getLog?.Invoke(bank, Convert.ToString(row[row.Length - 1]["accNum"]));
            getLog -= accLog;
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
                    acc.setIsFreezed(Convert.ToBoolean(row[i]["isFreezed"]));
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
                    row[i]["isFreezed"] = acc.getIsFreezed();
                    ClientTables.Data.Tables["Accounts"].AcceptChanges();
                }
            }
        }

        public void addCreditToClient(Bank bank)
        {
            DataRow[] row = bank.getBankData().Data.Tables["Credits"].Select();
            ClientTables.Data.Tables["Credits"].Rows.Add(new object[] { row[row.Length - 1]["creditNum"], row[row.Length - 1]["amount"], row[row.Length - 1]["percent"], row[row.Length - 1]["period"], bank.getUrName(),row[row.Length - 1]["UserID"], row[row.Length - 1]["isApproved"], row[row.Length - 1]["creationTime"], row[row.Length - 1]["moneyType"] });
        }

        public void addInstalmentPaymentToClient(Bank bank)
        {
            DataRow[] row = bank.getBankData().Data.Tables["InstalmentPayments"].Select();
            ClientTables.Data.Tables["InstalmentPayments"].Rows.Add(new object[] { row[row.Length - 1]["creditNum"], row[row.Length - 1]["amount"], row[row.Length - 1]["percent"], row[row.Length - 1]["period"], bank.getUrName(), row[row.Length - 1]["UserID"], row[row.Length - 1]["isApproved"], row[row.Length - 1]["creationTime"], row[row.Length - 1]["moneyType"] });
        }

        public void addSalaryProject(Company company)
        {
            DataRow[] row = company.getCompanyTables().Data.Tables["SalaryProjects"].Select();
            ClientTables.Data.Tables["SalaryProjects"].Rows.Add(new object[] { row[row.Length - 1]["ID"], row[row.Length - 1]["companyName"], row[row.Length - 1]["period"], row[row.Length - 1]["amount"], row[row.Length - 1]["isApproved"], row[row.Length - 1]["UserID"] });
        }

        public Credit getActiveCredit(string creditNum, string urName)
        {
            Credit credit = new Credit();
            DataRow[] row = ClientTables.Data.Tables["Credits"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (creditNum == Convert.ToString(row[i]["creditNum"]) && urName == Convert.ToString(row[i]["urName"]))
                {
                    credit.setCreditNum(Convert.ToString(row[i]["creditNum"]));
                    credit.setAmount(Convert.ToInt16(row[i]["amount"]));
                    credit.setPercent(Convert.ToDouble(row[i]["percent"]));
                    credit.setUserID(Convert.ToInt16(row[i]["UserID"]));
                    credit.setCreationTime(Convert.ToDateTime(row[i]["creationTime"]));
                    credit.setPeriod(Convert.ToInt16(row[i]["period"]));
                    credit.setIsApproved(Convert.ToBoolean(row[i]["isApproved"]));
                    credit.setMoneyType(Convert.ToString(row[i]["moneyType"]));
                    break;
                }
            }
            return credit;
        }

        public PayByInstalments getActivePayment(string creditNum, string urName)
        {
            PayByInstalments payByInstalments = new PayByInstalments();
            DataRow[] row = ClientTables.Data.Tables["InstalmentPayments"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (creditNum == Convert.ToString(row[i]["creditNum"]) && urName == Convert.ToString(row[i]["urName"]))
                {
                    payByInstalments.setCreditNum(Convert.ToString(row[i]["creditNum"]));
                    payByInstalments.setAmount(Convert.ToInt16(row[i]["amount"]));
                    payByInstalments.setPercent(Convert.ToDouble(row[i]["percent"]));
                    payByInstalments.setUserID(Convert.ToInt16(row[i]["UserID"]));
                    payByInstalments.setCreationTime(Convert.ToDateTime(row[i]["creationTime"]));
                    payByInstalments.setPeriod(Convert.ToInt16(row[i]["period"]));
                    payByInstalments.setIsApproved(Convert.ToBoolean(row[i]["isApproved"]));
                    payByInstalments.setMoneyType(Convert.ToString(row[i]["moneyType"]));
                    break;
                }
            }
            return payByInstalments;
        }
    }
}
