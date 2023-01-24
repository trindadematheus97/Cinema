using Cinema.Application.DTOs.InputModels;
using Cinema.Application.DTOs.ViewModels;
using Cinema.Application.Repositories.Interfaces;
using Cinema.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Persistence.Repositories.Implementations
{
    public class EspectadorRepository : IEspectadorRepository
    {
        private readonly CinemaDbContext _dbContext;
        public EspectadorRepository(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public  int Create(EspectadorInputModel inputModel)
        {
            var espectador = new Espectador(inputModel.Id, inputModel.Nome, inputModel.DataNascimento);

            var dB =  _dbContext.Espectadores.AddAsync(espectador);

            _dbContext.SaveChanges();
            
            return espectador.Id;
        }

        public  IEnumerable<EspectadorViewModel> GetAll()
        {
            var espectadores =  _dbContext.Espectadores;

            var espectadorViewModel = espectadores
                                        .Select(p => new EspectadorViewModel(p.Id, p.Nome, p.DataNascimento))
                                        .ToList();
            return espectadorViewModel;
        }

        public Espectador GetById(int id)
        {
            var espectador = _dbContext.Espectadores.SingleOrDefault(p => p.Id == id);

            if (espectador == null) return null;

            return espectador;
        }

        public bool Update(Espectador inputModel)
        {

            var espectador = _dbContext.Espectadores.SingleOrDefault(e => e.Id == inputModel.Id);

            if (espectador != null) 
            {
                espectador.Update(inputModel.Nome, inputModel.DataNascimento);
                int rowsAffected = _dbContext.SaveChanges();

                if (rowsAffected > 0) return true;
            }

            return false;

        }

        public bool Delete(int id)
        {
            var espectador = _dbContext.Espectadores.SingleOrDefault(e => e.Id == id);

            if (espectador != null)
            {
                _dbContext.Remove(espectador);
                int rowsAffected = _dbContext.SaveChanges();

                if (rowsAffected > 0) return true;
            }

            return false;
        }
    }
}
