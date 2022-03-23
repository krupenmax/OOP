using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Model
    {
        public Database database { get; set; } = new Database();
        public Model(Database database)
        {
            this.database = database;
        }
        
    }
}
