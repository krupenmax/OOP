using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace LB1
{
    public partial class TransferForm : Form
    {
        ClientController clientController;
        BankController bankController = new BankController();
        AccountInfoController accountInfoController;
        HomeForm homeForm;
        public TransferForm(ClientController clientController, HomeForm homeForm)
        {
            InitializeComponent();
            this.clientController = clientController;
            this.homeForm = homeForm;
            getAccountsToBox();
            bankController.SetBanks(bankBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        public void getAccountsToBox()
        {
            accountInfoController = new AccountInfoController(clientController);
            accountInfoController.setBox(senderBox);
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (senderBox.Text != "" && amountBox.Text != "" && receiverBox.Text != "" && bankBox.Text != "")
            {
                double num = 0.0;
                if (double.TryParse(amountBox.Text, out num) && double.TryParse(receiverBox.Text, out num))
                {
                    string accNum = "";
                    string urName = "";
                    int i = 0;
                    while (senderBox.Text[i] != ',')
                    {
                        accNum += senderBox.Text[i];
                        i++;
                    }
                    i += 2;
                    while (i < senderBox.Text.Length)
                    {
                        urName += senderBox.Text[i];
                        i++;
                    }
                    if (Convert.ToInt32(amountBox.Text) <= accountInfoController.getActiveAccount(accNum, urName).getBalance())
                    {
                        if (bankController.getBank(bankBox.Text).findAcc(Convert.ToString(receiverBox.Text)).getAccNum() != null)
                        {
                            if (bankController.getBank(bankBox.Text).findAcc(Convert.ToString(receiverBox.Text)).getIsFreezed() == false)
                            {
                                if (accountInfoController.getActiveAccount(accNum, urName).getIsFreezed() == false)
                                {
                                    if (receiverBox.Text + ", " + bankBox.Text != senderBox.Text)
                                    {
                                        Account Sender = accountInfoController.getActiveAccount(accNum, urName);
                                        string accStr = "\n\"" + Sender.getUrName() + "\",\"" + Sender.getAccNum() + "\",\"" + Convert.ToString(Sender.getUserID()) + "\",\"" + Sender.getMoneyType() + "\",\""
                                        + Convert.ToString(Sender.getBalance()) + "\",\"" + Convert.ToString(Sender.getCreationTime()) + "\",\"" + Convert.ToString(Sender.getIsFreezed()) + "\"";
                                        string str = "";
                                        using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
                                        {
                                            str = reader.ReadToEnd();
                                        }

                                        Account receiver = bankController.getBank(bankBox.Text).findAcc(Convert.ToString(receiverBox.Text));
                                        string accStr2 = "\n\"" + receiver.getUrName() + "\",\"" + receiver.getAccNum() + "\",\"" + Convert.ToString(receiver.getUserID()) + "\",\"" + receiver.getMoneyType() + "\",\""
                                        + Convert.ToString(receiver.getBalance()) + "\",\"" + Convert.ToString(receiver.getCreationTime()) + "\",\"" + Convert.ToString(receiver.getIsFreezed()) + "\"";

                                        using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
                                        {
                                            str = reader.ReadToEnd();
                                        }

                                        TransferController transferController = new TransferController(accountInfoController.getActiveAccount(accNum, urName),
                                        bankController.getBank(bankBox.Text).findAcc(Convert.ToString(receiverBox.Text)),
                                        bankController.getBank(bankBox.Text),
                                        clientController.ActiveClient);
                                        transferController.doTransfer(Convert.ToDouble(amountBox.Text));

                                        Sender = accountInfoController.getActiveAccount(accNum, urName);
                                        string replaceStr = "\n\"" + Sender.getUrName() + "\",\"" + Sender.getAccNum() + "\",\"" + Convert.ToString(Sender.getUserID()) + "\",\"" + Sender.getMoneyType() + "\",\""
                                        + Convert.ToString(Sender.getBalance()) + "\",\"" + Convert.ToString(Sender.getCreationTime()) + "\",\"" + Convert.ToString(Sender.getIsFreezed()) + "\"";

                                        receiver = bankController.getBank(bankBox.Text).findAcc(Convert.ToString(receiverBox.Text));
                                        string replaceStr2 = "\n\"" + receiver.getUrName() + "\",\"" + receiver.getAccNum() + "\",\"" + Convert.ToString(receiver.getUserID()) + "\",\"" + receiver.getMoneyType() + "\",\""
                                        + Convert.ToString(receiver.getBalance()) + "\",\"" + Convert.ToString(receiver.getCreationTime()) + "\",\"" + Convert.ToString(receiver.getIsFreezed()) + "\"";

                                        str = str.Replace(accStr, replaceStr);
                                        str = str.Replace(accStr2, replaceStr2);
                                        using (StreamWriter writer = new StreamWriter("../../Models/Docs/Accounts.txt"))
                                        {
                                            writer.Write(str);
                                        }

                                        MessageBox.Show("Перевод выполнен успешно.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Невозможно совершить перевод с одного счета на тот же.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Счет отправителя заморожен.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Счет получателя заморожен");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Такого счета не существует.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств");
                    }

                }
                else
                {
                    MessageBox.Show("Пожайлуста, используйте только цифры для ввода.");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Thread myThread1 = new Thread(homeForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }
    }
}
