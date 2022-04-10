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
            this.FirstNameBox.KeyDown += new KeyEventHandler(FirstNameBox_KeyDown);
            this.SecondNameBox.KeyDown += new KeyEventHandler(SecondNameBox_KeyDown);
            this.FatherNameBox.KeyDown += new KeyEventHandler(FatherNameBox_KeyDown);
        }


        public void Open()
        {
            ShowDialog();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }



        private void RegistrateButton_Click(object sender, EventArgs e)
        {
            RegistrationController registrationController = new RegistrationController();
            if (ConfirmBox.Text == PasswordBox.Text)
            {
                if (LoginBox.Text != "" && PasswordBox.Text != "" && FirstNameBox.Text != "" && SecondNameBox.Text != "" && FatherNameBox.Text != "" && PassportDataBox.Text != "" && IdNumberBox.Text != "" && PhoneNumBox.Text != "" && EmailBox.Text != "")
                {
                    if (checkBox1.Checked == false)
                    {
                        registrationController.Registrate(LoginBox.Text, PasswordBox.Text, FirstNameBox.Text, SecondNameBox.Text, FatherNameBox.Text, PassportDataBox.Text,
                            IdNumberBox.Text, PhoneNumBox.Text, EmailBox.Text);
                    }
                    else
                    {
                        if (companyNameBox.Text != "")
                        {
                            SideSpecialistController sideSpecialistController = new SideSpecialistController();
                            sideSpecialistController.Registrate(LoginBox.Text, PasswordBox.Text, FirstNameBox.Text, SecondNameBox.Text, FatherNameBox.Text, PassportDataBox.Text,
                            IdNumberBox.Text, PhoneNumBox.Text, EmailBox.Text, companyNameBox.Text);
                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля.");
                        }
                    }
                    this.Hide();
                    StartForm StartForm = new StartForm();
                    Thread myThread1 = new Thread(StartForm.Open);
                    myThread1.Start();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        private void ConfirmLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4
                || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9)
            {
                MessageBox.Show("Некорректный символ");
                FirstNameBox.Text = "";
                e.Handled = true;
            }
        }

        private void SecondNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4
                || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9)
            {
                MessageBox.Show("Некорректный символ");
                SecondNameBox.Text = "";
                e.Handled = true;
            }
        }

        private void FatherNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4
                || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9)
            {
                MessageBox.Show("Некорректный символ");
                FatherNameBox.Text = "";
                e.Handled = true;
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                companyNameBox.Enabled = true;
            }
            else
            {
                companyNameBox.Enabled = false;
            }
        }
    }
}
