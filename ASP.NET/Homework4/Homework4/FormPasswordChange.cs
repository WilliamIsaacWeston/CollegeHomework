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
    public partial class FormPasswordChange : Form
    {
        public Homework4.EIS.EmpInfoServiceSoapClient EISclient;
        public FormMain parent;
        String username;
        String password;
        String token;

        public FormPasswordChange(FormMain _parent, Homework4.EIS.EmpInfoServiceSoapClient _EISclient, String _username, String _password, String _token)
        {
            InitializeComponent();
            parent = _parent;
            EISclient = _EISclient;
            username = _username;
            password = _password;
            token = _token;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxNew.Text))
            {
                if (this.textBoxNew.Text.Equals(this.textBoxConfirm.Text))
                {
                    if (this.textBoxCurrent.Text.Equals(this.password))
                    {
                        String password = this.textBoxNew.Text;
                        String msg = EISclient.changePassword(username, password, token);

                        if (msg.Equals("SUCCESS"))
                        {
                            parent.setPassword(password);
                            System.Windows.Forms.MessageBox.Show("Password successfully changed.");
                            this.Close();
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("An error occured; your password has not been changed.");
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("The \"Current Password\" must equal your current passowrd.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The \"New Password\" and \"Confirm Password\" fields must be equal.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The \"New Password\" field must contain a value.");
            }
        }
    }
}
