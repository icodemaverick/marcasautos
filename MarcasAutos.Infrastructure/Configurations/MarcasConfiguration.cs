using MarcasAutos.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarcasAutos.Infrastructure.Configurations;

public class MarcasConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {

        builder.HasKey(m => m.Id);

        builder.Property(m => m.Nombre)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasData(
            new Marca { Id = 1, Nombre = "Toyota" },
            new Marca { Id = 2, Nombre = "Kia" },
            new Marca { Id = 3, Nombre = "Hyundai" },
            new Marca { Id = 4, Nombre = "Nissan" },
            new Marca { Id = 5, Nombre = "Ford" }
        );
    }
}