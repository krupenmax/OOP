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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        public void Open()
        {
            ShowDialog();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void myTextBox_KeyPress(
    object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void RegistrateButton_Click(object sender, EventArgs e)
        {
            RegistrationController registrationController = new RegistrationController();
            if (ConfirmBox.Text == PasswordBox.Text)
            {
                registrationController.Registrate(LoginBox.Text, PasswordBox.Text, FirstNameBox.Text, SecondNameBox.Text, FatherNameBox.Text, PassportDataBox.Text, IdNumberBox.Text, PhoneNumBox.Text, EmailBox.Text);
                this.Hide();
                StartForm StartForm = new StartForm();
                Thread myThread1 = new Thread(StartForm.Open);
                myThread1.Start();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");               
            }
        }

        private void ConfirmLabel_Click(object sender, EventArgs e)
        {

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
