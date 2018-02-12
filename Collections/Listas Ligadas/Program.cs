using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Ligadas
{
    class Program
    {
        static void Main(string[] args)
        {



            //Lista Simples...
            List<string> frutas = new List<string>();

            frutas.Add("Abacate");
            frutas.Add("Banana");
            frutas.Add("Morango");

            //Lista Ligada...
            //Elementos não precisam estar em sequência em memória...
            //Cada elemento é um nó que contém um valor...
            //Cada elemento tem um apontamento que indica quem vem antes e depois...

            //Instanciando uma Lista Ligada...
            LinkedList<string> dias = new LinkedList<string>();


            //Adicionando elementos...
            //Ao adicionar um elemento é retornando um nó
            //Adicionar o primeiro nó
            var d4 = dias.AddFirst("Quarta");

            //Imprimindo o valor do nó
            Console.WriteLine(d4.Value);

            Console.WriteLine("#### Dias da Semana ####\n");


            //Adicionando um nó antes do d4;
            var d2 = dias.AddBefore(d4, "Segunda");
            //Agora os nós estão ligados...

            //Para pegar o próximo nó -> d2.next;

            //Adicionando um nó após outro..
            var d3 = dias.AddAfter(d2, "Terça");

            //Com isso nossa lista atual está -> d2 -> d3 -> d4...


            var d6 = dias.AddAfter(d4, "Sexta");
            //-> d2 -> d3 -> d4 -> d6 ->

            var d7 = dias.AddAfter(d6, "Sábado");
            //-> d2 -> d3 -> d4 -> d6 -> d7 ->

            var d5 = dias.AddBefore(d6, "Quinta");
            //-> d2 -> d3 -> d4 -> d5 -> d6 -> d7 ->

            var d1 = dias.AddBefore(d2, "Domingo");
            //-> d1 -> d2 -> d3 -> d4 -> d5 -> d6 -> d7 ->

            foreach (var no  in dias)
            {
                Console.WriteLine(no);
            }


            //removendo um item da lista...
            dias.Remove("Quinta");


            Console.ReadKey();













        }
    }
}
