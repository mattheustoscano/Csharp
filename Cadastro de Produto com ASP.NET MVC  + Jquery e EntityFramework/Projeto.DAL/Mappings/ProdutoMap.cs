using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.DAL.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {

        public ProdutoMap()
        {


            ToTable("TbProduto");


            HasKey(p => p.IdProduto);

            Property(p => p.IdProduto).IsRequired();

            Property(p => p.Nome).IsRequired().HasMaxLength(100);

            Property(p => p.Preco).IsRequired().HasPrecision(18, 2);

            Property(p => p.Quantidade).IsRequired();


        }


    }
}
