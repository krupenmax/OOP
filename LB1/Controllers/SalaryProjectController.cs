using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class SalaryProjectController
    {
        ClientController clientController;
        public SalaryProjectController(ClientController clientController)
        {
            this.clientController = clientController;
        }
    }
}
