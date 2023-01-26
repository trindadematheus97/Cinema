using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.DTOs.ViewModels
{
    public class IngressoViewModel
    {
        public IngressoViewModel(int id, int espectadorId, int sessaoId, int poltronaId)
        {
            Id = id;
            EspectadorId = espectadorId;
            SessaoId = sessaoId;
            PoltronaId = poltronaId;
        }

        public int Id { get; set; }
        public int EspectadorId { get; set; }
        public int SessaoId { get; set; }
        public int PoltronaId { get; set; }
    }
}
