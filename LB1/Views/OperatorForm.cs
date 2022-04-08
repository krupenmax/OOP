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
    public partial class  OperatorForm : Form
    {
        OperatorController operatorController = new OperatorController();
        public OperatorForm()
        {
            InitializeComponent();
            operatorController.getLogs(logBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            operatorController.cancelAction(Convert.ToString(logBox.SelectedItem));
            string deleteStr = Convert.ToString(logBox.SelectedItem);
            string[] container = new string[logBox.Items.Count];
            for (int i = 0; i < logBox.Items.Count; i++)
            {
                if (Convert.ToString(logBox.Items[i]) != deleteStr)
                {
                    container[i] = Convert.ToString(logBox.Items[i]);
                }
            }
            logBox.Items.Clear();
            for (int i = 0; i < container.Length; i++)
            {
                if (container[i] != null)
                {
                    logBox.Items.Add(container[i]);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
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
