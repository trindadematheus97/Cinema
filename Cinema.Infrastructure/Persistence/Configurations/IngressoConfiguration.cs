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
    public class IngressoConfiguration : IEntityTypeConfiguration<Ingresso>
    {
        public void Configure(EntityTypeBuilder<Ingresso> builder)
        {
            builder
                .HasKey(x => x.Id)
                .IsClustered();

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasData(new List<Ingresso>
                {
                    new Ingresso()
                    {
                        Id = 1,
                        EspectadorId = 1,
                        SessaoId = 1,
                        PoltronaId = 1
                    },
                    new Ingresso()
                    {
                        Id = 2,
                        SessaoId = 1,
                        EspectadorId = 1,
                        PoltronaId = 2
                    },
                    new Ingresso()
                    {
                        Id = 3,
                        SessaoId = 1,
                        EspectadorId = 1,
                        PoltronaId = 3
                    }
                });
        }
    }
}
