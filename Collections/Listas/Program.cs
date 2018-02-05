using Listas.Classes;
using Listas.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {


            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";



            // Instanciando uma lista de strings...
            List<string> aulas = new List<string>()
            {

                aulaIntro,
                aulaModelando,
                aulaSets

            };

            // Imprimindo a Lista...
            ListaControle.ImprimirLista(aulas);


            // Adicionando elementos na lista com o método add...

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            //ListaControle.ImprimirLista(aulas);


            // utilizando o foreach diretamente na lista...
            
            // Para cada aula executo o código designado pelo operador lambda...    
            aulas.ForEach(aula => { Console.Write("\n"+aula); });

         
            //Pegando o primeiro elemento...
            Console.WriteLine("\nA primeira aula é: " + aulas.First());

            //Imprimindo a Última aula...
            Console.WriteLine("\nA última aula é: " + aulas.Last());


            //Modificando o valor do primeiro elemento da lista...
            aulas[0] = "Trabalhando com Listas";

            //Buscando um elemento com alguma palavra em comum...
            Console.WriteLine("\n"+aulas.Find(aula => aula.Contains("Trabalhando")));

            //Buscando de outra forma...
            Console.WriteLine("\nA primeira aula 'Trabalhando' é: " + 
                aulas.First(aula => aula.Contains("Trabalhando")));

            //Mesmo método de pesquisa com o last...
            Console.WriteLine("\nA útilma aula 'Trabalhando' é: '" + 
                aulas.Last(aula => aula.Contains("Trabalhando")));

            // First or Default me devolve a pesquisa desejada ou um valor default caso não encontre...
            Console.WriteLine("\nDefault de uma string é: " + 
                aulas.FirstOrDefault(aula => aula.Contains("working")));


            //invertendo a ordem dos registros da lista...
            aulas.Reverse();

            // Removendo o último registro...
             aulas.RemoveAt(aulas.Count - 1);

            //Ordenando a Lista...
            aulas.Sort();

            //Copiando os dois ultimos elementos da lista para outra lista...
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);

            //imprimindo a cópia...
            ListaControle.ImprimirLista(copia);

            //Clonando de outra forma...
            List<string> clone = new List<string>(aulas);


            //Limpando o Console...
            Console.Clear();

            //Trabalhando com uma lista de Classes...
            List<Aula> listaAulas = new List<Aula>();


            //adicionando objetos na lista...
            listaAulas.Add(new Aula("Matemática", 40));
            listaAulas.Add(new Aula("Portugues", 45));

            //Ordenando a lista...
            listaAulas.Sort((primeiro, segundo) => primeiro.Tempo.CompareTo(segundo.Tempo));

            //Imprimindo elementos da lista...
            listaAulas.ForEach(a => { Console.WriteLine(a.ToString()); });



            Console.Clear();

            Curso curso = new Curso();

            curso.Nome = "CSharp";
            curso.Instrutor = "Mattheus Toscano";
            curso.Aulas = new List<Aula>();
            curso.Aulas.Add(new Aula("Collections", 40));
            curso.Aulas.Add(new Aula("Asp.Net", 40));
            curso.Aulas.Add(new Aula("Entity", 40));
            curso.Aulas.Add(new Aula("Linq", 40));
            curso.Aulas.Add(new Aula("POO", 40));

            //Somando propriedades de uma lista...

            Console.WriteLine("\nTempo Total: " + curso.Aulas.Sum(a => a.Tempo)); 

            ListaControle.ImprimirListaGenerica(curso.Aulas);

            // Pausando o Console...
            Console.ReadKey();


        }
    }
}
