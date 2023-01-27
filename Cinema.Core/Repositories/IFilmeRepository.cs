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
    public interface IFilmeRepository
    {
        bool FilmRegistration(Filme filme);
        IEnumerable<Filme> GetAll();
        Filme GetById(int id);
        bool Update(Filme filme);
        bool Delete(int id);
    }
}
