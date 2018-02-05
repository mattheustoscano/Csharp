using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Classes
{
    public class Curso
    {
        // Tornando nossa lista em uma coleção de apenas leitura...
        public List<Aula> Aulas { get; set; }

        public string Nome { get; set; }

        public string Instrutor { get; set; }

        public Curso()
        {
          
        }



        public Curso( string nome, string instrutor)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $" - [Curso: {Nome}] - \n";
        }
    }
}
