using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework9
{
    public partial class Main : System.Web.UI.Page
    {
        NRVVref.NRVVservice NRVVclient;
        String token;
        NRVVref.Member thisUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            NRVVclient = new NRVVref.NRVVservice();
            String user = (String)Session["User"];
            token = (String)Session["Token"];
            thisUser = (NRVVref.Member)Session["Member"];

            if (user == null)
                Response.Redirect("Login.aspx");
            else
            {
                Session.Timeout = 60;
                LabelUser.Text = "Hello, " + user;
                LabelHeader.Text = user + "'s Profile";
                LabelFirstName.Text = thisUser.FirstName;
                LabelLastName.Text = thisUser.LastName;
                LabelCellPhone.Text = thisUser.CellPhone;
                LabelHomePhone.Text = thisUser.HomePhone;
                LabelEmail.Text = thisUser.Email;
                LabelDOB.Text = thisUser.DOB.ToString();
                LabelMomFName.Text = thisUser.MomFirstName;
                LabelMomLName.Text = thisUser.MomLastName;
                LabelMomCell.Text = thisUser.MomCellPhone;
                LabelDadFName.Text = thisUser.DadFirstName;
                LabelDadLName.Text = thisUser.DadLastName;
                LabelDadCell.Text = thisUser.DadCellPhone;
                LabelUSATFnum.Text = thisUser.USATFnum;
                LabelProof.Text = thisUser.ProofOfIns;
                LabelBalance.Text = thisUser.BalanceDue.ToString();
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

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transactions.aspx");
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }
    }
}