using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.DAL.Mappings;
using Projeto.DAL.Entities;
using System.Configuration;

namespace Projeto.DAL.Context
{
    public class DataContext : DbContext
    {

        public DbSet<Funcionario> Funcionario { get; set; }

        public DataContext()
            :base (ConfigurationManager.ConnectionStrings["Banco"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FuncionarioMap());
        }


    }
}
