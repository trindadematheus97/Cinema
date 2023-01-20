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
    public class EspectadorConfiguration : IEntityTypeConfiguration<Espectador>
    {
        public void Configure(EntityTypeBuilder<Espectador> builder)
        {
            builder
                .HasKey(p => p.Id)
                .IsClustered();

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasMany(e => e.Ingressos)
                .WithOne(i => i.Espectador)
                .HasForeignKey(i => i.EspectadorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Espectador()
            {
                Id = 1,
                Nome = "Matheus",
                DataNascimento = new DateTime(1997, 11, 24)
            });
        }
    }
}
