using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Projeto.Entidades;

namespace Projeto.DAL.Infra
{
    public class NhibernateHelper
    {


        //atributos neessários para minha connection string...
        private const string server = "localhost";
        private const string database = "aspnet";
        private const string username = "root";
        private const string password = "1234";

        //Retorna a sessão que utilizarei para operações de crud...
        public static ISessionFactory GetSessionFactory()
        {

            //Crio a configuração...
            var configuration = Fluently.Configure()
                           .Database(
                            MySQLConfiguration
                            .Standard
                            .ConnectionString(cs => cs
                            .Server(server)
                            .Database(database)
                            .Username(username)
                            .Password(password)).ShowSql())
                            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                            .BuildConfiguration();

                            
                
                            //Crio a tabela no banco se ela não existir...
                            var exporter = new SchemaUpdate(configuration);
                            
                            exporter.Execute(false, true);


            //Retorno a sessão...
            return configuration.BuildSessionFactory();
        }

    }
}
