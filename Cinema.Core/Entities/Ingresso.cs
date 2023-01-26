using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Ingresso
    {
        public Ingresso()
        {

        }
        public Ingresso(int espectadorId, int sessaoId, int poltronaId)
        {
            EspectadorId = espectadorId;
            SessaoId= sessaoId;
            PoltronaId= poltronaId;
        }

        public void Update(int espectadorId, int sessaoId, int poltronaId)
        {
            EspectadorId = espectadorId;
            SessaoId = sessaoId;
            PoltronaId = poltronaId;
        }

        public void AddIngresso(int espectadorId, int sessaoId)
        {
            EspectadorId = espectadorId;
            SessaoId = sessaoId;
        }

        public int Id { get; set; }

        // nav
        public int EspectadorId { get; set; }
        public Espectador Espectador { get; set; }
        public int SessaoId { get; set; }
        public Sessao Sessao { get; set; }
        public int PoltronaId { get; set; }
        public Poltrona Poltrona { get; set; }
    }
}
