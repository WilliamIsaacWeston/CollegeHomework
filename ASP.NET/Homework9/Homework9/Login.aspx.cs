using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework9
{
    public partial class Login : System.Web.UI.Page
    {
        NRVVref.NRVVservice NRVVclient;

        protected void Page_Load(object sender, EventArgs e)
        {
            NRVVclient = new NRVVref.NRVVservice();

            if (Page.IsPostBack == true)
            {
                String username = TextBoxUsername.Text;
                String password = TextBoxPassword.Text;

                String result = NRVVclient.logIn(username, password);

                if (result.Equals("DENIED"))
                    LabelMsg.Text = "Access denined";
                else if (result.Equals("DBMS FAILURE"))
                    LabelMsg.Text = "Could not connect to the database";
                else
                {
                    Session.Timeout = 60;
                    Session["Token"] = result;
                    Session["User"] = username;
                    Session["Password"] = password;
                    Session["Member"] = NRVVclient.getMember(username, result);
                    Response.Redirect("Main.aspx");
                }
            }
        }
    }
}