using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericParsing;
using System.Data;

namespace LB1
{
    public class Bank : ICompany
    {
        public string Type { get; set; }
        public string urName { get; set; }
        public uint UNP { get; set; }
        public uint BIK { get; set; }
        public string adress { get; set; }
        public TableSet bankData = new TableSet();
        public void getBank()
        {   
            bankData.BuildAccountTable();
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("Accounts.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    bankData.Data.Tables["Accounts"].Rows.Add(new object[] { urName, parser["accNum"], Convert.ToInt16(parser["UserID"]), parser["moneyType"], Convert.ToSingle(parser["balance"]), DateTime.Now });
                }
            }
        }
        public void addAcc(int UserID, string moneyType)
        {
            int accNum = 0;
            bool Check = false;
            DataRow[] row = bankData.Data.Tables["Accounts"].Select();
            while (Check == false)
            {
                accNum = row.Length + 1;
                bool Check2 = false;
                for(int i = 0; i < row.Length; i++)
                {
                    if(Convert.ToInt16(row[i]["UserID"]) == accNum)
                    {
                        Check2 = true;
                    }
                }
                if(Check2 == false)
                {
                    Check = true;
                }
            }
            bankData.Data.Tables["Accounts"].Rows.Add(new object[] { urName, accNum, UserID, moneyType, 0, DateTime.Now });
        }
        
        public void deleteAcc(string accNum)
        {
            DataRow[] row = bankData.Data.Tables["Accounts"].Select("accNum = " + accNum);
            row[0].Delete();
            bankData.Data.Tables["Accounts"].AcceptChanges();
        }
    }
}
