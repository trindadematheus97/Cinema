using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.DTOs.ViewModels
{
    public class EspectadorViewModel
    {
        public EspectadorViewModel(int id, string nome, DateTime dataNascimento)
        {
            Id= id;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
