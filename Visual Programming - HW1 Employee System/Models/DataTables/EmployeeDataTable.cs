using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Visual_Programming___HW1_Employee_System.Models.DataTables
{
    class EmployeeDataTable : DataTable
    {
        readonly DataColumn SsnColumn = new DataColumn
        {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "SSN",
            ReadOnly = true
        };
        readonly DataColumn FirstNameColumn = new DataColumn
        {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "FirstName",
            ReadOnly = true
        };
        readonly DataColumn LastNameColumn = new DataColumn
        {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "LastName",
            ReadOnly = true
        };
        readonly DataColumn BirthDateColumn = new DataColumn
        {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "BirthDate",
            ReadOnly = true
        };
        readonly DataColumn DepartmentColumn = new DataColumn
        {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "Department",
            ReadOnly = true
        };
        readonly DataColumn AddressColumn = new DataColumn
        {
            DataType = System.Type.GetType("System.String"),
            ColumnName = "Address",
            ReadOnly = true
        };

        public EmployeeDataTable()
        {
            this.Columns.Add(SsnColumn);
            this.Columns.Add(FirstNameColumn);
            this.Columns.Add(LastNameColumn);
            this.Columns.Add(BirthDateColumn);
            this.Columns.Add(DepartmentColumn);
            this.Columns.Add(AddressColumn);
        }

        public void AddEmployee(Employee employee)
        {
            DataRow row = this.NewRow();
            row["SSN"] = employee.Ssn;
            row["FirstName"] = employee.FirstName;
            row["LastName"] = employee.LastName;
            row["BirthDate"] = employee.BirthDate;
            row["Address"] = employee.Address;
            row["Department"] = employee.Department;
            this.Rows.Add(row);
        }
    }
}
