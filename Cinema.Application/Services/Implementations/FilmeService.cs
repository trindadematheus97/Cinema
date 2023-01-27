using Cinema.Application.DTOs.ViewModels;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.DTOs.InputModels;
using Cinema.Core.DTOs.ViewModels;
using Cinema.Core.Entities;
using Cinema.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Services.Implementations
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

       

        public bool FilmRegistration(FilmeInputModel inputModel)
        {

            var filme = new Filme(inputModel.Nome, inputModel.Duracao, inputModel.Sinopse) ;

            var filmeAdicionado = _filmeRepository.FilmRegistration(filme);

            if (filmeAdicionado != null) return true;

            return false;
        }

        public IEnumerable<Filme> GetAll()
        {
            return _filmeRepository.GetAll(); 
        }

        public FilmeViewModel GetById(int id)
        {
            var filme = _filmeRepository.GetById(id);

            if (filme == null) return null;

            var filmeViewModel = new FilmeViewModel(filme.Id, filme.Nome, filme.Duracao, filme.Sinopse);

            return filmeViewModel;
        }

        public bool Update(FilmeInputModel inputModel, int id)
        {
            var filme = _filmeRepository.GetById(id);

            if (filme == null) return false;

            filme.Update(inputModel.Nome, inputModel.Duracao, inputModel.Sinopse);

            _filmeRepository.Update(filme);

            if (filme != null) return true;

            return false;
        }

        public bool Delete(int id)
        {
            bool filme;

            filme = _filmeRepository.Delete(id);

            if (filme == false) return false;

            return true;
        }

        
    }
}
