using Cinema.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Persistence.Configurations
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
                .HasKey(x => x.Id)
                .IsClustered();

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasMany(f => f.Sessoes)
                .WithOne(s => s.Filme)
                .HasForeignKey(s => s.FilmeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasData(new Filme()
                {
                    Id = 1,
                    Nome = "As braquelas",
                    Duracao = "90",
                    Sinopse = "Filme de comédia."
                });
        }
    }
}
