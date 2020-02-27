using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework9
{
    public partial class Edit : System.Web.UI.Page
    {
        NRVVref.NRVVservice NRVVclient;
        String token;
        NRVVref.Member member;

        protected void Page_Load(object sender, EventArgs e)
        {
            NRVVclient = new NRVVref.NRVVservice();
            String user = (String)Session["User"];
            token = (String)Session["Token"];
            member = (NRVVref.Member)Session["Member"];

            if (user == null)
                Response.Redirect("Login.aspx");
            else
            {
                Session.Timeout = 60;
                LabelUser.Text = "Hello, " + user;

                if (Page.IsPostBack == false)
                {
                    TextBoxFirstName.Text = member.FirstName;
                    TextBoxLastName.Text = member.LastName;
                    TextBoxCellPhone.Text = member.CellPhone;
                    TextBoxHomePhone.Text = member.HomePhone;
                    TextBoxEmail.Text = member.Email;
                    TextBoxDOB.Text = member.DOB.ToString();
                    TextBoxMomFName.Text = member.MomFirstName;
                    TextBoxMomLName.Text = member.MomLastName;
                    TextBoxMomCell.Text = member.MomCellPhone;
                    TextBoxDadFName.Text = member.DadFirstName;
                    TextBoxDadLName.Text = member.DadLastName;
                    TextBoxDadCell.Text = member.DadCellPhone;
                    TextBoxUSATFnum.Text = member.USATFnum;
                }
                else
                {
                    try
                    {
                        member.FirstName = TextBoxFirstName.Text;
                        member.LastName = TextBoxLastName.Text;
                        member.CellPhone = TextBoxCellPhone.Text;
                        member.HomePhone = TextBoxHomePhone.Text;
                        member.Email = TextBoxEmail.Text;
                        member.DOB = DateTime.Parse(TextBoxDOB.Text);
                        member.MomFirstName = TextBoxMomFName.Text;
                        member.MomLastName = TextBoxMomLName.Text;
                        member.MomCellPhone = TextBoxMomCell.Text;
                        member.DadFirstName = TextBoxDadFName.Text;
                        member.DadLastName = TextBoxDadLName.Text;
                        member.DadCellPhone = TextBoxDadCell.Text;
                        member.USATFnum = TextBoxUSATFnum.Text;

                        String result = NRVVclient.saveMember(member, token);

                        if (result.Equals("SUCCESS"))
                        {
                            Session["Member"] = member;
                            Response.Redirect("Main.aspx");
                        }
                        else
                            LabelMsg.Text = "Error: " + result;
                    }
                    catch(Exception)
                    {
                        LabelMsg.Text = "Error: Date of Birth formatted incorrectly";
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