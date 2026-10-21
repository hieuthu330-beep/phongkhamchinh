using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Data.SqlTypes;

namespace phongkham1
{
    internal class ConnectDB
    {
        private string connection;
        public ConnectDB()
        {
            connection = "Data Source=DESKTOP-5DN4UA9\\SQLEXPRESS;Initial Catalog=PhongKhamDB;User ID=sa;Password=1906;Trust Server Certificate=True";
        }
        public DataTable readdata(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr, LoadOption.OverwriteChanges);
                if (dt.Rows.Count == 0)
                {
                    conn.Close();
                    return null;
                }
                conn.Close();
            }
            catch
            {
                conn.Close();
                return null;
            }

            return dt;
        }
        public int writedata(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int roweffect = -1;
            try
            {
                conn.Open();
                roweffect = cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {
                conn.Close();
                return -1;
            }

            return roweffect;
        }
    }
}
