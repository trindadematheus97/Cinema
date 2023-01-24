using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.DTOs.InputModels
{
    public class EspectadorInputModel
    {
        public EspectadorInputModel(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public int Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public void SetId(int id) => Id = id;
    }
}
