﻿// <auto-generated />
using MarcasAutos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MarcasAutos.Infrastructure.Migrations
{
    [DbContext(typeof(MarcasAutosDbContext))]
    partial class MarcasAutosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MarcasAutos.Infrastructure.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Marcas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Toyota"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Kia"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Hyundai"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Nissan"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Ford"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}