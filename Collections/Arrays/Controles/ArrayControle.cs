using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Controles
{
    public static class ArrayControle
    {

        public static void ImprimirComFor(string[] array)
        {

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

        }

        public static void ImprimirComForEach(string[] array)
        {


            foreach (var aula in array)
                Console.WriteLine(aula);

        }

    }
}
