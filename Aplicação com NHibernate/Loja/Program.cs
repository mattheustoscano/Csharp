using Loja.Entidades;
using Loja.Infra;
using Loja.Repositorios;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            //Instanciando um objeto usuário...
            Usuario u = new Usuario();
            u.Nome = "Mattheus Toscano de Oliveira";


            //Gravando o usuário no banco...
            UsuarioRepositorio.Insert(u);*/


            // Listando todos os usuários cadastrados...

            /*foreach(Usuario u in UsuarioRepositorio.FindAll())
            {
                Console.WriteLine("Usuario Nº " + u.Id);
                Console.WriteLine("Nome: " + u.Nome);
                Console.WriteLine("--------------------------------------");
            }*/
            

            Usuario u = UsuarioRepositorio.FindById(1);

            Console.WriteLine("Usuario: " + u.Nome + ", Código: " + u.Id);
            
            Console.Read();

        }
    }
}
