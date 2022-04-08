using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LB1
{
    class Transfer : ITransfer
    {
        Account receiver;
        Account sender;
        double amount;
        Bank bank;
        Client client;

        

        public Transfer(Account sender, Account receiver, double amount, Bank bank, Client client)
        {
            this.receiver = receiver;
            this.sender = sender;
            this.amount = amount;
            this.bank = bank;
            this.client = client;
            if (receiver == null)
            {
                getLog += depositLog;
            }
            else
            {
                getLog += transferLog;
            }
            
        }

        public Account getReceiver()
        {
            return receiver;
        }

        public void setReciver(Account receiver)
        {
            this.receiver = receiver;
        }

        public Account getSender()
        {
            return sender;
        }

        public void setSender(Account sender)
        {
            this.sender = sender;
        }

        public double getAmount()
        {
            return amount;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public delegate void log();
        public static event log getLog;

        public void depositLog()
        {
            string path = "../../Models/Docs/TransferLogs.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                if (amount > 0)
                {
                    writer.WriteLine(DateTime.Now + ": " + client.getLogin() + " пополнил счет №" + sender.getAccNum() + " (" + sender.getUrName() + ") на сумму: " + amount + " " + sender.getMoneyType());
                }
                else
                {
                    writer.WriteLine(DateTime.Now + ": " + client.getLogin() + " снял со счета №" + sender.getAccNum() + " (" + sender.getUrName() + ") сумму: " + -1 * amount + " " + sender.getMoneyType());
                }
            }
            getLog -= depositLog;
        }

        public void transferLog()
        {
            string path = "../../Models/Docs/TransferLogs.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(DateTime.Now + ": " + client.getLogin() + " совершил перевод со счета №" + sender.getAccNum() + "(" + sender.getUrName() + ") на счет №" + receiver.getAccNum() + "(" + receiver.getUrName() + ") в размере: " + amount + " " + sender.getMoneyType());
                getLog -= transferLog;
            }
        }

        public void doTransfer()
        {
            if (sender.getUserID() != receiver.getUserID())
            {
                sender.setBalance(sender.getBalance() - amount);
                convertMoney();
                receiver.setBalance(receiver.getBalance() + amount);
                client.overwriteAcc(sender, sender.getAccNum(), sender.getUrName());
                bank.overwriteAcc(receiver, receiver.getAccNum());
                BankController bankController = new BankController();
                bank = bankController.getBank(sender.getUrName());
                bank.overwriteAcc(sender, sender.getAccNum());
            }
            else
            {
                sender.setBalance(sender.getBalance() - amount);
                convertMoney();
                receiver.setBalance(receiver.getBalance() + amount);
                client.overwriteAcc(sender, sender.getAccNum(), sender.getUrName());
                client.overwriteAcc(receiver, receiver.getAccNum(), receiver.getUrName());
                bank.overwriteAcc(receiver, receiver.getAccNum());
                BankController bankController = new BankController();
                bank = bankController.getBank(sender.getUrName());
                bank.overwriteAcc(sender, sender.getAccNum());
            }
            getLog?.Invoke();
        }

        public void deposit()
        {         
            sender.setBalance(sender.getBalance() + amount);
            client.overwriteAcc(sender, sender.getAccNum(), sender.getUrName());
            BankController bankController = new BankController();
            bank = bankController.getBank(sender.getUrName());
            bank.overwriteAcc(sender, sender.getAccNum());
            getLog?.Invoke();
        }

        public void convertMoney()
        {
            double k = 0;
            if (sender.getMoneyType() == "USD")
            {
                switch(receiver.getMoneyType())
                {
                    case "USD":
                        k = 1;
                        break;
                    case "EUR":
                        k = 0.91;
                        break;
                    case "RUB":
                        k = 102;
                        break;
                    case "BYR":
                        k = 3.26;
                        break;
                }
            }

            if (sender.getMoneyType() == "EUR")
            {
                switch (receiver.getMoneyType())
                {
                    case "USD":
                        k = 1.1;
                        break;
                    case "EUR":
                        k = 1;
                        break;
                    case "RUB":
                        k = 112;
                        break;
                    case "BYR":
                        k = 3.58;
                        break;
                }
            }

            if (sender.getMoneyType() == "RUB")
            {
                switch (receiver.getMoneyType())
                {
                    case "USD":
                        k = 0.0098;
                        break;
                    case "EUR":
                        k = 0.0089;
                        break;
                    case "RUB":
                        k = 1;
                        break;
                    case "BYR":
                        k = 0.032;
                        break;
                }
            }

            if (sender.getMoneyType() == "BYR")
            {
                switch (receiver.getMoneyType())
                {
                    case "USD":
                        k = 0.31;
                        break;
                    case "EUR":
                        k = 0.28;
                        break;
                    case "RUB":
                        k = 31.3;
                        break;
                    case "BYR":
                        k = 1;
                        break;
                }
            }
            amount *= k;
        }
    }
}
