using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Filme
    {
        public Filme()
        {

        }
        public Filme(int id,string nome, string duracao, string sinopse)
        {
            Id = id;
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
        }

        public Filme(string nome, string duracao, string sinopse)
        {
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
        }

       

        public void Update(string nome, string duracao, string sinopse)
        {
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Sinopse { get; set; }

        public List<Sessao> Sessoes { get; set; }
    }
}
