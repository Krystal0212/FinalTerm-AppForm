using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FormApp
{
    public static class Connection
    {
        private static SqlConnection cn;
        public static void connect()
        {
            // DESKTOP-502NHKM\\DUNG
            // ACERLT
            string s = "initial catalog = distributorManage; data source = DESKTOP-502NHKM\\DUNG; integrated security = true; Min Pool Size=5;Max Pool Size=1000;Connect Timeout=60";
            cn = new SqlConnection(s);
            cn.Open();

        }

        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
