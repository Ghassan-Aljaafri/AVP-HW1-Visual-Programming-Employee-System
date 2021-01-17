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
        DataView dataView;

        public Form1()
        {
            InitializeComponent();
            dataView = new DataView(this.emplyeeDataTable);
            dataGridViewEmployee.DataSource = this.dataView;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(textBoxSsn.Text, textBoxFirstName.Text, textBoxLastName.Text, dateTimePickerBirthDate.Text, textBoxAddress.Text, comboBoxDepartment.Text);
            this.emplyeeDataTable.AddEmployee(employee);
            clearFields();
        }

        public void clearFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ctrl.Text = "";
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchColumn = comboBoxSearchColumn.Text == String.Empty ? "SSN" : comboBoxSearchColumn.Text;
            string searchString = textBoxSearch.Text;
            dataView.RowFilter = $"{searchColumn} LIKE '%{searchString}%'";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Empty;
            textBoxSearch.Clear();
        }

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                textBoxSsn.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells["SSN"].Value.ToString();
                textBoxFirstName.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                textBoxLastName.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                dateTimePickerBirthDate.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells["BirthDate"].Value.ToString();
                textBoxAddress.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                comboBoxDepartment.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells["Department"].Value.ToString();
            }
        }
    }
}
