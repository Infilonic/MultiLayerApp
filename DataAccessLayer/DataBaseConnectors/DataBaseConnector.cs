using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccessLayer.DataBaseConnectors
{
    interface DataBaseConnector<T> : DataProvider
    {
        T GetConnection(string connectionString);
    }
}
