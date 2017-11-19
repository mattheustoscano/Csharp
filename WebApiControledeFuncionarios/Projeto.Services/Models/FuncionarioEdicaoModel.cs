using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class FuncionarioEdicaoModel
    {
        
        public int IdFuncionario { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo 50 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o salário do funcionário.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de admissão do funcionário.")]
        public DateTime DataAdmissao { get; set; }

    }
}