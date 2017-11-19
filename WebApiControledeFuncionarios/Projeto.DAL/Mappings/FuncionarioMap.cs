using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.DAL.Entities;

namespace Projeto.DAL.Mappings
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {


        public FuncionarioMap()
        {

            ToTable("TbFuncionario");


            HasKey(f => f.IdFuncionario);


            Property(f => f.IdFuncionario).IsRequired();

            Property(f => f.Nome).IsRequired().HasMaxLength(100);

            Property(f => f.Salario).IsRequired().HasPrecision(18, 2);

            Property(f => f.DataAdmissao).IsRequired();



        }



    }
}
