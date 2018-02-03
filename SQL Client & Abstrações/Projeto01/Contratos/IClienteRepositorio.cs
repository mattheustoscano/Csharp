using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;

namespace Projeto01.Contratos
{
    public interface IClienteRepositorio
    {


        void Insert(Cliente c);

        List<Cliente> FindAll();


            
    }
}
