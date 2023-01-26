using Cinema.Application.DTOs.InputModels;
using Cinema.Application.DTOs.ViewModels;
using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Repositories.Interfaces
{
    public interface IEspectadorRepository
    {
        int Create(Espectador espectador);
        IEnumerable<EspectadorViewModel> GetAll();
        Espectador GetById(int id);
        bool Update(Espectador espectador);
        bool Delete(int id);
    }
}
