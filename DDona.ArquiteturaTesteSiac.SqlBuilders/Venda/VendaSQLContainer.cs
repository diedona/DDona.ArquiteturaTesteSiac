using DDona.ArquiteturaTesteSiac.SqlBuilders.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.ArquiteturaTesteSiac.SqlBuilders.Venda
{
    public class VendaSQLContainer : ISQLContainer
    {
        public readonly string VendasComValorTotalCalculado = @"
                SELECT		V.Codigo,
			                V.Desconto,
			                SUM(IV.Quantidade * IV.ValorProduto) ValorTotal
                FROM		VENDA V
                INNER JOIN	ITEMVENDA IV ON V.Codigo = IV.VendaCodigo
                GROUP BY	V.Codigo, V.Desconto
        ";

        public readonly string AjustarValorTotalVendas = @"
                UPDATE	V
                SET		ValorTotal = 
		                (
			                SELECT SUM(IV.Quantidade * IV.ValorProduto) 
			                FROM ItemVenda IV WHERE IV.VendaCodigo = V.Codigo
		                )
                FROM	VENDA V
        ";

        public readonly string VendasQuantidadeItens = @"
                SELECT		V.Codigo,
			                COUNT(IV.Codigo) QtdItens,
			                AVG(IV.ValorProduto) PrecoMedio,
			                V.ValorTotal
                FROM		VENDA V
                INNER JOIN	ITEMVENDA IV ON V.Codigo = IV.VendaCodigo
                {WHERE}
                GROUP BY	V.Codigo, V.ValorTotal
                {HAVING}
        ";
    }
}
