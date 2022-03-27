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
            clientController.getCredits();
            clientController.getInstalmentPayments();
            bankController.SetBanks(BankBox);
            clientController.getSalaryProjects();
            BankBox.DropDownStyle = ComboBoxStyle.DropDownList;       
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
                accForm = new AccountForm(this);
                accForm.ShowDialog();            
            }
            else
            {
                WarningLabel.Visible = true;
            }
        }
        public void CreateAcc()
        {
            CreateAccountController createAccController = new CreateAccountController();
            createAccController.CreateAccount(bankController.getBank(BankBox.Text), clientController.ActiveClient.getUserId(), (accForm.getMoneyType()));
            clientController.addAccToClient(bankController.getBank(BankBox.Text));
            MessageBox.Show("Счет создан");
        }

        private void AccInfoBtn_Click(object sender, EventArgs e)
        {
            AccInfoForm AccInfoForm = new AccInfoForm(clientController, this);
            Thread myThread1 = new Thread(AccInfoForm.Open);
            myThread1.Start();
            this.Hide();
        }

        private void BankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarningLabel.Visible = false;
        }

        private void TranserBtn_Click(object sender, EventArgs e)
        {
            TransferForm TransferForm = new TransferForm(clientController, this);
            Thread myThread1 = new Thread(TransferForm.Open);
            myThread1.Start();
            this.Hide();
        }

        private void CreditsPibBtn_Click(object sender, EventArgs e)
        {
            CreditForm CreditForm = new CreditForm(clientController, this);
            Thread myThread1 = new Thread(CreditForm.Open);
            myThread1.Start();
            this.Hide();
        }

        private void SalaryProjectBtn_Click(object sender, EventArgs e)
        {
            SalaryProjectForm SalaryProjectForm = new SalaryProjectForm(clientController, this);
            Thread myThread1 = new Thread(SalaryProjectForm.Open);
            myThread1.Start();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm StartForm = new StartForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }
    }
}
