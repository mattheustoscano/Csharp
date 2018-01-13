using Projeto01.Controles;
using Projeto01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {

                Produto p = new Produto();

                p.IdProduto = 1;
                p.Nome = "Teclado";
                p.Preco = 50.0m;
                p.Quantidade = 45;

                ProdutoControle.GerarXML(p);

                Console.WriteLine("Arquivo gerado com sucesso!!");

            }
            catch (Exception e)
            {

                Console.WriteLine("Erro ao gerar arquivo: " + e.Message);
                
            }


            Console.ReadKey();

        }
    }
}
