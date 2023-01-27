using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.DTOs.InputModels
{
    public class FilmeInputModel
    {
        public FilmeInputModel(string nome, string duracao, string sinopse)
        {
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
        }
        
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Sinopse { get; set; }
    }
}
