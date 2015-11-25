using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.ArquiteturaTesteSiac.ReportAccess
{
    public class DataSystemAccess
    {
        public List<T> Get<T>(string SQL, object Param = null) where T : class
        {
            DapperWrapper Dapper = new DapperWrapper();
            return Dapper.Get<T>(SQL, Param);
        }
    }
}
