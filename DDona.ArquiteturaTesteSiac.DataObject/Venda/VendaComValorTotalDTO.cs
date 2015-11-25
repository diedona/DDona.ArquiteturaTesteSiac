using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.ArquiteturaTesteSiac.DataTransferObject.Venda
{
    public class VendaComValorTotalDTO
    {
        public int Codigo { get; set; }
        public decimal? Desconto { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
