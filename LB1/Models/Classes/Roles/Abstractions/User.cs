using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public abstract class User
    {
        string password;
        string login;
        string firstName;
        string secondName;
        string fatherName;

        public string getFatherName()
        {
            return fatherName;
        }
        public void setFatherName(string fatherName)
        {
            this.fatherName = fatherName;
        }

        public string getSecondName()
        {
            return secondName;
        }
        public void setSecondName(string secondName)
        {
            this.secondName = secondName;
        }

        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getLogin()
        {
            return login;
        }
        public void setLogin(string login)
        {
            this.login = login;
        }

    }
}
