using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Sessao
    {
        public int Id { get; set; }
        public DateTime Horario { get; set; }

        public int SalaId { get; set; }
        public Sala Sala { get; set; }

        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        public List<Ingresso> Ingressos { get; set; }

        public int CinemaId { get; set; }
        public CinemaLocal Cinema { get; set; }
    }
}
