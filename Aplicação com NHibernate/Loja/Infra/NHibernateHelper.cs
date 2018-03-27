using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Loja.Infra
{
    public class NHibernateHelper
    {

        //Isolando a sessão com o banco em um atributo estático...
        public static ISessionFactory session = AbreSession();
        
        public static ISessionFactory AbreSession()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            return cfg.BuildSessionFactory();
        }

        //Método para gerar configuração com  base de dados...
        public static Configuration RecuperaConfiguracao()
        {

            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            return cfg;

        }

        //Método para gerar as tabelas das entidades mapeadas...
        public static void GeraSchema()
        {
            Configuration cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, false);
        }

        public static ISession AbrirConexao()
        {
            // Com a atribuição da sessão a uma propriedade estática, possuo uma única 
            // sessão com a base de dados ao longo do ciclo do meu projeto...
            return session.OpenSession();

        }

        

    }
}
