using FluentNHibernate.Mapping;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Mappings
{
    //Mapeando a Entidade Produto...
    public class ProdutoMap : ClassMap<Produto>
    {


        public ProdutoMap()
        {
            //Defino o nome da tabela...
            Table("TbProduto");

            //Definindo minha chave primária e tornando auto incremento...
            Id(p => p.IdProduto, "IdProduto").GeneratedBy.Identity();

            //Mapeando cada atributo da minha entidade...
            Map(p => p.Nome, "Nome").Length(100).Not.Nullable();
            Map(p => p.Preco, "Preco").Not.Nullable();
            Map(p => p.Quantidade, "Quantidade").Not.Nullable();


        }



    }
}
