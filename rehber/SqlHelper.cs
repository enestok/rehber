using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber
{
    public class SqlHelper
    {
        public static string ConnectionString()  //App.config den ConString i çektik..
        {
           return System.Configuration.ConfigurationManager.ConnectionStrings["rehber.Properties.Settings.tokDBConnectionString"].ConnectionString;
        }
        public static string ConnectionString(string key)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        public SqlConnection Connection()  //SqlHelper().Connection(); veritabanı bağlantısını gerçekleştiriyor..
        {
            SqlConnection conn = new SqlConnection("Data Source=ENESTOK\\ENESTOK;Initial Catalog=tokDB;Integrated Security=True");
            return conn;
        }
        public SqlDataReader DataReader(SqlConnection conn, string sqlCmd)
        {
            var cmd = new SqlCommand(sqlCmd, conn);
            var rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
