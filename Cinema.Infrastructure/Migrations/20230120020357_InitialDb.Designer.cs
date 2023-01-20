﻿// <auto-generated />
using System;
using Cinema.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cinema.Infrastructure.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20230120020357_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cinema.Core.Entities.CinemaLocal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("Cinema");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Por do Sol"
                        });
                });

            modelBuilder.Entity("Cinema.Core.Entities.Espectador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("Espectadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNascimento = new DateTime(1997, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Matheus"
                        });
                });

            modelBuilder.Entity("Cinema.Core.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duracao = "90",
                            Nome = "As braquelas",
                            Sinopse = "Filme de comédia."
                        });
                });

            modelBuilder.Entity("Cinema.Core.Entities.Ingresso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EspectadorId")
                        .HasColumnType("int");

                    b.Property<int>("PoltronaId")
                        .HasColumnType("int");

                    b.Property<int>("SessaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("EspectadorId");

                    b.HasIndex("PoltronaId");

                    b.HasIndex("SessaoId");

                    b.ToTable("Ingressos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EspectadorId = 1,
                            PoltronaId = 1,
                            SessaoId = 1
                        },
                        new
                        {
                            Id = 2,
                            EspectadorId = 1,
                            PoltronaId = 2,
                            SessaoId = 1
                        },
                        new
                        {
                            Id = 3,
                            EspectadorId = 1,
                            PoltronaId = 3,
                            SessaoId = 1
                        });
                });

            modelBuilder.Entity("Cinema.Core.Entities.Poltrona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PoltronaSala")
                        .HasColumnType("int");

                    b.Property<int>("PoltronaStatus")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("SalaId");

                    b.ToTable("Poltrona");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PoltronaSala = 1,
                            PoltronaStatus = 0,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 2,
                            PoltronaSala = 2,
                            PoltronaStatus = 0,
                            SalaId = 1
                        },
                        new
                        {
                            Id = 3,
                            PoltronaSala = 3,
                            PoltronaStatus = 0,
                            SalaId = 1
                        });
                });

            modelBuilder.Entity("Cinema.Core.Entities.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("CinemaId");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 1
                        });
                });

            modelBuilder.Entity("Cinema.Core.Entities.Sessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("CinemaId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("SalaId");

                    b.ToTable("Sessoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 1,
                            FilmeId = 1,
                            Horario = new DateTime(2023, 7, 2, 22, 59, 59, 0, DateTimeKind.Unspecified),
                            SalaId = 1
                        });
                });

            modelBuilder.Entity("Cinema.Core.Entities.Ingresso", b =>
                {
                    b.HasOne("Cinema.Core.Entities.Espectador", "Espectador")
                        .WithMany("Ingressos")
                        .HasForeignKey("EspectadorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cinema.Core.Entities.Poltrona", "Poltrona")
                        .WithMany()
                        .HasForeignKey("PoltronaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinema.Core.Entities.Sessao", "Sessao")
                        .WithMany("Ingressos")
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Espectador");

                    b.Navigation("Poltrona");

                    b.Navigation("Sessao");
                });

            modelBuilder.Entity("Cinema.Core.Entities.Poltrona", b =>
                {
                    b.HasOne("Cinema.Core.Entities.Sala", "Sala")
                        .WithMany("Poltronas")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Cinema.Core.Entities.Sala", b =>
                {
                    b.HasOne("Cinema.Core.Entities.CinemaLocal", "Cinema")
                        .WithMany("Salas")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("Cinema.Core.Entities.Sessao", b =>
                {
                    b.HasOne("Cinema.Core.Entities.CinemaLocal", "Cinema")
                        .WithMany("Sessoes")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cinema.Core.Entities.Filme", "Filme")
                        .WithMany("Sessoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cinema.Core.Entities.Sala", "Sala")
                        .WithMany("Sessoes")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Filme");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Cinema.Core.Entities.CinemaLocal", b =>
                {
                    b.Navigation("Salas");

                    b.Navigation("Sessoes");
                });

            modelBuilder.Entity("Cinema.Core.Entities.Espectador", b =>
                {
                    b.Navigation("Ingressos");
                });

            modelBuilder.Entity("Cinema.Core.Entities.Filme", b =>
                {
                    b.Navigation("Sessoes");
                });

            modelBuilder.Entity("Cinema.Core.Entities.Sala", b =>
                {
                    b.Navigation("Poltronas");

                    b.Navigation("Sessoes");
                });

            modelBuilder.Entity("Cinema.Core.Entities.Sessao", b =>
                {
                    b.Navigation("Ingressos");
                });
#pragma warning restore 612, 618
        }
    }
}
