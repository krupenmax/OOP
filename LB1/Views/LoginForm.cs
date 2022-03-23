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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AuthorizeBtn_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            if (loginController.Login(LoginBox.Text, PasswordBox.Text).firstName != null)
            {
                this.Hide();
                HomeForm HomeForm = new HomeForm(LoginBox.Text, PasswordBox.Text);
                Thread myThread1 = new Thread(HomeForm.Open);
                myThread1.Start();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно");
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
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
