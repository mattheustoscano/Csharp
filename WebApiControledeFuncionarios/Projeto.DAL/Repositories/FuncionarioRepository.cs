using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.Context;
using Projeto.DAL.Entities;
using System.Data.Entity;


namespace Projeto.DAL.Repositories
{
    public class FuncionarioRepository 
    {

        public void Insert(Funcionario f)
        {

            using (DataContext d = new DataContext())
            {

                d.Entry(f).State = EntityState.Added;

                d.SaveChanges();


            }


        }

        public void Update(Funcionario f)
        {

            using (DataContext d = new DataContext())
            {

                d.Entry(f).State = EntityState.Modified;

                d.SaveChanges();


            }


        }

        public void Delete(Funcionario f)
        {

            using (DataContext d = new DataContext())
            {

                d.Entry(f).State = EntityState.Deleted;

                d.SaveChanges();


            }


        }


        public Funcionario FindById(int id)
        {
            using (DataContext d = new DataContext())
            {

                return d.Funcionario.Find(id);


            }

        }


        public List<Funcionario> FindByName(string nome)
        {

            using (DataContext d = new DataContext())
            {


                return d.Funcionario
                        .Where(f => f.Nome.Contains(nome))
                        .OrderBy(f => f.Nome)
                        .ToList();

            }


        }


        public List<Funcionario> FindAll()
        {

            using (DataContext d = new DataContext())
            {

                return d.Funcionario.ToList();

            }


        }



    }
}
