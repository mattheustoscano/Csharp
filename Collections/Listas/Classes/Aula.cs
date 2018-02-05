using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Classes
{
    public class Aula : IComparable
    {

        public string Titulo { get; set; }
        public int Tempo { get; set; }

        public Aula()
        {

        }

        public Aula(string titulo, int tempo)
        {
            Titulo = titulo;
            Tempo = tempo;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Tempo: {Tempo}";
        }

        public int CompareTo(object obj)
        {
            Aula estaAula = obj as Aula;
            return Titulo.CompareTo(estaAula.Titulo);
        }
    }
}
