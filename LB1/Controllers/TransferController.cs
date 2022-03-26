using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class TransferController
    {
        Account sender;
        Account receiver;
        Bank bank;
        Client client;
        public TransferController(Account sender, Account receiver, Bank bank, Client client)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.bank = bank;
            this.client = client;
        }

        public void doTransfer(double amount)
        {
            Transfer transfer = new Transfer(sender, receiver, amount, bank, client);
            transfer.doTransfer();
        }

        public void deposit(double amount)
        {
            Transfer transfer = new Transfer(sender, null, amount, null, client);
            transfer.deposit();
        }
    }
}
