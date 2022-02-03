using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Footwear.Model
{
    public class Dbprop
    {
        public int ProductCode { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Category { get; set; }
    }
}