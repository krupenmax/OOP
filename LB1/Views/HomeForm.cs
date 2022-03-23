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
    public partial class HomeForm : Form
    {
        ClientController clientController = new ClientController();
        BankController bankController = new BankController();
        AccountForm accForm;
        public HomeForm(string login, string password)
        {
            InitializeComponent();
            clientController.GetClient(login, password);
            clientController.getAccounts();
            bankController.SetBanks(BankBox);
            this.accForm = new AccountForm(this);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            if (BankBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Подтвердите действие", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    accForm.Show();
                }
            }
            else
            {
                WarningLabel.Visible = true;
            }
        }
        public void CreateAcc()
        {
            CreateAccountController createAccController = new CreateAccountController();
            createAccController.CreateAccount(bankController.getBank(BankBox.Text), clientController.ActiveClient.UserID, (accForm.getMoneyType()));
            clientController.addAccToClient(bankController.getBank(BankBox.Text));
        }

        private void AccInfoBtn_Click(object sender, EventArgs e)
        {
            AccInfoForm AccInfoForm = new AccInfoForm(clientController);
            Thread myThread1 = new Thread(AccInfoForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void BankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarningLabel.Visible = false;
        }
    }
}
