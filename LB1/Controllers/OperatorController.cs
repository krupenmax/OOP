using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class OperatorController
    {
        Operator oper = new Operator();
        public Operator login(string login, string password)
        {
            return oper.login(login, password);
        }

        public void getLogs(System.Windows.Forms.ListBox logBox)
        {
            oper.getLogs(logBox);
        }

        public void cancelAction(string log)
        {
            oper.cancelAction(log);
        }
    }
}
