using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GenericParsing;

namespace LB1
{
    public class SalaryProjectController
    {
        public void getSalaryProjects(System.Windows.Forms.ComboBox comboBox, SideSpecialist sideSpecialist)
        {
            DataRow[] row = Program.database.tableSet.Data.Tables["Companies"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                CompaniesController companiesController = new CompaniesController();
                Company company = companiesController.getCompany(Convert.ToString(row[i]["urName"]));
                DataRow[] salaryRow = company.getCompanyTables().Data.Tables["SalaryProjects"].Select();
                for (int j = 0; j < salaryRow.Length; j++)
                {
                    if (sideSpecialist.getMyCompany().getUrName() == Convert.ToString(salaryRow[j]["companyName"]))
                    {
                        comboBox.Items.Add(salaryRow[j]["ID"]);
                    }
                }
            }
        }

        public void getSalaryFile(System.Windows.Forms.ComboBox comboBox)
        {
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialistSlrPrjcts.txt");
                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    comboBox.Items.Add(parser["ID"]);
                }
            }
        }

        public SalaryProject getSalaryProject(int ID)
        {
            SalaryProject salaryProject = new SalaryProject();
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/SideSpecialistSlrPrjcts.txt");
                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    if (Convert.ToInt16(parser["ID"]) == ID)
                    {
                        salaryProject.setID(Convert.ToInt16(parser["ID"]));
                        salaryProject.setCompanyName(Convert.ToString(parser["companyName"]));
                        salaryProject.setPeriod(Convert.ToInt16(parser["period"]));
                        salaryProject.setAmount(Convert.ToDouble(parser["amount"]));
                        salaryProject.setIsApproved(Convert.ToBoolean(parser["isApproved"]));
                        salaryProject.setUserID(Convert.ToInt16(parser["UserID"]));
                        salaryProject.setMoneyType(Convert.ToString(parser["moneyType"]));
                        break;
                    }
                }
                return salaryProject;
            }
        }
    }
}
