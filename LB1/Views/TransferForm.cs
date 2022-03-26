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
                if (double.TryParse(amountBox.Text, out num))
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

                    TransferController transferController = new TransferController(accountInfoController.getActiveAccount(accNum, urName),
                        bankController.getBank(bankBox.Text).findAcc(Convert.ToString(receiverBox.Text)),
                        bankController.getBank(bankBox.Text),
                        clientController.ActiveClient);

                    transferController.doTransfer(Convert.ToDouble(amountBox.Text));
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
