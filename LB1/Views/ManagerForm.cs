using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericParsing;
using System.Threading;

namespace LB1
{
    public partial class ManagerForm : Form
    {
        CreditLoadController creditLoadController = new CreditLoadController();
        OperatorController operatorController = new OperatorController();
        ManagerController managerController = new ManagerController();
        public ManagerForm()
        {
            InitializeComponent();
            creditLoadController.getCreditsToBox(creditBox);
            creditLoadController.getInstalmentToBox(instalmentBox);
            operatorController.getLogs(logBox);
            operatorController.getLogs(logConstBox);
            salaryProjectController.getSalaryFile(salaryBox);
            managerController.getSideSpecialistLogs(sideSpecialistLogBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        SalaryProjectController salaryProjectController = new SalaryProjectController();
        int cancelCount = 0;

        private void creditBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankController bankController = new BankController();
            string creditNum = "";
            string urName = "";
            int i = 0;
            while (creditBox.Text[i] != ',')
            {
                creditNum += creditBox.Text[i];
                i++;
            }
            i += 2;
            while (i < creditBox.Text.Length)
            {
                urName += creditBox.Text[i];
                i++;
            }
            string moneyType = "";
            switch (bankController.findCredit(creditNum, urName).getMoneyType())
            {
                case "USD":
                    moneyType = " $";
                    break;
                case "EUR":
                    moneyType = " €";
                    break;
                case "BYR":
                    moneyType = " BYR";
                    break;
                case "RUB":
                    moneyType = " RUB";
                    break;
            }
            amountCredit.Text = Convert.ToString(bankController.findCredit(creditNum, urName).getAmount()) + moneyType;
            percentCredit.Text = Convert.ToString(bankController.findCredit(creditNum, urName).getPercent());
            periodCredit.Text = Convert.ToString(bankController.findCredit(creditNum, urName).getPeriod());
            userIDCredit.Text = Convert.ToString(bankController.findCredit(creditNum, urName).getUserID ());
            isApprovedCredit.Text = Convert.ToString(bankController.findCredit(creditNum, urName).getIsApproved());
            creationTimeCredit.Text = Convert.ToString(bankController.findCredit(creditNum, urName).getCreationTime());
            moneyTypeCredit.Text = Convert.ToString(bankController.findCredit(creditNum, urName).getMoneyType());
        }

        private void instalmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankController bankController = new BankController();
            string creditNum = "";
            string urName = "";
            int i = 0;
            while (instalmentBox.Text[i] != ',')
            {
                creditNum += instalmentBox.Text[i];
                i++;
            }
            i += 2;
            while (i < instalmentBox.Text.Length)
            {
                urName += instalmentBox.Text[i];
                i++;
            }
            string moneyType = "";
            switch (bankController.findInstalment(creditNum, urName).getMoneyType())
            {
                case "USD":
                    moneyType = " $";
                    break;
                case "EUR":
                    moneyType = " €";
                    break;
                case "BYR":
                    moneyType = " BYR";
                    break;
                case "RUB":
                    moneyType = " RUB";
                    break;
            }
            amountInstalment.Text = Convert.ToString(bankController.findInstalment(creditNum, urName).getAmount()) + moneyType;
            percentInstalment.Text = Convert.ToString(bankController.findInstalment(creditNum, urName).getPercent());
            periodInstalment.Text = Convert.ToString(bankController.findInstalment(creditNum, urName).getPeriod());
            userIDInstalment.Text = Convert.ToString(bankController.findInstalment(creditNum, urName).getUserID());
            isApprovedInstalment.Text = Convert.ToString(bankController.findInstalment(creditNum, urName).getIsApproved());
            creationTimeInstalment.Text = Convert.ToString(bankController.findInstalment(creditNum, urName).getCreationTime());
            moneyTypeInstalment.Text = Convert.ToString(bankController.findInstalment(creditNum, urName).getMoneyType());
        }

        private void approveCredit_Click(object sender, EventArgs e)
        {
            string creditNum = "";
            string urName = "";
            int i = 0;
            while (creditBox.Text[i] != ',')
            {
                creditNum += creditBox.Text[i];
                i++;
            }
            i += 2;
            while (i < creditBox.Text.Length)
            {
                urName += creditBox.Text[i];
                i++;
            }
            BankController bankController = new BankController();
            bankController.approveCredit(creditNum, urName);
        }

        private void approveInstalment_Click(object sender, EventArgs e)
        {
            string creditNum = "";
            string urName = "";
            int i = 0;
            while (instalmentBox.Text[i] != ',')
            {
                creditNum += instalmentBox.Text[i];
                i++;
            }
            i += 2;
            while (i < instalmentBox.Text.Length)
            {
                urName += instalmentBox.Text[i];
                i++;
            }
            BankController bankController = new BankController();
            bankController.approveInstalment(creditNum, urName);
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StartForm StartForm = new StartForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose(); 
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            if (cancelCount == 0)
            {
                operatorController.cancelAction(Convert.ToString(logBox.SelectedItem));
                string deleteStr = Convert.ToString(logBox.SelectedItem);
                string[] container = new string[logBox.Items.Count];
                for (int i = 0; i < logBox.Items.Count; i++)
                {
                    if (Convert.ToString(logBox.Items[i]) != deleteStr)
                    {
                        container[i] = Convert.ToString(logBox.Items[i]);
                    }
                }
                logBox.Items.Clear();
                for (int i = 0; i < container.Length; i++)
                {
                    if (container[i] != null)
                    {
                        logBox.Items.Add(container[i]);
                    }
                }
                cancelCount++;
            }
            else
            {
                MessageBox.Show("Нет доступа отменять транзакции более 1 раза.");
            }
        }

        private void approveBtn_Click_1(object sender, EventArgs e)
        {
            CompaniesController companiesController = new CompaniesController();
            companiesController.deleteSalaryProject(Convert.ToInt16(salaryBox.Text), companyNameBox.Text);
            companiesController.approveSalaryProject(Convert.ToInt16(salaryBox.Text), companyNameBox.Text);
            MessageBox.Show("Заявка одобрена.");
        }

        private void salaryBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(salaryBox.Text);
            companyNameBox.Text = salaryProjectController.getSalaryProject(ID).getCompanyName();
            periodBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getPeriod());
            amountBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getAmount());
            isApprovedBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getIsApproved());
            userIDBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getUserID());
            moneyTypeBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getMoneyType());
        }

        private void cancelSideSpecialistBtn_Click(object sender, EventArgs e)
        {
            string log = Convert.ToString(sideSpecialistLogBox.SelectedItem);
            int count = 21;
            string login = "";
            while (log[count] != ' ')
            {
                login += log[count];
                count++;
            }

        }
    }
}
