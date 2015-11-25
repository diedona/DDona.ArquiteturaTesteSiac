using DDona.ArquiteturaTesteSiac.DataTransferObject.Venda;
using DDona.ArquiteturaTesteSiac.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using DDona.ArquiteturaTesteSiac.SqlBuilders.Venda;

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
            using(SiacContext db = new SiacContext())
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
            string connection = @"Server=.\SQLExpress;Database=Teste;User Id=sa;Password=sqlexpress;MultipleActiveResultSets=true;";
            VendaSQLBuilder vendaSQLBuilder = new VendaSQLBuilder();

            using(IDbConnection db = new SqlConnection(connection))
            {
                return db.Query<VendaComValorTotalDTO>(vendaSQLBuilder.GetVendasComValorTotalCalculado()).ToList();
            }
        }
    }
}
