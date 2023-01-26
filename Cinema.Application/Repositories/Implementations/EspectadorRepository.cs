using Azure.Core;
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
        public  int Create(Espectador espectador)
        {

            var dB =  _dbContext.Espectadores.AddAsync(espectador);

            _dbContext.SaveChanges();

            int rows = _dbContext.SaveChanges();

            if (rows > 0) return rows;

            return 0; 
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

        public bool Update(Espectador espectador)
        {
            
            var espectadorUp = _dbContext.Espectadores.SingleOrDefault(p => p.Id == espectador.Id);

            if (espectadorUp == null) return false;


           int rows = _dbContext.SaveChanges();

            if(rows != null) return true;
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
