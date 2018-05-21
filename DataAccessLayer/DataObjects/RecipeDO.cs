using BusinessLayer.BusinessObjects;
using DataAccessLayer.DataBaseConnectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataObjects
{
    class RecipeDO : DataObject<Recipe>
    {
        public RecipeDO() : base() { }

        public RecipeDO(string connectionString) : base(connectionString) { }

        public override Recipe GetObjectByFilter<U>(string column, U filterValue)
        {
            throw new NotImplementedException();
        }

        public override void InsertObject(Recipe obj)
        {
            throw new NotImplementedException();
        }

        public override void UpdateObject(Recipe obj)
        {
            throw new NotImplementedException();
        }
    }
}
