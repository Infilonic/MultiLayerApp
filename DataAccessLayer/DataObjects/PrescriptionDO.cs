using BusinessLayer.BusinessObjects;
using DataAccessLayer.DataBaseConnectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataObjects
{
    class PrescriptionDO : DataObject<Prescription>
    {
        public PrescriptionDO() : base() { }

        public PrescriptionDO(string connectionString) : base(connectionString) { }

        public override Prescription GetObjectByFilter<U>(string column, U filterValue)
        {
            throw new NotImplementedException();
        }

        public override void InsertObject(Prescription obj)
        {
            throw new NotImplementedException();
        }

        public override void UpdateObject(Prescription obj)
        {
            throw new NotImplementedException();
        }
    }
}
