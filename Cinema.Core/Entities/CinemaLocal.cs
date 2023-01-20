using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class CinemaLocal
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // nav
        public List<Sala> Salas { get; set; }
        public List<Sessao> Sessoes { get; set; }
    }
}
