using DDona.ArquiteturaTesteSiac.SqlBuilders.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.ArquiteturaTesteSiac.SqlBuilders.Venda
{
    public class VendaSQLBuilder
    {
        private VendaSQLContainer _sqlContainer = null;

        public VendaSQLBuilder()
        {
            _sqlContainer = new VendaSQLContainer();
        }

        public string GetVendasComValorTotalCalculado()
        {
            return _sqlContainer.VendasComValorTotalCalculado;
        }

        public string GetVendasQuantidadeItens(bool? Minimo = null, bool? Maximo = null)
        {
            StringBuilder sbHaving = new StringBuilder();
            StringBuilder sbWhere = new StringBuilder();

            #region HAVING
            if (Minimo.GetValueOrDefault())
            {
                sbHaving.AppendLine(" COUNT(IV.Codigo) > @Minimo ");
            }

            if (Maximo.GetValueOrDefault(false))
            {
                if (sbHaving.Length > 0)
                {
                    sbHaving.Append(" AND ");
                }

                sbHaving.AppendLine(" COUNT(IV.Codigo) < @Maximo ");
            } 
            #endregion

            //WHERE NÃO IMPLEMENTADO AINDA

            return _sqlContainer.VendasQuantidadeItens
                .Replace("{HAVING}", sbHaving.ToString())
                .Replace("{WHERE}", sbWhere.ToString());

        }
    }
}
