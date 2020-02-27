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
    public partial class FormLogin : Form
    {
        public Homework4.EIS.EmpInfoServiceSoapClient EISclient;
        public FormMain parent;

        public FormLogin(FormMain _parent, Homework4.EIS.EmpInfoServiceSoapClient _EISclient)
        {
            InitializeComponent();
            EISclient = _EISclient;
            parent = _parent;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = this.textBoxLogin.Text;
            String password = this.textBoxPassword.Text;
            String token = EISclient.logIn(username, password);

            if (token.Equals("DENIED") || token.Equals("DBMS FAILURE"))
            {
                System.Windows.Forms.MessageBox.Show("An error occured; you have not been logged-in. " +
                        "Check your username and password and try again");
            }
            else
            {
                parent.setUsername(username);
                parent.setPassword(password);
                parent.setToken(token);
                parent.displayList();
                this.Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            parent.Close();
        }
    }
}
