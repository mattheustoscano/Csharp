using Loja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Infra;
using NHibernate;

namespace Loja.Repositorios
{
    public class UsuarioRepositorio
    {
        
        //Método para inserir um usuário no banco...
        public static void Insert(Usuario u)
        {
            //Abrindo conexão com a base de dados...
            ISession session = NHibernateHelper.AbrirConexao();

            //Iniciando uma transação...
            ITransaction transaction = session.BeginTransaction();

            //Salvando o usuário na base de dados...
            session.Save(u);

            //Comitando o meu insert...
            transaction.Commit();
            
            //Fechando conexão com a base de dados...
            session.Close();

        }


        //Método para retornar um usuário pelo Id
        public static Usuario FindById(int id)
        {
            //Abro conexão...
            ISession session = NHibernateHelper.AbrirConexao();

            //Executo o método do nhibernate para buscar usuário pelo id...
            Usuario u  = session.Get<Usuario>(id);

            // Fecho conexão...
            session.Close();

            //Retorno o usuário...
            return u;
        }


        //Método para Deletar o usuário do banco...
        public static void Delete(Usuario u)
        {
            //Abro conexão...
            var session = NHibernateHelper.AbrirConexao();

            //Método do nhibernate para remover objetos...
            session.Delete(u);

            //Fecho conexão...
            session.Close();

        }


        public static void Update(Usuario u)
        {
            //Abro conexao...
            var session = NHibernateHelper.AbrirConexao();
            //Executo o método para atualizar dados no nhibernate...
            session.Update(u);
            //Encerro conexao...
            session.Close();
        }

        public static List<Usuario> FindAll()
        {
            //Abro conexao...
            var session = NHibernateHelper.AbrirConexao();

            var lista = session.QueryOver<Usuario>().List();

            session.Close();

            return lista as List<Usuario>;

        }


    }
}
