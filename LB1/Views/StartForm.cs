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
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            Thread myThread1 = new Thread(registerForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            Thread myThread1 = new Thread(loginForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void killBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
