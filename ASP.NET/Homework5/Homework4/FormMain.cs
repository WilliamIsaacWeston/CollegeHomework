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
    public partial class FormMain : Form
    {
        public Homework4.EIS.EmpInfoServiceSoapClient EISclient = new Homework4.EIS.EmpInfoServiceSoapClient("EmpInfoServiceSoap");
        String token = "";
        String username = "";
        String password = "";
        FormList listWindow;

        public FormMain()
        {
            InitializeComponent();
            FormLogin LoginWindow = new FormLogin(this, EISclient);
            LoginWindow.MdiParent = this;
            LoginWindow.Show();
        }

        public void setToken(String _token)
        {
            token = _token;
        }

        public String getToken()
        {
            return token;
        }

        public void setUsername(String _username)
        {
            username = _username;
        }

        public void setPassword(String _password)
        {
            password = _password;
        }

        public void menuEnabled(Boolean enabled)
        {
            this.menuStripOptions.Enabled = enabled;
        }

        public void displayList()
        {
            this.menuStripOptions.Enabled = true;
            listWindow = new FormList(this, EISclient);
            listWindow.MdiParent = this;
            listWindow.Show();
        }

        public void refreshList()
        {
            listWindow.Close();
            listWindow = new FormList(this, EISclient);
            listWindow.MdiParent = this;
            listWindow.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String msg = EISclient.logOut(token);

            if (msg.Equals("SUCCESS"))
            {
                Form[] openForms = this.MdiChildren;
                for (int i=0; i < openForms.Length; i++)
                {
                    openForms[i].Close();
                }
                this.menuStripOptions.Enabled = false;
                System.Windows.Forms.MessageBox.Show("Log-out successful");
                FormLogin LoginWindow = new FormLogin(this, EISclient);
                LoginWindow.MdiParent = this;
                LoginWindow.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("An error occured; you have not been logged-out.");
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPasswordChange pcWindow = new FormPasswordChange(this, EISclient, username, password, token);
            pcWindow.MdiParent = this;
            pcWindow.Show();
        }

        private void showListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listWindow = new FormList(this, EISclient);
            listWindow.Show();
        } 
    }
}
