using Cinema.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cinema.Infrastructure.Persistence.Configurations
{
    public class CinemaLocalConfiguration : IEntityTypeConfiguration<CinemaLocal>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CinemaLocal> builder)
        {
            builder
                .HasKey(x => x.Id)
                .IsClustered();

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasMany(c => c.Salas)
                .WithOne(s => s.Cinema)
                .HasForeignKey(s => s.CinemaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Sessoes)
                .WithOne(s => s.Cinema)
                .HasForeignKey(s => s.CinemaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new CinemaLocal() 
            { 
                Id = 1,
                Nome = "Por do Sol"
            });
        }
    }
}
