using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Credit : ICredit
    {
        string creditNum;
        double amount;
        double percent;
        int period;
        string bank;
        int UserID;
        bool isApproved;
        DateTime creationTime;
        string moneyType;

        public string getMoneyType()
        {
            return moneyType;
        }

        public void setMoneyType(string moneyType)
        {
            this.moneyType = moneyType;
        }

        public DateTime getCreationTime()
        {
            return creationTime;
        }

        public void setCreationTime(DateTime creationTime)
        {
            this.creationTime = creationTime;
        }

        public bool getIsApproved()
        {
            return isApproved;
        }

        public void setIsApproved(bool isApproved)
        {
            this.isApproved = isApproved;
        }

        public string getBank()
        {
            return bank;
        }

        public void setBank(string bank)
        {
            this.bank = bank;
        }

        public int getPeriod()
        {
            return period;
        }

        public void setPeriod(int period)
        {
            this.period = period;
        }

        public double getPercent()
        {
            return percent;
        }

        public void setPercent(double percent)
        {
            this.percent = percent;
        }

        public int getUserID()
        {
            return UserID;
        }

        public void setUserID(int UserID)
        {
            this.UserID = UserID;
        }

        public string getCreditNum()
        {
            return creditNum;
        }

        public void setCreditNum(string creditNum)
        {
            this.creditNum = creditNum;
        }

        public double getAmount()
        {
            return amount;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }
    }
}
