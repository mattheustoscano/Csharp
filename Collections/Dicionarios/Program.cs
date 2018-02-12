using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciando um Diciário...
            IDictionary<int,string> alunos = new Dictionary<int, string>();

            //Um dicionário precisa de uma chave para atribuir em sua coleção...
            //Isso resulta em uma maior eficiencia na busca do dado...

            //Adicionanando elementos no dicionário...

            alunos.Add(1, "Mattheus");
            alunos.Add(2, "Lucas");
            alunos.Add(3, "Gabriel");
            alunos.Add(4, "João");

            // Buscando elementos pela chave...
            Console.WriteLine(alunos[3]);

            // Método para tratar erro, caso não encontre...
            var retorno = string.Empty;
            Console.WriteLine(alunos.TryGetValue(5, out retorno));

            //Substituir elemento através da chave..
            alunos[3] = "Fernando";

            Console.WriteLine(alunos[3]);



            Console.ReadKey();








        }
    }
}
