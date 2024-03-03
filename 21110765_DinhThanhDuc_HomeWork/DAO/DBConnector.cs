using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110765_DinhThanhDuc_HomeWork.DAO
{
    internal class DBConnector
    {


        private string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QLNV;Trusted_Connection=True;";


        public void excecuteSqlCommand(string sqlQuery, Action<SqlCommand> action)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
            {
                action(cmd);
                try
                {
                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    MessageBox.Show(res > 0 ? "Successful operation" : "Operation unsuccessful, please try again!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sqlQuery, ex.Message);
                }
            }
        }
        public DataTable loadData(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                {
                    try
                    {
                        conn.Open();
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return dataTable;
            }
        }
    }
}
