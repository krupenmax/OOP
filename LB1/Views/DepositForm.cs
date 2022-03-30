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
    public partial class DepositForm : Form
    {
        AccInfoForm accInfoForm;
        public DepositForm(AccInfoForm accInfoForm)
        {
            InitializeComponent();
            this.accInfoForm = accInfoForm;
            ShowDialog();
        }

        public void Open()
        {
            ShowDialog();
        }


        private void cancelBtn_Click(object sender, EventArgs e)    
        {
            this.Close();
            this.Dispose();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            double num = 0.0;
            if (amountBox.Text != "")
            {
                if (double.TryParse(amountBox.Text, out num))
                {
                    if (Convert.ToInt64(amountBox.Text) <= Int16.MaxValue)
                    {
                        double amount = Convert.ToInt16(amountBox.Text);

                        accInfoForm.deposit(amount);
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Слишком большая сумма перевода.");
                    }
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


    }
}
