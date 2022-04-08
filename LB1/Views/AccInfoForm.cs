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
using System.IO;

namespace LB1
{
    public partial class AccInfoForm : Form
    {
        ClientController clientController;
        HomeForm homeForm;
        AccountInfoController accountInfoController;
        public AccInfoForm(ClientController clientController, HomeForm homeForm)
        {
            InitializeComponent();
            this.clientController = clientController;
            getAccountsToBox();
            this.homeForm = homeForm;
        }
        public void Open()
        {
            ShowDialog();
        }

        public void getAccountsToBox()
        {
            accountInfoController = new AccountInfoController(clientController);
            accountInfoController.setBox(accBox);
        }

        private void AccInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Thread myThread1 = new Thread(homeForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void accBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountInfoController = new AccountInfoController(clientController);
            string accNum = "";
            string urName = "";
            int i = 0;
            while (accBox.Text[i] != ',')
            {
                accNum += accBox.Text[i];
                i++;
            }
            i += 2;
            while (i < accBox.Text.Length)
            {
                urName += accBox.Text[i];
                i++;
            }

            if (accountInfoController.getActiveAccount(accNum, urName).getIsFreezed() == true)
            {
                isFreezedBox.Text = "Заморожен";
                depositBtn.Enabled = false;
                depositBtn.Visible = true;
                freezeBtn.Enabled = false;
                freezeBtn.Visible = true;
                activateBtn.Enabled = true;
            }
            else
            {
                isFreezedBox.Text = "Активен";
                activateBtn.Enabled = false;
                activateBtn.Visible = true;
                freezeBtn.Enabled = true;
                depositBtn.Enabled = true;
            }
            balanceBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).getBalance());
            dataCreationBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).getCreationTime());
            moneyTypeBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).getMoneyType());
            ownerBox.Text = clientController.ActiveClient.getSecondName() + " " + clientController.ActiveClient.getFirstName() + " " + clientController.ActiveClient.getFatherName();
            switch (moneyTypeBox.Text)
            {
                case "USD":
                    balanceBox.Text += " $";
                    break;
                case "EUR":
                    balanceBox.Text += " €";
                    break;
                case "BYR":
                    balanceBox.Text += " BYR";
                    break;
                case "RUB":
                    balanceBox.Text += " RUB";
                    break;
            }
        }

        public void showInfo()
        {
            accountInfoController = new AccountInfoController(clientController);
            string accNum = "";
            string urName = "";
            int i = 0;
            while (accBox.Text[i] != ',')
            {
                accNum += accBox.Text[i];
                i++;
            }
            i += 2;
            while (i < accBox.Text.Length)
            {
                urName += accBox.Text[i];
                i++;
            }

            if (accountInfoController.getActiveAccount(accNum, urName).getIsFreezed() == true)
            {
                isFreezedBox.Text = "Заморожен";
                depositBtn.Enabled = false;
                depositBtn.Visible = true;
                freezeBtn.Enabled = false;
                freezeBtn.Visible = true;
                activateBtn.Enabled = true;
            }
            else
            {
                isFreezedBox.Text = "Активен";
                activateBtn.Enabled = false;
                activateBtn.Visible = true;
                freezeBtn.Enabled = true;
                depositBtn.Enabled = true;
            }
            balanceBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).getBalance());
            dataCreationBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).getCreationTime());
            moneyTypeBox.Text = Convert.ToString(accountInfoController.getActiveAccount(accNum, urName).getMoneyType());
            ownerBox.Text = clientController.ActiveClient.getSecondName() + " " + clientController.ActiveClient.getFirstName() + " " + clientController.ActiveClient.getFatherName();
            switch (moneyTypeBox.Text)
            {
                case "USD":
                    balanceBox.Text += " $";
                    break;
                case "EUR":
                    balanceBox.Text += " €";
                    break;
                case "BYR":
                    balanceBox.Text += " BYR";
                    break;
                case "RUB":
                    balanceBox.Text += " RUB";
                    break;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (accBox.Text != "")
            {
                string accNum = "";
                string urName = "";
                int i = 0;
                while (accBox.Text[i] != ',')
                {
                    accNum += accBox.Text[i];
                    i++;
                }
                i += 2;
                while (i < accBox.Text.Length)
                {
                    urName += accBox.Text[i];
                    i++;
                }

                Account Sender = accountInfoController.getActiveAccount(accNum, urName);
                string accStr = "\n\"" + Sender.getUrName() + "\",\"" + Sender.getAccNum() + "\",\"" + Convert.ToString(Sender.getUserID()) + "\",\"" + Sender.getMoneyType() + "\",\""
                + Convert.ToString(Sender.getBalance()) + "\",\"" + Convert.ToString(Sender.getCreationTime()) + "\",\"" + Convert.ToString(Sender.getIsFreezed()) + "\"";
                string str = "";
                using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
                {
                    str = reader.ReadToEnd();
                }

                str = str.Replace(accStr, "");

                BankController bankController = new BankController();
                DeletingController deleteController = new DeletingController(accNum, urName, clientController, bankController.getBank(urName));

                using (StreamWriter writer = new StreamWriter("../../Models/Docs/Accounts.txt"))
                {
                    writer.Write(str);
                }

                accBox.Items.Clear();
                getAccountsToBox();
                accBox.Text = "";
                moneyTypeBox.Text = "";
                balanceBox.Text = "";
                ownerBox.Text = "";
                dataCreationBox.Text = "";
                isFreezedBox.Text = "";

                MessageBox.Show("Счет удален");
            }
            else
            {
                MessageBox.Show("Выберите счет, который хотите удалить");
            }
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (accBox.Text != "")
            {
                DepositForm DepositForm = new DepositForm(this);
            }
            else
            {
                MessageBox.Show("Выберите счет, который хотите пополнить");
            }
        }

        private void cashOutBtn_Click(object sender, EventArgs e)
        {
            if (accBox.Text != "")
            {
                CashOutForm CashOutForm = new CashOutForm(this);
            }
            else
            {
                MessageBox.Show("Выберите счет, который хотите пополнить");
            }
        }

        public void deposit(double amount)
        {
            string accNum = "";
            string urName = "";
            int i = 0;
            while (accBox.Text[i] != ',')
            {
                accNum += accBox.Text[i];
                i++;
            }
            i += 2;
            while (i < accBox.Text.Length)
            {
                urName += accBox.Text[i];
                i++;
            }

            Account sender = accountInfoController.getActiveAccount(accNum, urName);
            string accStr = "\n\"" + sender.getUrName() + "\",\"" + sender.getAccNum() + "\",\"" + Convert.ToString(sender.getUserID()) + "\",\"" + sender.getMoneyType() + "\",\""
            + Convert.ToString(sender.getBalance()) + "\",\"" + Convert.ToString(sender.getCreationTime()) + "\",\"" + Convert.ToString(sender.getIsFreezed()) + "\"";

            string str = "";
            using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
            {
                str = reader.ReadToEnd();
            }

            TransferController transferController = new TransferController(accountInfoController.getActiveAccount(accNum, urName), null, null, clientController.ActiveClient);
            transferController.deposit(amount);
            showInfo();

            sender = accountInfoController.getActiveAccount(accNum, urName);
            string replaceStr = "\n\"" + sender.getUrName() + "\",\"" + sender.getAccNum() + "\",\"" + Convert.ToString(sender.getUserID()) + "\",\"" + sender.getMoneyType() + "\",\""
            + Convert.ToString(sender.getBalance()) + "\",\"" + Convert.ToString(sender.getCreationTime()) + "\",\"" + Convert.ToString(sender.getIsFreezed()) + "\"";

            str = str.Replace(accStr, replaceStr);
            using (StreamWriter writer = new StreamWriter("../../Models/Docs/Accounts.txt"))
            {
                writer.Write(str);
            }

            MessageBox.Show("Баланс успешно пополнен");
        }

        public void cashOut(double amount)
        {
            string accNum = "";
            string urName = "";
            int i = 0;
            while (accBox.Text[i] != ',')
            {
                accNum += accBox.Text[i];
                i++;
            }
            i += 2;
            while (i < accBox.Text.Length)
            {
                urName += accBox.Text[i];
                i++;
            }
            if (accountInfoController.getActiveAccount(accNum, urName).getBalance() > -1 * amount)
            {
                Account sender = accountInfoController.getActiveAccount(accNum, urName);
                string accStr = "\n\"" + sender.getUrName() + "\",\"" + sender.getAccNum() + "\",\"" + Convert.ToString(sender.getUserID()) + "\",\"" + sender.getMoneyType() + "\",\""
                + Convert.ToString(sender.getBalance()) + "\",\"" + Convert.ToString(sender.getCreationTime()) + "\",\"" + Convert.ToString(sender.getIsFreezed()) + "\"";
                string str = "";
                using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
                {
                    str = reader.ReadToEnd();
                }

                TransferController transferController = new TransferController(accountInfoController.getActiveAccount(accNum, urName), null, null, clientController.ActiveClient);
                transferController.deposit(amount);
                showInfo();

                sender = accountInfoController.getActiveAccount(accNum, urName);
                string replaceStr = "\n\"" + sender.getUrName() + "\",\"" + sender.getAccNum() + "\",\"" + Convert.ToString(sender.getUserID()) + "\",\"" + sender.getMoneyType() + "\",\""
                + Convert.ToString(sender.getBalance()) + "\",\"" + Convert.ToString(sender.getCreationTime()) + "\",\"" + Convert.ToString(sender.getIsFreezed()) + "\"";

                str = str.Replace(accStr, replaceStr);
                using (StreamWriter writer = new StreamWriter("../../Models/Docs/Accounts.txt"))
                {
                    writer.Write(str);
                }

                MessageBox.Show("Средства успешно сняты.");
            }
            else
            {
                MessageBox.Show("Недостаточно средств.");
            }
        }

        private void freezeBtn_Click(object sender, EventArgs e)
        {
            if (accBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Подтвердите действие", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string accNum = "";
                    string urName = "";
                    int i = 0;
                    while (accBox.Text[i] != ',')
                    {
                        accNum += accBox.Text[i];
                        i++;
                    }
                    i += 2;
                    while (i < accBox.Text.Length)
                    {
                        urName += accBox.Text[i];
                        i++;
                    }

                    Account Sender = accountInfoController.getActiveAccount(accNum, urName);
                    string accStr = "\n\"" + Sender.getUrName() + "\",\"" + Sender.getAccNum() + "\",\"" + Convert.ToString(Sender.getUserID()) + "\",\"" + Sender.getMoneyType() + "\",\""
                    + Convert.ToString(Sender.getBalance()) + "\",\"" + Convert.ToString(Sender.getCreationTime()) + "\",\"" + Convert.ToString(Sender.getIsFreezed()) + "\"";
                    string str = "";
                    using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
                    {
                        str = reader.ReadToEnd();
                    }

                    accountInfoController.freezeAcc(accNum, urName);
                    clientController.ActiveClient.overwriteAcc(accountInfoController.getActiveAccount(accNum, urName), accNum, urName);
                    BankController bankController = new BankController();
                    bankController.getBank(urName).overwriteAcc(accountInfoController.getActiveAccount(accNum, urName), accNum);
                    showInfo();

                    Sender = accountInfoController.getActiveAccount(accNum, urName);
                    string replaceStr = "\n\"" + Sender.getUrName() + "\",\"" + Sender.getAccNum() + "\",\"" + Convert.ToString(Sender.getUserID()) + "\",\"" + Sender.getMoneyType() + "\",\""
                    + Convert.ToString(Sender.getBalance()) + "\",\"" + Convert.ToString(Sender.getCreationTime()) + "\",\"" + Convert.ToString(Sender.getIsFreezed()) + "\"";

                    str = str.Replace(accStr, replaceStr);
                    using (StreamWriter writer = new StreamWriter("../../Models/Docs/Accounts.txt"))
                    {
                        writer.Write(str);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите счет");
            }
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            if (accBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Подтвердите действие", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string accNum = "";
                    string urName = "";
                    int i = 0;
                    while (accBox.Text[i] != ',')
                    {
                        accNum += accBox.Text[i];
                        i++;
                    }
                    i += 2;
                    while (i < accBox.Text.Length)
                    {
                        urName += accBox.Text[i];
                        i++;
                    }

                    Account Sender = accountInfoController.getActiveAccount(accNum, urName);
                    string accStr = "\n\"" + Sender.getUrName() + "\",\"" + Sender.getAccNum() + "\",\"" + Convert.ToString(Sender.getUserID()) + "\",\"" + Sender.getMoneyType() + "\",\""
                    + Convert.ToString(Sender.getBalance()) + "\",\"" + Convert.ToString(Sender.getCreationTime()) + "\",\"" + Convert.ToString(Sender.getIsFreezed()) + "\"";
                    string str = "";
                    using (StreamReader reader = File.OpenText("../../Models/Docs/Accounts.txt"))
                    {
                        str = reader.ReadToEnd();
                    }

                    accountInfoController.activateAcc(accNum, urName);
                    clientController.ActiveClient.overwriteAcc(accountInfoController.getActiveAccount(accNum, urName), accNum, urName);
                    BankController bankController = new BankController();
                    bankController.getBank(urName).overwriteAcc(accountInfoController.getActiveAccount(accNum, urName), accNum);
                    showInfo();

                    Sender = accountInfoController.getActiveAccount(accNum, urName);
                    string replaceStr = "\n\"" + Sender.getUrName() + "\",\"" + Sender.getAccNum() + "\",\"" + Convert.ToString(Sender.getUserID()) + "\",\"" + Sender.getMoneyType() + "\",\""
                    + Convert.ToString(Sender.getBalance()) + "\",\"" + Convert.ToString(Sender.getCreationTime()) + "\",\"" + Convert.ToString(Sender.getIsFreezed()) + "\"";

                    str = str.Replace(accStr, replaceStr);
                    using (StreamWriter writer = new StreamWriter("../../Models/Docs/Accounts.txt"))
                    {
                        writer.Write(str);
                    }
                }

            }
        }
    }
}
