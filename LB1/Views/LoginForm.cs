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
            if (sideSpecialistCheck.Checked == false)
            {
                if (loginController.Login(LoginBox.Text, PasswordBox.Text).getFirstName() != null)
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
                    OperatorController operatorController = new OperatorController();
                    if (operatorController.login(LoginBox.Text, PasswordBox.Text).getLogin() != null)
                    {
                        this.Hide();
                        OperatorForm OperatorForm = new OperatorForm();
                        Thread myThread1 = new Thread(OperatorForm.Open);
                        myThread1.Start();
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        ManagerController managerController = new ManagerController();
                        if (managerController.login(LoginBox.Text, PasswordBox.Text).getLogin() != null)
                        {
                            this.Hide();
                            ManagerForm ManagerForm = new ManagerForm();
                            Thread myThread1 = new Thread(ManagerForm.Open);
                            myThread1.Start();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Логин или пароль введены неверно");
                        }
                        
                    }
                }
            }
            if (sideSpecialistCheck.Checked == true)
            {
                SideSpecialistController sideSpecialistController = new SideSpecialistController();
                sideSpecialistController.getSideSpecialist(LoginBox.Text, PasswordBox.Text);
                if (sideSpecialistController.sideSpecialist.getFirstName() == null)
                {
                    MessageBox.Show("Логин или пароль введены неверно");
                }
                else
                {
                    this.Hide();
                    SideSpecialistForm SideSpecialistForm = new SideSpecialistForm(sideSpecialistController);
                    Thread myThread1 = new Thread(SideSpecialistForm.Open);
                    myThread1.Start();
                    this.Close();
                    this.Dispose();
                }
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
