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
    public class SalaConfiguration : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder
                .HasKey(x => x.Id)
                .IsClustered();

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasMany(s => s.Sessoes)
                .WithOne(s => s.Sala)
                .HasForeignKey(s => s.SalaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(s => s.Poltronas)
                .WithOne(p => p.Sala)
                .HasForeignKey(p => p.SalaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Sala()
            {
                Id = 1,
                CinemaId = 1
            });
        }
    }
}
