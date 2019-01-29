using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using BO;

namespace Sachas_website.Account
{ 

    public partial class Login : System.Web.UI.Page
    {
        private LoginBO objLoginBO = new LoginBO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (objLoginBO.AuthenticateExitingUser(txtUserName.Text, txtPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkBoxRememberMe.Checked);
                Session["s_UserName"] = txtUserName.Text;
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid User Name and/or Password";
            }
        }
       
    }
}