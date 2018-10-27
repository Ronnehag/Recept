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
        private const string ConnectionString =
            "Data Source=(local);Initial Catalog=Food;Integrated Security=SSPI";

        public DataTable GetTableFromSql(string sqlCode)
        {
            DataTable table;
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter(sqlCode, connection);
                table = new DataTable();
                adapter.Fill(table);
            }
            return table;

        }


    }

}




