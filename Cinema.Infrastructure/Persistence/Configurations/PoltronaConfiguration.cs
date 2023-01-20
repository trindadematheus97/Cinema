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
    public class PoltronaConfiguration : IEntityTypeConfiguration<Poltrona>
    {
        public void Configure(EntityTypeBuilder<Poltrona> builder)
        {
            builder
                .HasKey(i => i.Id)
                .IsClustered();

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasData(new List<Poltrona>()
                {
                    new Poltrona()
                    {
                        Id = 1,
                        PoltronaSala = 1,
                        SalaId = 1,
                        PoltronaOcupada = true
                    },
                    new Poltrona()
                    {
                        Id = 2,
                        PoltronaSala = 2,
                        SalaId = 1,
                        PoltronaOcupada = true
                    },
                    new Poltrona()
                    {
                        Id = 3,
                        PoltronaSala = 3,
                        SalaId = 1,
                        PoltronaOcupada = true
                    }
                });
        }
    }
}