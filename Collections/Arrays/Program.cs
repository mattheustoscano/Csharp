using Arrays.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {




            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";


            //Criando um array com valores pré definidos...
            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets

            };

            //Criando um array com tamanho já definido em preenchendo em tempo de execução...
            string[] aulas2 = new string[3];

            aulas2[0] = aulaIntro;
            aulas2[1] = aulaModelando;
            aulas2[2] = aulaSets;

            // Imprimindo Array I com um foreach...
            Console.WriteLine("\n - Array I - \n");
            ArrayControle.ImprimirComForEach(aulas);


            // Imprimindo Array II com um for ...
            Console.WriteLine("\n - Array II - \n");
            ArrayControle.ImprimirComFor(aulas2);


            // Pegando o indice de um array por um determinado elemento...
            Console.WriteLine("\n Array aulas - Resgate por indice\n Aula Modelando está no indice: " + Array.IndexOf(aulas, aulaModelando));

            //Invertendo Dados...
            Array.Reverse(aulas);

            //Voltando com a ordem..
            Array.Reverse(aulas);

            //Reduzindo o tamanho de um array...
            Array.Resize(ref aulas, 2);

            //Voltando o tamanho original...
            Array.Resize(ref aulas, 3);

            //Populando o valor final...
            aulas[aulas.Length - 1] = "Conclusão";

            //Ordenando o meu Array...
            Array.Sort(aulas);

            //copiando um array pegando valores do array aulas a partir do elemento 1...
            string[] copia = new string[2];

            Array.Copy(aulas, 1, copia, 0, 2);

            //Clonando um array...
            string[] clone = aulas.Clone() as string[];


            //Limpando elementos de um array...
            Array.Clear(clone, 1, 2);



            Console.ReadKey();


        }
    }
}
