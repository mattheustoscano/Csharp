using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {

            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com");
            navegador.Anterior();
            navegador.Anterior();
            navegador.Proximo();


            Console.ReadKey();
        }
    }

    internal class Navegador
    {

        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        
        private string atual = "vazia";



        public Navegador()
        {
            Console.WriteLine("Página Atual: " + atual);

        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + atual);

            }
        }

        internal void NavegarPara(string url)
        {

            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Página Atual: " + url);
        }

        internal void Proximo()
        {


            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Página atual: " + atual);
            }



        }
    }
}
