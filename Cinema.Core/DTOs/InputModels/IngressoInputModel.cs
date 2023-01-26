using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.DTOs.InputModels
{
    public class IngressoInputModel
    {
        public IngressoInputModel(int espectadorId, int sessaoId, int poltronaId)
        {
            EspectadorId = espectadorId;
            SessaoId = sessaoId;
            PoltronaId = poltronaId;
        }

        public int EspectadorId { get;  set; }
        public int SessaoId{ get;  set;}
        public int PoltronaId { get; set; }

    }
}
