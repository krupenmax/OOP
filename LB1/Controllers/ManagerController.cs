using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class ManagerController
    {
        Manager manager = new Manager();
        public Manager login(string login, string password)
        {
            return manager.Login(login, password);
        }

        public void getSideSpecialistLogs(System.Windows.Forms.ListBox listBox)
        {
            manager.getSideSpecialistLogs(listBox);
        }

        public void cancelAction(System.Windows.Forms.ListBox listBox)
        {
            manager.cancelAction(listBox);
        }
    }
}
