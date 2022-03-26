using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class CreditForm : Form
    {
        ClientController clientController;
        BankController bankController = new BankController();
        public CreditForm(ClientController clientController)
        {
            InitializeComponent();
            this.clientController = clientController;
            bankController.SetBanks(bankBox);
            periodBox.Items.Add("3 месяца");
            periodBox.Items.Add("6 месяца");
            periodBox.Items.Add("12 месяца");
            periodBox.Items.Add("24 месяца");
            pickBox.Items.Add("Кредит");
            pickBox.Items.Add("Рассрочка");
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
            bankController.getBank(bankBox.Text).addCredit(Convert.ToDouble(amountBox.Text), getPercent(), getPeriod(), clientController.ActiveClient.getUserId(), false, DateTime.Now);
            clientController.addCreditToClient(bankController.getBank(bankBox.Text));   
        }

        private void periodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            percentBox.Text = Convert.ToString(getPercent());
        }
    }
}
