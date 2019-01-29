using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sachas_website
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s_cartcount"] != null)
            {
                HyperLink4.Text = "Cart " + "(" + Session["s_cartcount"].ToString() + ")";
            }
            if (Session["s_UserName"] != null)
            {
                lblUserName.Text = Session["s_UserName"].ToString();
                lblUserName.Visible = true;
                lbluser.Visible = true;
                HyperLink6.Visible = false;
                HyperLink7.Visible = false;
                btnSignOut.Visible = true;
            }
            else
            {
                HyperLink6.Visible = true;
                HyperLink7.Visible = true;
                btnSignOut.Visible = false;
                lblUserName.Visible = false;
                lbluser.Visible = false;
            }
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            (Session.Contents).Remove("s_UserName");
            Response.Redirect("~/Account/Login.aspx");
        }
    }
}