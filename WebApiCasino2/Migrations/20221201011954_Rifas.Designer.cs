﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCasino2;

#nullable disable

namespace WebApiCasino2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220522224728_Rifas")]
    partial class Rifas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiCasino2.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.PersonaRifa", b =>
                {
                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("RifaId")
                        .HasColumnType("int");

                    b.Property<int>("Oredn")
                        .HasColumnType("int");

                    b.HasKey("PersonaId", "RifaId");

                    b.HasIndex("RifaId");

                    b.ToTable("PersonaRifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Rifa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.PersonaRifa", b =>
                {
                    b.HasOne("WebApiCasino2.Entidades.Persona", "Persona")
                        .WithMany("PersonaRifa")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCasino2.Entidades.Rifa", "Rifa")
                        .WithMany("PersonaRifa")
                        .HasForeignKey("RifaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Rifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Persona", b =>
                {
                    b.Navigation("PersonaRifa");
                });

            modelBuilder.Entity("WebApiCasino2.Entidades.Rifa", b =>
                {
                    b.Navigation("PersonaRifa");
                });
#pragma warning restore 612, 618
        }
    }
}
