using BusinessLayer.BusinessObjects;
using DataAccessLayer.DataBaseConnectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataObjects
{
    class TreatmentDO : DataObject<Treatment>
    {
        public TreatmentDO() : base() { }

        public TreatmentDO(string connectionString) : base(connectionString) { }

        public override Treatment GetObjectByFilter<U>(string column, U filterValue)
        {
            throw new NotImplementedException();
        }

        public override void InsertObject(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public override void UpdateObject(Treatment obj)
        {
            throw new NotImplementedException();
        }
    }
}
