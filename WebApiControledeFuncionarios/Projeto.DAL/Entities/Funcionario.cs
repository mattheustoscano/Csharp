using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }

        public string Nome { get; set; }

        public DateTime DataAdmissao { get; set; }

        public decimal Salario { get; set; }


        public Funcionario()
        {
                
        }

        public Funcionario(int idFuncionario, string nome, DateTime dataAdmissao, decimal salario)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            DataAdmissao = dataAdmissao;
            Salario = salario;
        }
    }
}
