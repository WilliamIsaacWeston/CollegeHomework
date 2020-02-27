using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class FormEmployee : Form
    {
        String EIN;
        Homework4.FormMain parent;
        Homework4.EIS.EmpInfoServiceSoapClient EISclient;
        Homework4.EIS.Employee thisEmployee;
        String token;

        public FormEmployee(Homework4.FormMain _parent, Homework4.EIS.EmpInfoServiceSoapClient _EISclient, String _EIN)
        {
            EIN = _EIN;
            parent = _parent;
            token = parent.getToken();
            EISclient = _EISclient;
            InitializeComponent();

            comboBoxState.DataSource = EISclient.getStatesList();
            comboBoxState.DisplayMember = "StateCode";
            comboBoxState.ValueMember = "StateCode";

            comboBoxDept.DataSource = EISclient.getDeptList();
            comboBoxDept.DisplayMember = "DeptCode";
            comboBoxDept.ValueMember = "DeptCode";

            textBoxEIN.Text = EIN;

            if (EIN.Equals("000000"))
            {
                thisEmployee = new Homework4.EIS.Employee();
                this.Text = "New Employee";
            }
            else
                this.populateFields();
        }

        private void populateFields()
        {
            thisEmployee = EISclient.getEmployee(EIN, token);
            this.Text = thisEmployee.LastName + ", " + thisEmployee.FirstName + " " + thisEmployee.MiddleInitial + ".";

            textBoxFirstName.Text = thisEmployee.FirstName;
            textBoxMI.Text = thisEmployee.MiddleInitial;
            textBoxLastName.Text = thisEmployee.LastName;
            textBoxStreet.Text = thisEmployee.StreetAddress;
            textBoxCity.Text = thisEmployee.City;
            comboBoxState.SelectedIndex = comboBoxState.FindString(thisEmployee.State);
            textBoxZip.Text = thisEmployee.Zip;
            comboBoxGender.SelectedIndex = comboBoxGender.FindString(thisEmployee.Gender);
            dateTimePickerBirth.Value = thisEmployee.DateOfBirth;
            textBoxSSN.Text = thisEmployee.SSN;
            textBoxHomePhone.Text = thisEmployee.HomePhone;
            textBoxCell.Text = thisEmployee.CellPhone;
            textBoxWork.Text = thisEmployee.WorkPhone;
            textBoxTitle.Text = thisEmployee.Title;
            comboBoxDept.SelectedIndex = comboBoxDept.FindString(thisEmployee.DeptCode);
            textBoxOfficeLocation.Text = thisEmployee.OfficeLocation;
            dateTimePickerHired.Value = thisEmployee.DateHired;
            textBoxSuperEIN.Text = thisEmployee.SupervisorEIN;
            comboBoxPayType.SelectedIndex = comboBoxPayType.FindString(thisEmployee.EmployeeType);
            textBoxSalary.Text = thisEmployee.SalaryOrWage.ToString();
            dateTimePickerRaise.Value = thisEmployee.DateOfLastRaise;
            numericUpDownExemptions.Value = thisEmployee.TaxExemptions;
            comboBoxStatus.SelectedIndex = comboBoxStatus.FindString(thisEmployee.TaxFilingStatus);
            textBoxExtra.Text = thisEmployee.ExtraWithholdings.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Boolean dataValid = true;

            if (textBoxFirstName.Text != "")
                thisEmployee.FirstName = textBoxFirstName.Text;
            else
                dataValid = false;
            if (textBoxMI.Text != "")
                thisEmployee.MiddleInitial = textBoxMI.Text;
            else
                dataValid = false;
            if (textBoxLastName.Text != "")
                thisEmployee.LastName = textBoxLastName.Text;
            else
                dataValid = false;
            if (textBoxStreet.Text != "")
                thisEmployee.StreetAddress = textBoxStreet.Text;
            else
                dataValid = false;
            if (textBoxCity.Text != "")
                thisEmployee.City= textBoxCity.Text;
            else
                dataValid = false;
            if (comboBoxState.SelectedItem != null)
                thisEmployee.State = comboBoxState.SelectedValue.ToString();
            else
                dataValid = false;
            if (textBoxZip.Text != "")
                thisEmployee.Zip = textBoxZip.Text;
            else
                dataValid = false;
            if (comboBoxGender.SelectedItem != null)
                thisEmployee.Gender = comboBoxGender.SelectedItem.ToString();
            else
                dataValid = false;
            thisEmployee.DateOfBirth = dateTimePickerBirth.Value;
            if (textBoxSSN.Text != "")
                thisEmployee.SSN = textBoxSSN.Text;
            else
                dataValid = false;
            if (textBoxHomePhone.Text != "")
                thisEmployee.HomePhone = textBoxHomePhone.Text;
            else
                dataValid = false;
            if (textBoxCell.Text != "")
                thisEmployee.CellPhone = textBoxCell.Text;
            else
                dataValid = false;
            if (textBoxWork.Text != "")
                thisEmployee.WorkPhone = textBoxWork.Text;
            else
                dataValid = false;
            if (textBoxTitle.Text != "")
                thisEmployee.Title = textBoxTitle.Text;
            else
                dataValid = false;
            if (comboBoxDept.SelectedValue != null)
                thisEmployee.DeptCode = comboBoxDept.SelectedValue.ToString();
            else
                dataValid = false;
            if (textBoxOfficeLocation.Text != "")
                thisEmployee.OfficeLocation = textBoxOfficeLocation.Text;
            else
                dataValid = false;
            thisEmployee.DateHired = dateTimePickerHired.Value;
            if (textBoxSuperEIN.Text != "")
                thisEmployee.SupervisorEIN = textBoxSuperEIN.Text;
            else
                dataValid = false;
            if (comboBoxPayType.SelectedItem != null)
                thisEmployee.EmployeeType = comboBoxPayType.SelectedItem.ToString();
            else
                dataValid = false;
            if (textBoxSalary.Text != "")
                thisEmployee.SalaryOrWage = Decimal.Parse(textBoxSalary.Text);
            else
                dataValid = false;
            thisEmployee.DateOfLastRaise = dateTimePickerRaise.Value;
            thisEmployee.TaxExemptions = (int) numericUpDownExemptions.Value;
            if (comboBoxStatus.SelectedItem != null)
                thisEmployee.TaxFilingStatus = comboBoxStatus.SelectedItem.ToString();
            else
                dataValid = false;
            if (textBoxExtra.Text != "")
                thisEmployee.ExtraWithholdings = Decimal.Parse(textBoxExtra.Text);
            else
                dataValid = false;
            thisEmployee.EIN = EIN;

            if (dataValid)
            {
                String msg = EISclient.saveEmployee(thisEmployee, token);

                if (msg.Equals("SUCCESS"))
                {
                    System.Windows.Forms.MessageBox.Show("Changes successfully saved.");
                    parent.refreshList();
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(msg);
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("All data fields must be filled; the employee has not been saved.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String msg = EISclient.deleteEmployee(EIN, token);

            if (msg.Equals("SUCCESS"))
            {
                System.Windows.Forms.MessageBox.Show("Employee successfully deleted.");
                parent.refreshList();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("An error occured; the employee has not been deleted.");
            }
        }
    }
}
