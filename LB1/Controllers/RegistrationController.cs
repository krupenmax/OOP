using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    class RegistrationController
    {
        Database database = Program.database;
        public void Registrate(string login, string password, string firstName, string secondName, string fatherName, string passportData, string idNumber, string phoneNumber, string email)
        {
            DataRow[] row = database.tableSet.Data.Tables["Clients"].Select();
            database.AddClient(row.Length + 1, login, password, firstName, secondName, fatherName, passportData, idNumber, phoneNumber, email);
        }
    }
}
