using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Account
    {
        string accNum;
        int UserID;
        string moneyType;
        double balance;
        DateTime creationTime;
        string urName;
        bool isFreezed;

        public bool getIsFreezed()
        {
            return isFreezed;
        }

        public void setIsFreezed(bool isFreezed)
        {
            this.isFreezed = isFreezed;
        }

        public string getUrName()
        {
            return urName;
        }

        public void setUrName(string urName)
        {
            this.urName = urName;
        }

        public DateTime getCreationTime()
        {
            return creationTime;
        }

        public void setCreationTime(DateTime creationTime)
        {
            this.creationTime = creationTime;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public string getMoneyType()
        {
            return moneyType;
        }

        public void setMoneyType(string moneyType)
        {
            this.moneyType = moneyType;
        }

        public string getAccNum()
        {
            return accNum;
        }

        public void setAccNum(string accNum)
        {
            this.accNum = accNum;
        }

        public int getUserID()
        {
            return UserID;
        }

        public void setUserID(int UserID)
        {
            this.UserID = UserID;
        }


    }
}
