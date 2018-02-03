using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Repositorios;


namespace Projeto01.Controles
{
    public class ClienteControle
    {


        // método para inserir um cliente na base de dados...

        public void CadastrarCliente()
        {


            try
            {

                Console.WriteLine("\n - CADASTRO DE CLIENTE - \n");

                Cliente c = new Cliente();

                c.Endereco = new Endereco();

                Console.Write("Nome do Cliente...: ");
                c.Nome = Console.ReadLine();
                Console.Write("Email do Cliente..: ");
                c.Email = Console.ReadLine();
                Console.Write("Logradouro........: ");
                c.Endereco.Logradouro = Console.ReadLine();
                Console.Write("Bairro............: ");
                c.Endereco.Bairro = Console.ReadLine();
                Console.Write("Estado............: ");
                c.Endereco.Estado = Console.ReadLine();
                Console.Write("Cidade............: ");
                c.Endereco.Cidade = Console.ReadLine();
                Console.Write("CEP...............: ");
                c.Endereco.Cep = Console.ReadLine();


                ClienteRepositorio rep = new ClienteRepositorio();

                rep.Insert(c);

                Console.WriteLine("\n Cliente Cadastrado com Sucesso.\n");

                // imprimir todos os clientes....

                foreach(Cliente cliente in rep.FindAll())
                {
                    Console.WriteLine(cliente.ToString());
                    Console.WriteLine(cliente.Endereco.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }


        }
    }
}
