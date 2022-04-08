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
    public partial class SalaryProjectForm : Form
    {
        ClientController clientController;
        HomeForm homeForm;
        CompaniesController companiesController = new CompaniesController();

        public SalaryProjectForm(ClientController clientController, HomeForm homeForm)
        {
            InitializeComponent();
            this.clientController = clientController;
            this.homeForm = homeForm;
            companiesController.getCompaniesToBox(companyBox);
            periodBox.Items.Add("3 месяца");
            periodBox.Items.Add("6 месяцев");
            periodBox.Items.Add("12 месяцев");
            periodBox.Items.Add("24 месяца");
            moneyTypeBox.Items.Add("USD");
            moneyTypeBox.Items.Add("EUR");
            moneyTypeBox.Items.Add("BYR");
            moneyTypeBox.Items.Add("RUB");

        }

        public void Open()
        {
            ShowDialog();
        }

        public int getPeriod()
        {
            string period = "";
            int i = 0;
            while (periodBox.Text[i] != ' ')
            {
                period += periodBox.Text[i];
                i++;
            }
            return Convert.ToInt16(period);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Thread myThread1 = new Thread(homeForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (companyBox.Text != "" && amountBox.Text != "" && periodBox.Text != "")
            {
                double num = 0.0;
                if (Double.TryParse(amountBox.Text, out num))
                {
                    companiesController.getCompany(companyBox.Text).addSalaryProject(getPeriod(), Convert.ToDouble(amountBox.Text), clientController.ActiveClient.getUserId(), moneyTypeBox.Text);
                    clientController.addSalaryProject(companiesController.getCompany(companyBox.Text));
                    MessageBox.Show("Заяка отправлена.");
                }
                else
                {
                    MessageBox.Show("Вводите только цифры.");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }
    }
}
