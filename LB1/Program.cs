using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    class Program
    {
        public static Database database = new Database();

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            database.GetData();
            StartForm startForm = new StartForm();
            Application.Run(startForm);
        }
    }
}
