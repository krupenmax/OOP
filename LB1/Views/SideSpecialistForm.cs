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
    public partial class SideSpecialistForm : Form
    {
        SideSpecialistController sideSpecialistController;
        SalaryProjectController salaryProjectController = new SalaryProjectController();
        BankController bankController = new BankController();
        public SideSpecialistForm(SideSpecialistController sideSpecialistController)
        {
            InitializeComponent();
            this.sideSpecialistController = sideSpecialistController;
            salaryProjectController.getSalaryProjects(idSlrBox, sideSpecialistController.sideSpecialist);
            bankController.SetBanks(bankBox);
            bankController.SetBanks(bankBox2);
            moneyTypeAccBox.Items.Add("USD");
            moneyTypeAccBox.Items.Add("EUR");
            moneyTypeAccBox.Items.Add("BYR");
            moneyTypeAccBox.Items.Add("RUB");
            sideSpecialistController.setAccBox(senderBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm StartForm = new StartForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void idSlrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompaniesController companiesController = new CompaniesController();
            int id = Convert.ToInt16(idSlrBox.Text);
            companyBox.Text = Convert.ToString(companiesController.getSalaryProject(id, sideSpecialistController.sideSpecialist.getMyCompany().getUrName()).getCompanyName());
            periodBox.Text = Convert.ToString(companiesController.getSalaryProject(id, sideSpecialistController.sideSpecialist.getMyCompany().getUrName()).getPeriod());
            amountBox.Text = Convert.ToString(companiesController.getSalaryProject(id, sideSpecialistController.sideSpecialist.getMyCompany().getUrName()).getAmount());
            isApprovedBox.Text = Convert.ToString(companiesController.getSalaryProject(id, sideSpecialistController.sideSpecialist.getMyCompany().getUrName()).getIsApproved());
            userIDBox.Text = Convert.ToString(companiesController.getSalaryProject(id, sideSpecialistController.sideSpecialist.getMyCompany().getUrName()).getUserID());
            moneyTypeBox.Text = Convert.ToString(companiesController.getSalaryProject(id, sideSpecialistController.sideSpecialist.getMyCompany().getUrName()).getMoneyType());


            if (isApprovedBox.Text == "True")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideSpecialistController.addSalaryProject(Convert.ToInt16(idSlrBox.Text), Convert.ToInt16(periodBox.Text), Convert.ToDouble(amountBox.Text), Convert.ToInt16(userIDBox.Text), moneyTypeBox.Text);
            MessageBox.Show("Заявка отправлена.");
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            CreateAccountController createAccController = new CreateAccountController();
            createAccController.CreateAccount(bankController.getBank(bankBox.Text), sideSpecialistController.sideSpecialist.getUserId() - 1 , moneyTypeAccBox.Text);
            sideSpecialistController.addAcc(bankController.getBank(bankBox.Text));
            MessageBox.Show("Счет создан");
        }


        public delegate void transferLog(string accNum, string urName);
        public static event transferLog getTransferLog;

        public void getTransferLogs(string accNum, string urName)
        {
            using (StreamWriter writer = new StreamWriter("../../Models/Docs/SideSpecialistLogs.txt", true))
            {
                writer.WriteLine(DateTime.Now + ": " + sideSpecialistController.sideSpecialist.getLogin() + " запросил перевод со счета №" + accNum + "(" + urName + ")" + " на счет №" + receiverBox.Text + "(" + bankBox2.Text + ")" + " на сумму: " + amountTransfer.Text);
            }
        }

        private void TransferBtn_Click(object sender, EventArgs e)
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
            string str = DateTime.Now + ": " + sideSpecialistController.sideSpecialist.getLogin() + " запросил перевод со счета №" + accNum + "(" + urName + ")" + " на счет №" + receiverBox.Text + "(" + bankBox2.Text + ")" + " на сумму: " + amountTransfer.Text;
            using (StreamWriter writer = new StreamWriter("../../Models//Docs/SideSpecialistLogs.txt", true))
            {
                writer.WriteLine(str);
            }

            getTransferLog += getTransferLogs;
            getTransferLog?.Invoke(accNum, urName);
            getTransferLog -= getTransferLogs;
            MessageBox.Show("Заявка отправлена.");
        }
    }
}
