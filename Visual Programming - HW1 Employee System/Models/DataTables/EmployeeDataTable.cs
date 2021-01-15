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
                ColumnName = "ssn",
                ReadOnly = true
            };

            FirstNameColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "firstName",
                ReadOnly = true
            };

            LastNameColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "lastName",
                ReadOnly = true
            };

            BirthDateColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "birthDate",
                ReadOnly = true
            };

            DepartmentColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "department",
                ReadOnly = true
            };

            AddressColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "address",
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
            row["ssn"] = employee.Ssn;
            row["firstName"] = employee.FirstName;
            row["lastName"] = employee.LastName;
            row["birthDate"] = employee.BirthDate;
            row["address"] = employee.Address;
            row["department"] = employee.Department;
            this.Rows.Add(row);
        }
    }
}
