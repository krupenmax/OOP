using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericParsing;
using System.IO;
using System.Data;

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
        public void cancelAction(System.Windows.Forms.ListBox listBox)
        {
            string log = Convert.ToString(listBox.SelectedItem);
            int count = 21;
            string login = "";
            while (log[count] != ' ')
            {
                login += log[count];
                count++;
            }
            count++;

            string actionDecider = "";
            while (log[count] != ' ')
            {
                actionDecider += log[count];
                count++;
            }
            count++;

            switch (actionDecider)
            {
                case "создал":
                    cancelAcc();
                    break;
                case "запросил":
                    cancelTransfer(log);
                    break;
                case "подал":
                    cancelSalaryProject(log, login);
                    break;
            }

            listBox.Items.Clear();
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialistLogs.txt");
                int counter = 0;
                while (parser.Read())
                {
                    counter++;
                }

                string[] str = new string[counter];
                parser.SetDataSource("../../Models/Docs/SideSpecialistLogs.txt");
                counter = 0;
                while (parser.Read())
                {
                    str[counter] = parser[0];
                    counter++;
                }

                for(int i = counter - 1; i >= 0; i--)
                {
                    listBox.Items.Add(str[i]);
                }
            }
        }

        public void cancelAcc()
        {

        }

        public void cancelTransfer(string log)
        {
            int size = 0;
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialistLogs.txt");
                while (parser.Read())
                {
                    size++;
                }
            }
            string[] str = new string[size - 1]; ;

            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialistLogs.txt");
                int i = 0;
                while (parser.Read())
                {
                    if (Convert.ToString(parser[0]) != log)
                    {
                        str[i] = parser[0];
                        i++;
                    }
         
                }
            }

            using (StreamWriter writer = new StreamWriter("../../Models/Docs/SideSpecialistLogs.txt", false))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    writer.WriteLine(str[i]);
                }
            }
        }

        public void cancelSalaryProject(string log, string login)
        {
            string salaryID = "";
            int count = 0;
            while (log[count] != '№')
            {
                count++;
            }
            count++;
            
            for (int i = count; i < log.Length; i++)
            {
                salaryID += log[i];
            }

            SideSpecialist sideSpecialist = Program.database.FindSideSpecialist(login);
            sideSpecialist.loadData();

            DataRow[] row = sideSpecialist.SideSpecialistTables.Data.Tables["SalaryProjects"].Select();
            string replaceStr = "";
            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToString(row[i]["ID"]) == salaryID)
                {
                    replaceStr = "\"" + row[i]["ID"] + "\",\"" + row[i]["companyName"] + "\",\"" + row[i]["period"] + "\",\"" + row[i]["amount"] + "\",\"" + row[i]["isApproved"] + "\",\"" + row[i]["UserID"] + "\",\"" + row[i]["moneyType"] + "\"";
                    row[i].Delete();
                    sideSpecialist.SideSpecialistTables.Data.Tables["SalaryProjects"].AcceptChanges();
                    break;
                }
            }

            string path = "../../Models/Docs/SideSpecialistSlrPrjcts.txt";
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                str = reader.ReadToEnd();
            }

            str = str.Replace(replaceStr, "");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(str);
            }

            path = "../../Models/Docs/SideSpecialistLogs.txt";
            str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                str = reader.ReadToEnd();
            }

            str = str.Replace(replaceStr, "");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(str);
            }
        }
    }
}
