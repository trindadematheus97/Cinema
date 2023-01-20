using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Exceptions
{
    internal class ProjetoIniciado : Exception
    {
        public ProjetoIniciado() : base("Projeto já está iniciado!")
        {

        }
    }
}
