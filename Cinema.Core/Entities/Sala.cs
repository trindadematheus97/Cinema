using Cinema.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Sala
    {
        public int Id { get; set; }

        // nav
        public int CinemaId { get; set; }
        public CinemaLocal Cinema { get; set; }
        public List<Sessao> Sessoes { get; set; }
        public List<Poltrona> Poltronas { get; set; }
    }
}
