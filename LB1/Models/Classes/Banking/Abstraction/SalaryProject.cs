using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class SalaryProject
    {
        int ID;
        string companyName;
        int period;
        double amount;
        bool isApproved;
        int UserID;
        string moneyType;

        public string getMoneyType()
        {
            return moneyType;
        }

        public void setMoneyType(string moneyType)
        {
            this.moneyType = moneyType;
        }

        public int getUserID()
        {
            return UserID;
        }

        public void setUserID(int UserID)
        {
            this.UserID = UserID;
        }

        public bool getIsApproved()
        {
            return isApproved;
        }

        public void setIsApproved(bool isApproved)
        {
            this.isApproved = isApproved;
        }

        public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getCompanyName()
        {
            return companyName;
        }

        public void setCompanyName(string companyName)
        {
            this.companyName = companyName;
        }

        public int getPeriod()
        {
            return period;
        }

        public void setPeriod(int period)
        {
            this.period = period;
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

