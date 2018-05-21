using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataObjects
{
    abstract class DataObject<T>
    {
        protected string connectionString;

        protected DataObject() : this("test") { }

        protected DataObject(string connectionString)
        {
            this.SetConnectionString(connectionString);
        }

        public abstract T GetObjectByFilter<U>(string column, U filterValue);

        public abstract void InsertObject(T obj);

        public abstract void UpdateObject(T obj);

        public void SetConnectionString(string connectionString, string dataSource = "", string initialCatalog = "", string userID = "", string password = "")
        {
            var builder = new SqlConnectionStringBuilder(connectionString);

            if (!string.IsNullOrEmpty(dataSource))
            {
                builder.DataSource = dataSource;
            }

            if (!string.IsNullOrEmpty(initialCatalog))
            {
                builder.InitialCatalog = initialCatalog;
            }

            if (!string.IsNullOrEmpty(userID))
            {
                builder.UserID = userID;
            }

            if (!string.IsNullOrEmpty(password))
            {
                builder.Password = password;
            }

            this.connectionString = connectionString;
        }
    }
}
