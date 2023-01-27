using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Espectador
    {
        public Espectador()
        {

        }
        public Espectador(int id, string nome, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            dataNascimento = dataNascimento;
        }
        public Espectador(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            dataNascimento = dataNascimento;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Ingresso> Ingressos { get; private set; }

        public void Update(string nome, DateTime dataNascimento)
        {  
            Nome = nome;
            DataNascimento = dataNascimento;
        }
    }
}
