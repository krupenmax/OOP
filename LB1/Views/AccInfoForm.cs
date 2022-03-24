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
    public partial class AccInfoForm : Form
    {
        ClientController clientController;
        HomeForm homeForm;
        AccountInfoController accountInfoController;
        public AccInfoForm(ClientController clientController, HomeForm homeForm)
        {
            InitializeComponent();
            this.clientController = clientController;
            getAccountsToBox();
            this.homeForm = homeForm;
        }
        public void Open()
        {
            ShowDialog();
        }

        public void getAccountsToBox()
        {
            accountInfoController = new AccountInfoController(clientController);
            accountInfoController.setBox(accBox);
        }

        private void AccInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Thread myThread1 = new Thread(homeForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void accBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountInfoController = new AccountInfoController(clientController);
            string accNum = "";
            string urName = "";
            int i = 0;
            while (accBox.Text[i] != ',')
            {
                accNum += accBox.Text[i];
                i++;
            }
            i += 2;
            while (i < accBox.Text.Length)
            {
                urName += accBox.Text[i];
                i++;
            }
            balanceBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).balance);
            dataCreationBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).creationTime);
            moneyTypeBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).moneyType);
            switch (moneyTypeBox.Text)
            {
                case "USD":
                    balanceBox.Text += " $";
                    break;
                case "EUR":
                    balanceBox.Text += " €";
                    break;
                case "BYR":
                    balanceBox.Text += " BYR";
                    break;
                case "RUB":
                    balanceBox.Text += " RUB";
                    break;
            }
        }
    }
}
