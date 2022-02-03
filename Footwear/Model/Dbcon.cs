using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Footwear.Model
{
    public class Dbcon
    {

        string ConnectionStr = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";

        public DataTable ViewDb(Dbprop dp)
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select ProductCode,Name,Cost  from FootWearDetails where Category = '{dp.Category}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public OrderProp Fetch(Dbprop dp)
        {
            OrderProp op = new OrderProp();
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select * from FootWearDetails where ProductCode = {dp.ProductCode} ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
             op.ProductCode = Convert.ToInt32(dt.Rows[0][0]);
             op.ProductName = dt.Rows[0][1].ToString();
             op.Price = Convert.ToInt32(dt.Rows[0][2]);
            return op;
        }
        public string Payment(OrderProp op)
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into FWOrderDetails values({op.ProductCode},'{op.ProductName}',{op.Price},{op.Quantity},{op.TotalAmount})", con); ;
            cmd.ExecuteNonQuery();
            con.Close();
            return "Succesfully saved";
        }

        public DataTable Status()
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select * from MyFootWareOrder", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}