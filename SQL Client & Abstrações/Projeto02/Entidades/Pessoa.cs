using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int idPessoa, string nome, string sexo)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return $"IdPessoa: {IdPessoa}, Nome: {Nome}, Sexo: {Sexo}";
        }


    }
}
