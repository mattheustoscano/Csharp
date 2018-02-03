using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controles;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {

            ClienteControle c = new ClienteControle();
            c.CadastrarCliente();

            Console.ReadKey();
        }
    }
}
