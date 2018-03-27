using NHibernate;
using Projeto.DAL.Infra;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Repositories
{
    public class ProdutoRepository
    {
        //API do NHibernate
        private ISession session;           //conexão com o banco de dados
        private ITransaction transaction;   //transações (commit / rollback)
        private ICriteria criteria;         //consultas...


        public ProdutoRepository()
        {
            session = NhibernateHelper.GetSessionFactory().OpenSession();
        }

        public void Insert(Produto p)
        {
            //Adiciono o produto...
            session.Save(p);
        }

        public void Update(Produto p)
        {
            //Atualizo o produto...
            session.Update(p);
        }

        public void Delete(Produto p)
        {
            //Deleto o produto...
            session.Delete(p);
        }

        public Produto FindById(int id)
        {
            //Retorno um produto pelo id...
            return session.Get<Produto>(id);
        }

        public IList<Produto> FindAll()
        {
            //Retorno uma lista de produtos...
            var query = session.QueryOver<Produto>()
                               .OrderBy(p => p.IdProduto)
                               .Asc.List<Produto>();

            return query;
            
        }

        public IList<Produto> FindByNome(string nome)
        {
            var resultado = session.QueryOver<Produto>()
                                   .WhereRestrictionOn(p => p.Nome) // cláusula where no nhibernate...
                                   .IsLike(nome) // like
                                   .List<Produto>();

            return resultado;

        }

    }
}
