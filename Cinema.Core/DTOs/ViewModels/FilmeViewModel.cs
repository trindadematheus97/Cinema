using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.DTOs.ViewModels
{
    public class FilmeViewModel
    {
        public FilmeViewModel(int id,string nome, string duracao, string sinopse)
        {
            Id = id;
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Sinopse { get; set; }
    }
}
