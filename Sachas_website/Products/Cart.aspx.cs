using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sachas_website.Products
{
    public partial class cart : System.Web.UI.Page
    {
        protected DataTable dt = new DataTable();
        protected DataTable dtViewProducts = new DataTable();
        protected DataView CartView;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s_cartcount"] == null)
            {
                Label1.Visible = true;
                btnCheckOut.Visible = false;
            }
            else
            {
                if (Session["s_cartcount"].Equals("0"))
                {
                    Label1.Visible = true;
                    btnCheckOut.Visible = false;
                }
            }
            if (!IsPostBack)
            {
                if (Session["s_cartcount"] != null)
                {
                    if (!(Session["s_cartcount"].Equals("0")))
                    {
                        bindDataList();
                        btnCheckOut.Visible = true;
                        Label1.Visible = false;
                    }
                }
            }          
        }

        public void bindDataList()
        {           
            dt = (DataTable)Session["MyCart"];
            DataList1.DataSource = dt;
            DataList1.DataBind();
            sumdatatable(dt);           
        }   

        public void sumdatatable (DataTable dt)
        {
            if (dt != null)
            {
                int sum = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    sum += (Convert.ToInt32(dr["Price"])) * (Convert.ToInt32(dr["Quantity"]));
                }
                lblPrice.Text = " Total: $ "+sum.ToString();
                lblPrice.Visible = true;
            }
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {          
            (Session.Contents).Remove("s_cartcount");
            (Session.Contents).Remove("MyCart");
            Response.Redirect("~/Products/CheckOut.aspx");           
            
        }     

        public void Delete_Command(Object source, DataListCommandEventArgs e)
        {         
            String item = ((Label)e.Item.FindControl("ProductNameLabel")).Text;           
            dt = (DataTable)Session["MyCart"];
            CartView = new DataView(dt);
            CartView.RowFilter = "Name='" + item + "'";
            if (CartView.Count > 0)
            {
                CartView.Delete(0);
            }
            CartView.RowFilter = "";           
            DataList1.EditItemIndex = -1;
            DataList1.DataSource = CartView;
            DataList1.DataBind();          
            int abc = Convert.ToInt32(Session["s_cartcount"]);
            abc = abc - 1;
            if(abc==0)
            {
                (Session.Contents).Remove("s_cartcount");
                (Session.Contents).Remove("MyCart");
                (Session.Contents).RemoveAll();
                (Session.Contents).Clear();               
            }
            Session["s_cartcount"] = abc.ToString();         
            dt = CartView.ToTable();
            sumdatatable(dt);
        }
    }
}