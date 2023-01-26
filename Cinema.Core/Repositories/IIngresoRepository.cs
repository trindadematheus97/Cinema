using Cinema.Application.DTOs.InputModels;
using Cinema.Application.DTOs.ViewModels;
using Cinema.Core.DTOs.InputModels;
using Cinema.Core.DTOs.ViewModels;
using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Repositories
{
    public interface IIngresoRepository
    {
        int Buy(Ingresso ingresso);
        IEnumerable<IngressoViewModel> GetAll();
        Ingresso GetById(int id);
        bool Update(Ingresso inputModel);
        bool Delete(int id);
    }
}
