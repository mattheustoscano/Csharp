using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entidades
{
    public class Produto
    {
        public virtual  int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual Decimal Preco { get; set; }

    }
}
