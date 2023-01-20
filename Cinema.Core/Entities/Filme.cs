using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Sinopse { get; set; }

        public List<Sessao> Sessoes { get; set; }
    }
}
