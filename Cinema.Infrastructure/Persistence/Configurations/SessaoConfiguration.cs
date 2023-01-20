using Cinema.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Persistence.Configurations
{
    public class SessaoConfiguration : IEntityTypeConfiguration<Sessao>
    {
        public void Configure(EntityTypeBuilder<Sessao> builder)
        {
            builder
                .HasKey(p => p.Id)
                .IsClustered();

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasMany(s => s.Ingressos)
                .WithOne(i => i.Sessao)
                .HasForeignKey(i => i.SessaoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasData(new List<Sessao>()
                {
                    new Sessao()
                    {
                        Id = 1,
                        Horario = new DateTime(2023, 07, 02, 22, 59, 59),
                        CinemaId = 1,
                        SalaId= 1,
                        FilmeId = 1
                    }
                });
        }
    }
}
