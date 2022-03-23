using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LB1
{
    public class TableSet
    {
        public DataSet Data = new DataSet();
        public void BuildClientTable()
        {
            DataTable table = new DataTable("Clients");
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int16");
            column.ColumnName = "UserID";
            column.Unique = true;
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "login";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "password";
            column.ReadOnly = true;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "firstName";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "secondName";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "fatherName";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "passportData";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "idNumber";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "phoneNumber";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "email";
            column.ReadOnly = true;
            table.Columns.Add(column);


            Data.Tables.Add(table);
        }
        public void BuiltCompanyTable()
        {
            DataTable table = new DataTable("Companies");
            DataColumn column = new DataColumn();

            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Type";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "urName";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.UInt32");
            column.ColumnName = "UNP";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.UInt32");
            column.ColumnName = "BIK";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "adress";
            column.ReadOnly = true;
            table.Columns.Add(column);

            Data.Tables.Add(table);
        }

        public void BuiltBankTable()
        {
            DataTable table = new DataTable("Banks");
            DataColumn column = new DataColumn();

            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Type";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "urName";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.UInt32");
            column.ColumnName = "UNP";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.UInt32");
            column.ColumnName = "BIK";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "adress";
            column.ReadOnly = true;
            table.Columns.Add(column);

            Data.Tables.Add(table);
        }

        public void BuildAccountTable()
        {
            DataTable table = new DataTable("Accounts");
            DataColumn column = new DataColumn();

            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "accNum";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int16");
            column.ColumnName = "UserID";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "moneyType";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Single");
            column.ColumnName = "balance";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "creationTime";
            column.ReadOnly = true;
            table.Columns.Add(column);

            Data.Tables.Add(table);
        }
    }
}
