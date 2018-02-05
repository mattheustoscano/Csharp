using Listas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Controles
{
    public static class ListaControle
    {

        public static void ImprimirLista(List<string> Lista)
        {
            // Imprimindo a Lista...
            foreach (string s in Lista)
            {
                Console.WriteLine("\n"+s);
            }

        }

        public static void ImprimirListaGenerica(List<Aula> Lista)
        {
            // Imprimindo a Lista...
            foreach (Aula s in Lista)
            {
                Console.WriteLine("\n" + s);
            }

        }

    }
}
