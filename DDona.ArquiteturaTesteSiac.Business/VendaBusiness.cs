using DDona.ArquiteturaTesteSiac.DataTransferObject.Venda;
using DDona.ArquiteturaTesteSiac.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DDona.ArquiteturaTesteSiac.SqlBuilders.Venda;
using DDona.ArquiteturaTesteSiac.ReportAccess;

namespace DDona.ArquiteturaTesteSiac.Business
{
    public class VendaBusiness
    {
        public VendaBusiness()
        {

        }

        /// <summary>
        /// Entity
        /// </summary>
        /// <returns></returns>
        public List<Venda> GetAll()
        {
            using (SiacContext db = new SiacContext())
            {
                try
                {
                    return db.Vendas.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// Dapper
        /// </summary>
        /// <returns></returns>
        public List<VendaComValorTotalDTO> GetVendaComValorTotal()
        {
            VendaSQLBuilder SqlBuilder = new VendaSQLBuilder();
            string Sql = SqlBuilder.GetVendasComValorTotalCalculado();

            DataSystemAccess ds = new DataSystemAccess();
            try
            {
                return ds.Get<VendaComValorTotalDTO>(Sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
