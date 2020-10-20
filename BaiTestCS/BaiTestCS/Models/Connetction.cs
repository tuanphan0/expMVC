using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BaiTestCS.Models
{
    public class Connetction
    {
        string strcon;
        public Connetction() 
        {
            strcon = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;

        }
        public SqlConnection getConnection()
        {
            return new SqlConnection(strcon);
        }
    }
}