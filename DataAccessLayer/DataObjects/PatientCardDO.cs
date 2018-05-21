using BusinessLayer.BusinessObjects;
using DataAccessLayer.DataBaseConnectors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataObjects
{
    class PatientCardDO : DataObject<PatientCard>
    {
        public PatientCardDO() : base() { }

        public PatientCardDO(string connectionString) : base(connectionString) { }

        public override PatientCard GetObjectByFilter<U>(string column, U filterValue)
        {
            PatientCard pc = new PatientCard();
            using (SqlConnection connection = new SqlDataConnector().GetConnection(base.connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM patient_card WHERE @col = @val"
                };
                cmd.Parameters.Add(new SqlParameter("@col", column));
                cmd.Parameters.Add(new SqlParameter("@val", filterValue));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();

                this.PopulateObjectFields(pc);
            }

            return pc;
        }

        private PatientCard PopulateObjectFields(PatientCard pc /*, DATASET */)
        {
            //Code
            return pc;
        }

        public override void InsertObject(PatientCard obj)
        {
            throw new NotImplementedException();
        }

        public override void UpdateObject(PatientCard obj)
        {
            throw new NotImplementedException();
        }
    }
}
