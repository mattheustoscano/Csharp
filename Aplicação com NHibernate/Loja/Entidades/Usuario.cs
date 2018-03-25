using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entidades
{
    public class Usuario
    {
        // todas as propriedades precisam ser virtuais para trabalharmos com nhibernate...
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }

    }
}
