using Cinema.Application.DTOs.ViewModels;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.DTOs.InputModels;
using Cinema.Core.DTOs.ViewModels;
using Cinema.Core.Entities;
using Cinema.Core.Repositories;
using Cinema.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Repositories.Implementations
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly CinemaDbContext _dbContext;
        public FilmeRepository(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool FilmRegistration(Filme filme)
        {
            var dB = _dbContext.Filmes.AddAsync(filme);

            _dbContext.SaveChanges();

            int rows = _dbContext.SaveChanges();

            if (rows > 0) return true;

            return false;

        }

        public IEnumerable<Filme> GetAll()
        {
            var filmes = _dbContext.Filmes.AsQueryable().AsNoTracking();

            return filmes;
        }


        public Filme GetById(int id)
        {
            Filme filme = _dbContext.Filmes.Where(f => f.Id == id).AsNoTracking().SingleOrDefault();
            return filme;
        }

        public bool Update(Filme filme)
        {
            _dbContext.Attach(filme);
            _dbContext.Entry(filme).State = EntityState.Modified;
            var row = _dbContext.SaveChanges();

            if (row == null) return false;
            return true;
        }

        public bool Delete(int id)
        {
            if(id != null)
            { 
                _dbContext.Remove(id);
                int rowsAffected = _dbContext.SaveChanges();

                if (rowsAffected > 0) return true;
            }
            return false;
        }
    }
}
