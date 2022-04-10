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
    public partial class  OperatorForm : Form
    {
        OperatorController operatorController = new OperatorController();
        SalaryProjectController salaryProjectController = new SalaryProjectController();
        int cancelCount = 0;
        public OperatorForm()
        {
            InitializeComponent();
            operatorController.getLogs(logBox);
            operatorController.getLogs(logConstBox);
            salaryProjectController.getSalaryFile(salaryBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm StartForm = new StartForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void salaryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(salaryBox.Text);
            companyNameBox.Text = salaryProjectController.getSalaryProject(ID).getCompanyName();
            periodBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getPeriod());
            amountBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getAmount());
            isApprovedBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getIsApproved());
            userIDBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getUserID());
            moneyTypeBox.Text = Convert.ToString(salaryProjectController.getSalaryProject(ID).getMoneyType());
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            CompaniesController companiesController = new CompaniesController();
            companiesController.deleteSalaryProject(Convert.ToInt16(salaryBox.Text), companyNameBox.Text);
            companiesController.approveSalaryProject(Convert.ToInt16(salaryBox.Text), companyNameBox.Text);
            MessageBox.Show("Заявка одобрена.");
        }
    }
}
