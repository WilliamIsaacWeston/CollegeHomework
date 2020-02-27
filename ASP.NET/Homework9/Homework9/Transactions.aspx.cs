using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework9
{
    public partial class Transactions : System.Web.UI.Page
    {
        NRVVref.NRVVservice NRVVclient;
        String token;

        protected void Page_Load(object sender, EventArgs e)
        {
            NRVVclient = new NRVVref.NRVVservice();
            String user = (String)Session["User"];
            token = (String)Session["Token"];

            if (user == null)
                Response.Redirect("Login.aspx");
            else
            {
                Session.Timeout = 60;
                LabelUser.Text = "Hello, " + user;
                GridViewTransactions.DataSource = NRVVclient.getTrans(user, token);
                GridViewTransactions.DataBind();
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