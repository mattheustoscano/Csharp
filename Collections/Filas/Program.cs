using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class Program
    {

        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {


            //Adicionando uma van..
            pedagio.Enqueue("Van");

            //Adicionando uma Kombi..
            pedagio.Enqueue("Kombi");

            //Adicionando guincho;
            pedagio.Enqueue("Guincho");

            //Adicionando Pickup...
            pedagio.Enqueue("Pickup");

            Console.WriteLine("Fila:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\nSaindo da Fila\n");

            
            Console.WriteLine(pedagio.Dequeue());
            Console.WriteLine(pedagio.Dequeue());


            Console.WriteLine("\nPróximo a sair da fila\n");
            //Verificar o veículo que será o próximo a sair da fila...
            Console.WriteLine(pedagio.Peek());


            Console.ReadKey();

        }
    }
}
