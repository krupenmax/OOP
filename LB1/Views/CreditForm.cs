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
    public partial class CreditForm : Form
    {
        ClientController clientController;
        BankController bankController = new BankController();
        HomeForm homeForm;
        CreditController creditController;
        InstalmentController instalmentController;

        public CreditForm(ClientController clientController, HomeForm homeForm)
        {
            InitializeComponent();
            this.clientController = clientController;
            creditController = new CreditController(clientController);
            instalmentController = new InstalmentController(clientController);
            bankController.SetBanks(bankBox);
            creditController.getCreditsToBox(InfoBox);
            instalmentController.getInstalmentPaymentsToBox(InstalInfoBox);
            periodBox.Items.Add("3 месяца");
            periodBox.Items.Add("6 месяца");
            periodBox.Items.Add("12 месяца");
            periodBox.Items.Add("24 месяца");
            pickBox.Items.Add("Кредит");
            pickBox.Items.Add("Рассрочка");
            this.homeForm = homeForm;
        }

        public void Open()
        {
            ShowDialog();

        }

        public int getPeriod()
        {
            string period = "";
            int i = 0;
            while(periodBox.Text[i] != ' ')
            {
                period += periodBox.Text[i];
                i++;
            }
            return Convert.ToInt16(period);
        }

        public double getPercent()
        {
            double percent = 0;
            switch(getPeriod())
            {
                case 3:
                    percent = 8;
                    break;
                case 6:
                    percent = 6;
                    break;
                case 12:
                    percent = 5;
                    break;
                case 24:
                    percent = 3;
                    break; 
            }
            return percent;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (pickBox.Text == "Кредит")
            {
                bankController.getBank(bankBox.Text).addCredit(Convert.ToDouble(amountBox.Text), getPercent(), getPeriod(), clientController.ActiveClient.getUserId(), false, DateTime.Now);
                clientController.addCreditToClient(bankController.getBank(bankBox.Text));
                MessageBox.Show("Кредит успешно оформлен");
                InfoBox.Items.Clear();
                creditController.getCreditsToBox(InfoBox);
                amountInfoBox.Text = "";
                percentInfoBox.Text = "";
                periodInfoBox.Text = "";
                creationTimeInfoBox.Text = "";
            }
            else
            {
                bankController.getBank(bankBox.Text).addInstalmentPayment(Convert.ToDouble(amountBox.Text), 0, getPeriod(), clientController.ActiveClient.getUserId(), false, DateTime.Now);
                clientController.addInstalmentPaymentToClient(bankController.getBank(bankBox.Text));
                MessageBox.Show("Рассрочка успешно оформлена ");
                InstalInfoBox.Items.Clear();
                instalmentController.getInstalmentPaymentsToBox(InstalInfoBox);
                amountInfoBox.Text = "";
                percentInfoBox.Text = "";
                periodInfoBox.Text = "";
                creationTimeInfoBox.Text = "";
            }
        }

        private void periodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickBox.Text == "Кредит")
            {
                percentBox.Text = Convert.ToString(getPercent());
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Thread myThread1 = new Thread(homeForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void pickBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickBox.Text == "Рассрочка")
            {
                percentBox.Text = "0";
            }
            else
            {
                if (periodBox.Text != "")
                {
                    percentBox.Text = Convert.ToString(getPercent());
                }
            }
        }

        private void InfoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string creditNum = "";
            string urName = "";
            int i = 0;
            while (InfoBox.Text[i] != ',')
            {
                creditNum += InfoBox.Text[i];
                i++;
            }
            i += 2;
            while (i < InfoBox.Text.Length)
            {
                urName += InfoBox.Text[i];
                i++;
            }
            amountInfoBox.Text = Convert.ToString(creditController.getActiveCredit(creditNum, urName).getAmount());
            percentInfoBox.Text = Convert.ToString(creditController.getActiveCredit(creditNum, urName).getPercent());
            periodInfoBox.Text = Convert.ToString(creditController.getActiveCredit(creditNum, urName).getPeriod());
            creationTimeInfoBox.Text = Convert.ToString(creditController.getActiveCredit(creditNum, urName).getCreationTime());
        }

        private void InstalInfoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string creditNum = "";
            string urName = "";
            int i = 0;
            while (InstalInfoBox.Text[i] != ',')
            {
                creditNum += InstalInfoBox.Text[i];
                i++;
            }
            i += 2;
            while (i < InstalInfoBox.Text.Length)
            {
                urName += InstalInfoBox.Text[i];
                i++;
            }
            amountInfoBox.Text = Convert.ToString(creditController.getActivePayment(creditNum, urName).getAmount());
            percentInfoBox.Text = Convert.ToString(creditController.getActivePayment(creditNum, urName).getPercent());
            periodInfoBox.Text = Convert.ToString(creditController.getActivePayment(creditNum, urName).getPeriod());
            creationTimeInfoBox.Text = Convert.ToString(creditController.getActivePayment(creditNum, urName).getCreationTime());
        }
    }
}
