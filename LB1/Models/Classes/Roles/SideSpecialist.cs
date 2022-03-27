using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class SideSpecialist : Client
    {
        Company myCompany;
        TableSet SideSpecialistTables = new TableSet();

        public SideSpecialist()
        {
            SideSpecialistTables.BuildAccountTable();
        }
        
        public Company getMyCompany()
        {
            return myCompany;
        }

        public void setMyCompany(Company myCompany)
        {
            this.myCompany = myCompany;
        }
    }
}
