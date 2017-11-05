using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Configuration;
using System.Data.Entity;
using Projeto.DAL.Mappings;


namespace Projeto.DAL.Context
{
    public class DataContext : DbContext
    {

        public DbSet<Produto> Produto { get; set; }


        public DataContext()

            :base(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString)
        {




        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
        }

    }
}
