using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Abstracoes;

namespace Projeto02.Controles
{
    public class PessoaControle : PessoaControleAbstract
    {

        public override void ImprimirDados(Pessoa p)
        {

            Console.WriteLine("\n - Dados da Pessoa \n");
            Console.WriteLine(p.ToString());
        }
        
    }
}
