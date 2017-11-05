using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entidades;
using Projeto.DAL.Context;

namespace Projeto.DAL.Repositories
{
    public class ProdutoRepository
    {

        public void Insert (Produto p)
        {

            using (DataContext d = new DataContext())
            {

                d.Entry(p).State = EntityState.Added;

                d.SaveChanges();

            } 



        }




    }
}
