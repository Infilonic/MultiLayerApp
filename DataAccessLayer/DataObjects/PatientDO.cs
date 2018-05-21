using BusinessLayer.BusinessObjects;
using DataAccessLayer.DataBaseConnectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataObjects
{
    class PatientDO : DataObject<Patient>
    {
        public PatientDO() { }

        public PatientDO(string connectionString) : base(connectionString) { }

        public override Patient GetObjectByFilter<U>(string column, U filterValue)
        {
            throw new NotImplementedException();
        }

        public override void InsertObject(Patient obj)
        {
            throw new NotImplementedException();
        }

        public override void UpdateObject(Patient obj)
        {
            throw new NotImplementedException();
        }
    }
}
