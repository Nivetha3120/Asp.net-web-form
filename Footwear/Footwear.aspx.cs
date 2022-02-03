using Footwear.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Footwear
{
    public partial class Footwear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Viewbtn_Click(object sender, EventArgs e)
        {
            Dbprop dp = new Dbprop();
            Dbcon dc = new Dbcon();
            dp.Category = Category.SelectedValue;
            DataTable dt = new DataTable();
            dt = dc.ViewDb(dp);
            GView.DataSource = dt;
            GView.DataBind();
            div1.Visible = true;
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Session["value"] = txtProductCode.Text;
            Response.Redirect("OrderDetails.aspx");
        }

        protected void StatusButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Status.aspx");
        }
    }
}