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
    public partial class Status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dbcon con = new Dbcon();
            DataTable dt = new DataTable();
            dt = con.Status();
            StatusView.DataSource = dt;
            StatusView.DataBind();
        }

       
    }
}