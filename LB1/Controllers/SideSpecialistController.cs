using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    public class SideSpecialistController
    {
        Database database = Program.database;
        public SideSpecialist sideSpecialist = new SideSpecialist();
        public void Registrate(string login, string password, string firstName, string secondName, string fatherName, string passportData, string idNumber, string phoneNumber, string email, string myCompany)
        {
            DataRow[] row = database.tableSet.Data.Tables["SideSpecialists"].Select();
            DataRow[] rowClient = database.tableSet.Data.Tables["Clients"].Select();
            database.AddSideSpecialist(row.Length + 1 + rowClient.Length, login, password, firstName, secondName, fatherName, passportData, idNumber, phoneNumber, email, myCompany);
        }

        public void getSideSpecialist(string login, string password)
        {
            sideSpecialist.login(login, password);
        }

        public void addSalaryProject(int ID, int period, double amount, int UserID, string moneyType)
        {
            sideSpecialist.addSalaryProject(ID, period, amount, UserID, moneyType);
        }

        public void getSalaryProjects(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = sideSpecialist.SideSpecialistTables.Data.Tables["SalaryProjects"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(Convert.ToString(row[i]["ID"]));
            }
        }

        public void addAcc(Bank bank)
        {
            sideSpecialist.addAccount(bank);
        }

        public void setAccBox(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = sideSpecialist.SideSpecialistTables.Data.Tables["Accounts"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToInt16(row[i]["UserID"]) == sideSpecialist.getUserId())
                comboBox.Items.Add(row[i]["accNum"] + ", " + row[i]["urName"]);
            }
        }
    }
}
