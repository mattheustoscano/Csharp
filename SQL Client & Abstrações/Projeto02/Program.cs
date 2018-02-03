using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Controles;
using Projeto02.Abstracoes;
using Projeto02.Entidades;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p = new Pessoa(1, "Ana", "Feminino");
            Pessoa p2 = new Pessoa(2, "Rui", "Masculino");

            PessoaControleAbstract pc = new PessoaControle();

            pc.ImprimirDados(p);
            pc.ImprimirDados(p2);


        
            Console.ReadKey();

        }
    }
}
