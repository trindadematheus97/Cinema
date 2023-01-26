using Cinema.Application.DTOs.InputModels;
using Cinema.Application.DTOs.ViewModels;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.DTOs.InputModels;
using Cinema.Core.DTOs.ViewModels;
using Cinema.Core.Entities;
using Cinema.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Services.Implementations
{
    public class IngressoService : IIngressoService
    {
        private readonly IIngresoRepository _ingressoRepository;

        public IngressoService(IIngresoRepository ingresoRepository)
        {
            _ingressoRepository = ingresoRepository;
        }

        public int BuyTickets(List<IngressoInputModel> ingressos)
        {
            foreach (var ingressoInputModel in ingressos)
            {
                var ingresso = new Ingresso(ingressoInputModel.SessaoId, ingressoInputModel.EspectadorId,
                                                ingressoInputModel.PoltronaId);

                var rows = _ingressoRepository.Buy(ingresso);

                if (rows > 0) return rows;
            }

            return 0;
        }


        public IEnumerable<IngressoViewModel> GetAll()
        {
            return _ingressoRepository.GetAll();
        }

        public IngressoViewModel GetById(int id)
        {
            var ingresso = _ingressoRepository.GetById(id);

            if (ingresso == null) return null;

            var espectadorViewModel = new IngressoViewModel(ingresso.Id, ingresso.EspectadorId, ingresso.SessaoId, ingresso.PoltronaId);

            return espectadorViewModel;
        }

        public bool Update(IngressoInputModel inputModel, int id)
        {
            var ingresso = _ingressoRepository.GetById(id);

            if (ingresso == null) return false;

            ingresso.Update(inputModel.SessaoId, inputModel.PoltronaId, inputModel.EspectadorId);

            _ingressoRepository.Update(ingresso);

            if (ingresso != null) return true;

            return false;
        }

        public bool Delete(int id)
        {
            bool espectador;

            espectador = _ingressoRepository.Delete(id);

            if (espectador == false) return false;

            return true;
        }
    }
}
