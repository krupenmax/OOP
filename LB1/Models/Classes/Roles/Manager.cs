using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericParsing;
using System.IO;

namespace LB1
{
    class Manager : Operator
    {
        public Manager Login(string login, string password)
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/Managers.txt");
                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;

                while (parser.Read())
                {
                    if (login == parser["login"] && password == parser["password"])
                    {
                        this.setLogin(login);
                        this.setPassword(password);
                        this.setFirstName(parser["firstName"]);
                        this.setSecondName(parser["secondName"]);
                        this.setFatherName(parser["fatherName"]);
                    }
                }
            }

            return this;
        }

        public void getSideSpecialistLogs(System.Windows.Forms.ListBox listBox)
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialistLogs.txt");
                int i = 0;
                while (parser.Read())
                {
                    i++;
                }

                parser.SetDataSource("../../Models/Docs/SideSpecialistLogs.txt");
                string[] logs = new string[i];
                while (parser.Read())
                {
                    logs[i - 1] = Convert.ToString(parser[0]);
                    i--;
                }

                for (i = 0; i < logs.Length; i++)
                {
                    listBox.Items.Add(logs[i]);
                }
            }
        }
    }
}
