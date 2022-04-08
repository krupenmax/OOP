using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericParsing;
using System.IO;

namespace LB1
{
    class Operator : User, IOperator
    {
        public Operator login(string login, string password)
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/Operators.txt");
                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;

                while(parser.Read())
                {
                    if(login == parser["login"] && password == parser["password"])
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

        public void getLogs(System.Windows.Forms.ListBox logBox)
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/TransferLogs.txt");
                int i = 0;
                while (parser.Read())
                {
                    i++;
                }

                parser.SetDataSource("../../Models/Docs/TransferLogs.txt");
                string[] logs = new string[i];
                while (parser.Read())
                {
                    logs[i - 1] = Convert.ToString(parser[0]);
                    i--;
                }

                for(i = 0; i < logs.Length; i++)
                {
                    logBox.Items.Add(logs[i]);
                }

                /*parser.SetDataSource("../../Models/Docs/AccountLogs.txt");
                while (parser.Read())
                {
                    string[] logs = { Convert.ToString(parser[0]) };
                    logBox.Items.Insert(i, logs[0]);
                    i++;
                }*/
            }
        }

        public void cancelAction(string log)
        {
            string container = log;
            log = "";
            for (int i = 21; i < container.Length; i++)
            {
                log += container[i];
            }

            string clientName = "";
            int j = 0;
            while (log[j] != ' ')
            {
                clientName += log[j];
                j++;
            }

            string actionDecider = "";
            j++;
            while (log[j] != ' ')
            {
                actionDecider += log[j];
                j++;
            }

            switch (actionDecider)
            {
                case "пополнил":
                    cancelDeposit(log, j, clientName);
                    break;
                case "совершил":

                    break;
            }
        }

        public void cancelDeposit(string log, int j, string clientName)
        {
            j += 7;
            string accNum = "";
            while (log[j] != ' ')
            {
                accNum += log[j];
                j++;
            }

            j += 2;
            string urName = "";
            while (log[j] != ')')
            {
                urName += log[j];
                j++;
            }

            j += 12;
            string amount = "";
            while (log[j] != ' ')
            {
                amount += log[j];
                j++;
            }

            j++;
            string moneyType = "";
            for (int i = 0; i < 3; i++)
            {
                moneyType += log[j];
                j++;
            }
            BankController bankController = new BankController();
            Bank bank = bankController.getBank(urName);

            Account sender = bank.findAcc(accNum);
            string accStr = "\n\"" + sender.getUrName() + "\",\"" + sender.getAccNum() + "\",\"" + Convert.ToString(sender.getUserID()) + "\",\"" + sender.getMoneyType() + "\",\""
            + Convert.ToString(sender.getBalance()) + "\",\"" + Convert.ToString(sender.getCreationTime()) + "\",\"" + Convert.ToString(sender.getIsFreezed()) + "\"";

            string str = "";
            using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
            {
                str = reader.ReadToEnd();
            }

            TransferController transfer = new TransferController(bank.findAcc(accNum), bank.findAcc(accNum), bank, Program.database.FindClient(clientName));
            transfer.deposit(-1 * Convert.ToInt16(amount));

            sender = bank.findAcc(accNum);
            string replaceStr = "\n\"" + sender.getUrName() + "\",\"" + sender.getAccNum() + "\",\"" + Convert.ToString(sender.getUserID()) + "\",\"" + sender.getMoneyType() + "\",\""
            + Convert.ToString(sender.getBalance()) + "\",\"" + Convert.ToString(sender.getCreationTime()) + "\",\"" + Convert.ToString(sender.getIsFreezed()) + "\"";

            str = str.Replace(accStr, replaceStr);
            using (StreamWriter writer = new StreamWriter("../../Models/Docs/Accounts.txt"))
            {
                writer.Write(str);
            }
        }
    }
}
