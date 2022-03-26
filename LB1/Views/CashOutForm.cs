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
    public partial class CashOutForm : Form
    {
        AccInfoForm accInfoForm;
        public CashOutForm(AccInfoForm accInfoForm)
        {
            InitializeComponent();
            this.accInfoForm = accInfoForm;
            ShowDialog();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void acceptButton_Click_1(object sender, EventArgs e)
        {
            double num = 0.0;
            if (amountBox.Text != "")
            {
                if (double.TryParse(amountBox.Text, out num))
                {
                    double amount = -1 * Convert.ToInt16(amountBox.Text);
                    accInfoForm.cashOut(amount);
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Пожайлуста, используйте только цифры для ввода.");
                }
            }
            else
            {
                MessageBox.Show("Введите сумму пополнения.");
            }
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
