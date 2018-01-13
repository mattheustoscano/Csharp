using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Produto
    {

        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
