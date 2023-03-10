using Cinema.Application.DTOs.InputModels;
using Cinema.Application.DTOs.ViewModels;
using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Services.Interfaces
{
    public interface IEspectadorService
    {
        bool Create(EspectadorInputModel inputModel);
        IEnumerable<EspectadorViewModel> GetAll();
        EspectadorViewModel GetById(int id);
        bool Update(EspectadorInputModel inputModel, int id);
        bool Delete(int id);
    }
}
