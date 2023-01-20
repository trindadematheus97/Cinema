﻿namespace Cinema.Core.Entities
{
    public class Poltrona
    {
        public int Id { get; set; }
        public int PoltronaSala { get; set; }
        public bool PoltronaOcupada { get; set; }
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
    }     
}
