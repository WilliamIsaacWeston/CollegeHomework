using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class FormList : Form
    {
        FormMain parent;
        Homework4.EIS.EmpInfoServiceSoapClient EISclient;

        public FormList(FormMain _parent, Homework4.EIS.EmpInfoServiceSoapClient _EISclient)
        {
            InitializeComponent();
            parent = _parent;
            EISclient = _EISclient;
            comboBoxEmployees.DataSource = EISclient.getEmployeesList();
            comboBoxEmployees.DisplayMember = "FullName";
            comboBoxEmployees.ValueMember = "EIN";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Employee.FormEmployee aEmp = new Employee.FormEmployee(parent, EISclient, "000000");
            aEmp.MdiParent = parent;
            aEmp.Show();
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            String thisEIN = comboBoxEmployees.SelectedValue.ToString();
            Employee.FormEmployee aEmp = new Employee.FormEmployee(parent, EISclient, thisEIN);
            aEmp.MdiParent = parent;
            aEmp.Show();
            this.Close();
        }
    }
}
