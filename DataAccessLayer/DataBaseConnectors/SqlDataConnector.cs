using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataBaseConnectors
{
    class SqlDataConnector : DataBaseConnector<SqlConnection>
    {
        public SqlDataConnector() : base() { }

        public SqlConnection GetConnection(string connectionString)
        {
            return this.GetConnection(connectionString);
        }

        public SqlConnection GetConnection(string connectionString, string dataSource = "", string initialCatalog = "", string userID = "", string password = "")
        {
            var builder = new SqlConnectionStringBuilder(connectionString);

            var connection = new SqlConnection(builder.ConnectionString);

            return connection;
        }
    }
}
