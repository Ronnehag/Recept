using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uppgift_1
{
    public class DbManager
    {
        private readonly string _connectionString;
        private readonly string _sql;

        public DbManager(string sql)
        {
            _connectionString = "Data Source=(local);Initial Catalog=Food;Integrated Security=SSPI";
            _sql = sql;
        }

        public DataTable GetTableFromSql()
        {
            var table = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter(_sql, connection);
                adapter.Fill(table);
            }
            return table;
        }

        public void ExecuteSqlNoReturn()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(_sql, connection);
                cmd.ExecuteNonQuery();
            }
        }


    }

}




