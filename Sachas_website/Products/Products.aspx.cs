using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BO;

namespace Sachas_website.Products
{
    public partial class Products : System.Web.UI.Page
    {
        private ProductsBO objProductsBO = new ProductsBO();
        private DataTable dtViewProducts = new DataTable();
        private int sum = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {               
                objProductsBO.GetData();
            }
        }       

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            string ProductID = ((LinkButton)sender).CommandArgument;
            int P = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            DataListItem currentItem = (sender as LinkButton).NamingContainer as DataListItem;           
            DropDownList dd = (DropDownList)currentItem.FindControl("DropDownList1");
            string ProductQuantity = dd.SelectedValue;
            string itemName = ((Label)currentItem.FindControl("ProductNameLabel")).Text;
            string itemPrice = ((Label)currentItem.FindControl("ProductPriceLabel")).Text;

            if (Session["MyCart"] != null)
            {
                dtViewProducts = (DataTable)Session["MyCart"];                 
                DataTable dtProducts = objProductsBO.GetValue(ProductID);
                DataRow dr = dtViewProducts.NewRow();
                dr["ProductId"] = ProductID;
                dr["Name"] = Convert.ToString(dtProducts.Rows[0]["ProductName"]);
                dr["Price"] = Convert.ToString(dtProducts.Rows[0]["ProductPrice"]);
                dr["ImageUrl"] = Convert.ToString(dtProducts.Rows[0]["ProductImage"]);
                dr["Quantity"] = ProductQuantity;
                dtViewProducts.Rows.Add(dr);
                Session["MyCart"] = dtViewProducts;  
                foreach (DataRow dre in dtViewProducts.Rows)
                {
                    sum += Convert.ToInt32(dre["Quantity"]);
                }
                lblCart.Text = sum.ToString();
                Session["s_cartcount"] = lblCart.Text;
                LinkButton bt = (LinkButton)currentItem.FindControl("LinkButton1");
                bt.Text = "Added To Cart";
                bt.Enabled = false;
                DropDownList ddl = (DropDownList)currentItem.FindControl("DropDownList1");
                ddl.Enabled = false;
                bt.BackColor = System.Drawing.Color.Gold; 
            }

            else
            {              
                DataTable dtProducts = objProductsBO.GetValue(ProductID);
                DataTable dt = new DataTable();
                dt.Columns.Add("ProductId", typeof(string));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Price", typeof(string));
                dt.Columns.Add("ImageUrl", typeof(string));
                dt.Columns.Add("Quantity", typeof(string));
                DataRow dr = dt.NewRow();
                dr["ProductId"] = ProductID;
                dr["Name"] = Convert.ToString(dtProducts.Rows[0]["ProductName"]);
                dr["Price"] = Convert.ToString(dtProducts.Rows[0]["ProductPrice"]);
                dr["ImageUrl"] = Convert.ToString(dtProducts.Rows[0]["ProductImage"]);
                dr["Quantity"] = ProductQuantity;
                dt.Rows.Add(dr);
                Session["MyCart"] = dt;
                foreach (DataRow dre in dt.Rows)
                {
                    sum += Convert.ToInt32(dre["Quantity"]);
                }
                lblCart.Text = sum.ToString();
                Session["s_cartcount"] = lblCart.Text;
                LinkButton bt = (LinkButton)currentItem.FindControl("LinkButton1");
                bt.Text = "Added To Cart";
                bt.Enabled = false;
                DropDownList ddl = (DropDownList)currentItem.FindControl("DropDownList1");
                ddl.Enabled = false;
                bt.BackColor = System.Drawing.Color.Gold;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products/Cart.aspx");
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            string ProductID = ((LinkButton)sender).CommandArgument;
            DataListItem currentItem = (sender as LinkButton).NamingContainer as DataListItem;
            if (Session["MyCart"] != null)
            {
                dtViewProducts = (DataTable)Session["MyCart"];
            }         

            for (int i = dtViewProducts.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dtViewProducts.Rows[i];
                if (dr["ProductId"].ToString() == ProductID)
                {
                    dr.Delete();
                    dtViewProducts.AcceptChanges();
                }
            }

            Session["MyCart"] = dtViewProducts;
            LinkButton bt = (LinkButton)currentItem.FindControl("LinkButton1");
            bt.Text = "Add To Cart";
            bt.Enabled = true;
            bt.BackColor = System.Drawing.Color.Empty;
            DropDownList ddl = (DropDownList)currentItem.FindControl("DropDownList1");
            ddl.Enabled = true;
            ddl.SelectedValue = "1";
            foreach (DataRow dre in dtViewProducts.Rows)
            {
                sum += Convert.ToInt32(dre["Quantity"]);
            }
            lblCart.Text = sum.ToString();
            Session["s_cartcount"] = lblCart.Text;
        }
    }
}