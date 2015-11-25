using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.ArquiteturaTesteSiac.DataTransferObject.Venda
{
    public class VendaQuantidadeItensDTO
    {
        public int Codigo { get; set; }
        public int QuantidadeItens { get; set; }
        public decimal PrecoMedio { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
