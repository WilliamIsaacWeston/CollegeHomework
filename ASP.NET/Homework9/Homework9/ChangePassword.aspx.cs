using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework9
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        NRVVref.NRVVservice NRVVclient;
        String token;

        protected void Page_Load(object sender, EventArgs e)
        {
            NRVVclient = new NRVVref.NRVVservice();
            String user = (String)Session["User"];
            String CurrentPassword = (String)Session["Password"];
            token = (String)Session["Token"];

            if (user == null)
                Response.Redirect("Login.aspx");
            else
            {
                Session.Timeout = 60;
                LabelUser.Text = "Hello, " + user;

                if (Page.IsPostBack == true)
                {
                    String ConfirmCurrentPassword = TextBoxOld.Text;
                    String NewPassword = TextBoxNew.Text;
                    String ConfirmNewPassword = TextBoxConfirm.Text;

                    if (CurrentPassword.Equals(ConfirmCurrentPassword))
                        if (NewPassword.Equals(ConfirmNewPassword))
                            if (!string.IsNullOrEmpty(NewPassword))
                            {
                                String result = NRVVclient.changePassword(user, NewPassword, token);

                                if (result.Equals("SUCCESS"))
                                {
                                    Session["Password"] = NewPassword;
                                    LabelMsg.ForeColor = System.Drawing.Color.Green;
                                    LabelMsg.Text = "Password successfully changed";
                                }
                                else
                                {
                                    LabelMsg.ForeColor = System.Drawing.Color.Red;
                                    LabelMsg.Text = "An error occured; your password has not changed";
                                }
                            }
                            else
                            {
                                LabelMsg.ForeColor = System.Drawing.Color.Red;
                                LabelMsg.Text = "The New Password field must contain a value";
                            }
                        else
                        {
                            LabelMsg.ForeColor = System.Drawing.Color.Red;
                            LabelMsg.Text = "The New Password and Confirm Password fields must match";
                        }
                    else
                    {
                        LabelMsg.ForeColor = System.Drawing.Color.Red;
                        LabelMsg.Text = "The Current Password  field must match your current password";
                    }
                }
            }
                
                
        }

        protected void LinkButtonLogOut_Click(object sender, EventArgs e)
        {
            String result = NRVVclient.logOut(token);

            if (result.Equals("SUCCESS"))
            {
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
            else
                LabelMsg.Text = "Error: " + result;
        }
    }
}