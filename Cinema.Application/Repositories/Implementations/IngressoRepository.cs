using Cinema.Application.DTOs.InputModels;
using Cinema.Core.DTOs.InputModels;
using Cinema.Core.DTOs.ViewModels;
using Cinema.Core.Entities;
using Cinema.Core.Repositories;
using Cinema.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Repositories.Implementations
{
    public class IngressoRepository : IIngresoRepository
    {
        private readonly CinemaDbContext _dbContext;
        public IngressoRepository(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Buy(Ingresso ingresso)
        {
            _dbContext.Add(ingresso);

            var rows = _dbContext.SaveChanges();
            
            if(rows > 0) return rows;

            return 0;
            
        }

        public IEnumerable<IngressoViewModel> GetAll()
        {
            var ingressos = _dbContext.Ingressos;

            var ingressoViewModel = ingressos
                .Select(p => new IngressoViewModel(p.Id, p.SessaoId, p.PoltronaId, p.EspectadorId))
                .ToList();

            return ingressoViewModel;
        }

        public Ingresso GetById(int id)
        {
            var ingresso = _dbContext.Ingressos.SingleOrDefault(p => p.Id == id);

            if (ingresso == null) return null;

            return ingresso;
        }

        public bool Update(Ingresso ingresso)
        {

            var ingressoUp = _dbContext.Espectadores.SingleOrDefault(p => p.Id == ingresso.Id);

            if (ingressoUp == null) return false;


            int rows = _dbContext.SaveChanges();

            if (rows != null) return true;
            return false;

        }

        public bool Delete(int id)
        {
            var ingresso = _dbContext.Ingressos.SingleOrDefault(e => e.Id == id);

            if (ingresso != null)
            {
                _dbContext.Remove(ingresso);
                int rowsAffected = _dbContext.SaveChanges();

                if (rowsAffected > 0) return true;
            }

            return false;
        }
    }
}
