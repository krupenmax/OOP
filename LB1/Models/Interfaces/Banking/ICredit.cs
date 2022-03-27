using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    interface ICredit
    {
        string getCreditNum();
        void setCreditNum(string creditNum);
        double getAmount();
        void setAmount(double amount);
        double getPercent();
        void setPercent(double percent);
        int getPeriod();
        void setPeriod(int period);
        string getBank();
        void setBank(string bank);
        int getUserID();
        void setUserID(int UserID);
        bool getIsApproved();
        void setIsApproved(bool isApproved);
        DateTime getCreationTime();
        void setCreationTime(DateTime creationTime);
    }
}
