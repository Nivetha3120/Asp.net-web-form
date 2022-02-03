using Footwear.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Footwear
{
    public partial class OrderDetails : System.Web.UI.Page
    {

        Dbprop dp = new Dbprop();
        Dbcon con = new Dbcon();

        protected void Page_Load(object sender, EventArgs e)
        {
            Dbcon con = new Dbcon();

            if (!IsPostBack)
            {
                lblProductCode.Text = "" + Session["value"];
                dp.ProductCode = Convert.ToInt32(Session["value"]);
                OrderProp op = con.Fetch(dp);

                lblProductName.Text = op.ProductName;
                lblPrice.Text = op.Price.ToString();
            }

        }

        protected void btnBill_Click(object sender, EventArgs e)
        {

            dp.ProductCode = Convert.ToInt32(Session["value"]);

            OrderProp op = con.Fetch(dp);
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            lblTotalAmount.Text = Convert.ToString(op.Price * Quantity);

        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            OrderProp op = new OrderProp();
            op.ProductCode = Convert.ToInt32(lblProductCode.Text);
            op.ProductName = lblProductName.Text;
            op.Price = Convert.ToInt32(lblPrice.Text);
            op.Quantity = Convert.ToInt32(txtQuantity.Text);
            op.TotalAmount = Convert.ToInt32(lblTotalAmount.Text);
            string msg = con.Payment(op);
            Response.Write($"<script>alert('{msg}')</script>");
        }
    }
}