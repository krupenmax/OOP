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
    public partial class AccountForm : Form
    {
        HomeForm homeForm;
        public AccountForm(HomeForm homeForm)
        {
            InitializeComponent();
            moneyTypeBox.Items.Add("USD");
            moneyTypeBox.Items.Add("EUR");
            moneyTypeBox.Items.Add("BYR");
            moneyTypeBox.Items.Add("RUB");
            this.homeForm = homeForm;
            moneyTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public string getMoneyType()
        {
            return Convert.ToString(moneyTypeBox.SelectedItem);
        }

        private void moneyTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердите действие", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                homeForm.CreateAcc();
            }
            this.Close();
            this.Dispose();         
        }
    }
}
