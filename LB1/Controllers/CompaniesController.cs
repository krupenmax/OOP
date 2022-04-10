using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class CompaniesController
    {
        Database database;
        public CompaniesController()
        {
            database = Program.database;
        }

        public void getCompaniesToBox(System.Windows.Forms.ComboBox comboBox)
        {
            database.getCompaniesToBox(comboBox);
        }

        public Company getCompany(string urName)
        {
            return database.getCompany(urName);
        }

        public SalaryProject getSalaryProject(int ID, string companyName)
        {
            return getCompany(companyName).getSalaryProject(ID);
        }

        public void approveSalaryProject(int ID, string companyName)
        {
            getCompany(companyName).approveSalaryProject(ID);
        }

        public void deleteSalaryProject(int ID, string companyName)
        {
            getCompany(companyName).deleteSalaryProject(ID);
        }
    }
}
