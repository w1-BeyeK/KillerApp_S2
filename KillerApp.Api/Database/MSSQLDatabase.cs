using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KillerApp.Api.Interface;

namespace KillerApp.Api.Database
{
    public class MSSQLDatabase : IDatabaseFunctions
    {
        private readonly string conn;
        public string GetConnection()
        {
            return conn;
        }

        public MSSQLDatabase(string conn)
        {
            this.conn = conn;
        }

        public DataTable ExecSelect(string query)
        {
            DataSet ds = new DataSet();
            SqlConnection sqlConnection = new SqlConnection(conn);
            ds.Clear();
            using (SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection))
            {
                da.Fill(ds);
            }
            return ds.Tables[0];
        }

        public bool ExecOther(string query)
        {
            bool success = true;

            SqlConnection sqlConnection = new SqlConnection(conn);
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
