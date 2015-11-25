using DDona.ArquiteturaTesteSiac.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.ArquiteturaTesteSiac.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VendaBusiness VendaBusiness = new VendaBusiness();

            var vendas = VendaBusiness.GetAll();

            foreach (var venda in vendas)
            {
                Console.WriteLine("Código: {0} - Data: {1}", venda.Codigo, venda.Data);
            }

            var vendasDTO = VendaBusiness.GetVendaComValorTotal();
        }
    }
}
