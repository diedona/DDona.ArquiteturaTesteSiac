using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DDona.ArquiteturaTesteSiac.ReportAccess
{
    public class DapperWrapper : IDisposable
    {
        private string ConnectionString { get; set; }

        public DapperWrapper(string ConnectionName = "SiacContext")
        {
            try
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["SiacContext"].ConnectionString;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> Get<T>(string SQL) where T : class
        {
            using(IDbConnection db = new SqlConnection(this.ConnectionString))
            {
                return db.Query<T>(SQL).ToList();
            }
        }


        public void Dispose()
        {
            this.Dispose();
        }
    }
}
