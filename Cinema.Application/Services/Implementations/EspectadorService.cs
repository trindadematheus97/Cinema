using Cinema.Application.DTOs.InputModels;
using Cinema.Application.DTOs.ViewModels;
using Cinema.Application.Repositories.Interfaces;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Services.Implementations
{
    public class EspectadorService : IEspectadorService
    {
        private readonly IEspectadorRepository _espectadorRepository;

        public EspectadorService(IEspectadorRepository espectadorRepository)
        {
            _espectadorRepository = espectadorRepository;
        }

        public bool Create(EspectadorInputModel inputModel)
        {
            var espectador = new Espectador(inputModel.Nome, inputModel.DataNascimento);

            var espectadorAdicionado = _espectadorRepository.Create(espectador);

            return  true;
        }

        public IEnumerable<EspectadorViewModel> GetAll()
        { 
            return _espectadorRepository.GetAll();
        }

        public EspectadorViewModel GetById(int id)
        {
            var espectador = _espectadorRepository.GetById(id);

            if (espectador == null) return null;

            var espectadorViewModel = new EspectadorViewModel(espectador.Id, espectador.Nome, espectador.DataNascimento);

            return espectadorViewModel;
        }

        public bool Update(EspectadorInputModel inputModel, int id)
        {
            var espectador = _espectadorRepository.GetById(id);

            if (espectador == null) return false;

            espectador.Update(inputModel.Nome, inputModel.DataNascimento);

            _espectadorRepository.Update(espectador);

            if (espectador  !=null) return true;

            return false;

        }

        public bool Delete(int id)
        {
            bool espectador;

            espectador = _espectadorRepository.Delete(id);

            if (espectador == false) return false;

            return true;
        }
    }
}
