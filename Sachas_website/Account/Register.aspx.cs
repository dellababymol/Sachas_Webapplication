using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;

namespace Sachas_website.Account
{
    public partial class Register : System.Web.UI.Page
    {
        private RegisterBO objRegisterBO = new RegisterBO();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (objRegisterBO.validateBOUserName(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text,txtEmail.Text))                    
            {
                Response.Redirect("~/Account/Login.aspx");               
            }
            else
            {
                lblMessage.Text = "User Name already in use, please choose another user name";
            }
        }
    }
}