using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual_Programming___HW1_Employee_System.Models;
using Visual_Programming___HW1_Employee_System.Models.DataTables;


namespace Visual_Programming___HW1_Employee_System
{
    public partial class Form1 : Form
    {
        EmployeeDataTable emplyeeDataTable = new EmployeeDataTable();

        public Form1()
        {
            InitializeComponent();
            dataGridViewEmployee.DataSource = this.emplyeeDataTable;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(textBoxSsn.Text, textBoxFirstName.Text, textBoxLastName.Text, dateTimePickerBirthDate.Text, textBoxAddress.Text, comboBoxDepartment.Text);
            this.emplyeeDataTable.AddEmployee(employee);
        }
    }
}
