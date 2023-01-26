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

namespace Cinema.Application.Services.Interfaces
{
    public interface IIngressoService
    {
        int BuyTickets(List<IngressoInputModel> ingresso);
        IEnumerable<IngressoViewModel> GetAll();
        IngressoViewModel GetById(int id);
        bool Update(IngressoInputModel inputModel, int id);
        bool Delete(int id);
    }
}
