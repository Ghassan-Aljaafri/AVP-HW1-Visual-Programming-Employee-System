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
        DataColumn SsnColumn;
        DataColumn FirstNameColumn;
        DataColumn LastNameColumn;
        DataColumn BirthDateColumn;
        DataColumn AddressColumn;
        DataColumn DepartmentColumn;

        public EmployeeDataTable()
        {
            SsnColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "SSN",
                ReadOnly = true
            };

            FirstNameColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "First Name",
                ReadOnly = true
            };

            LastNameColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Last Name",
                ReadOnly = true
            };

            BirthDateColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Birth Date",
                ReadOnly = true
            };

            DepartmentColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Department",
                ReadOnly = true
            };

            AddressColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Address",
                ReadOnly = true
            };

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
            row["First Name"] = employee.FirstName;
            row["Last Name"] = employee.LastName;
            row["Birth Date"] = employee.BirthDate;
            row["Address"] = employee.Address;
            row["Department"] = employee.Department;
            this.Rows.Add(row);
        }
    }
}
