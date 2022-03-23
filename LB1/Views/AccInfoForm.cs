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
    public partial class AccInfoForm : Form
    {
        ClientController clientController; 
        public AccInfoForm(ClientController clientController)
        {
            InitializeComponent();
            this.clientController = clientController;
            getAccountsToBox();
        }
        public void Open()
        {
            ShowDialog();
        }

        public void getAccountsToBox()
        {
            AccountInfoController accountInfoController = new AccountInfoController(clientController);
            accountInfoController.setBox(accBox);
        }

        private void AccInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
