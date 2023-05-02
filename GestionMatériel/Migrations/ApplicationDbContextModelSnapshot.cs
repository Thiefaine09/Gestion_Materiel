﻿// <auto-generated />
using System;
using GestionMatériel.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionMatériel.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionMatériel.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adresse = "34, rue de Bellevue",
                            CodePostal = "77340",
                            Email = "laurent.herique@laposte.net",
                            Nom = "HERIQUE",
                            Prenom = "Laurent",
                            Telephone = "0627495967",
                            Ville = "Pontault Combault"
                        },
                        new
                        {
                            Id = 2,
                            Adresse = "4, rue Charles Bras",
                            CodePostal = "77230",
                            Email = "vincent.gourdin@gm.com",
                            Nom = "GOURDIN",
                            Prenom = "Vincent",
                            Telephone = "0627657889",
                            Ville = "Emerainville"
                        });
                });

            modelBuilder.Entity("GestionMatériel.Models.Intervention", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Commentaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaterielId")
                        .HasColumnType("int");

                    b.Property<string>("Technicien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaterielId");

                    b.ToTable("Intervention");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Commentaire = "Bourrage récurent",
                            Date = new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6538),
                            MaterielId = 3,
                            Technicien = "Adrien"
                        });
                });

            modelBuilder.Entity("GestionMatériel.Models.Materiel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Install")
                        .HasColumnType("datetime2");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num_Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Materiel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            Date_Install = new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6474),
                            Marque = "Dell",
                            Num_Serie = "233986937902",
                            Type = "Ordinateur"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 1,
                            Date_Install = new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6525),
                            Marque = "IIyama",
                            Num_Serie = "56677887902",
                            Type = "Ecran"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 2,
                            Date_Install = new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6527),
                            Marque = "HP",
                            Num_Serie = "87566777021",
                            Type = "Imprimante"
                        });
                });

            modelBuilder.Entity("GestionMatériel.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateur");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "thiefaine@gmail.com",
                            Password = "2A14BD9B87AF2EB07E98A80F7BD35FD545C1C1CC1EFBCCB35B086C99615C96F8CC41126A21B4A7C4030163C674D549699037BE3E4E1F3BBB3A08B927553DB951",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("GestionMatériel.Models.Intervention", b =>
                {
                    b.HasOne("GestionMatériel.Models.Materiel", "Materiel")
                        .WithMany()
                        .HasForeignKey("MaterielId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materiel");
                });

            modelBuilder.Entity("GestionMatériel.Models.Materiel", b =>
                {
                    b.HasOne("GestionMatériel.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
