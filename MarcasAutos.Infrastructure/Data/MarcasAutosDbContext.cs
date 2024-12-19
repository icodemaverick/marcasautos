using MarcasAutos.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarcasAutos.Infrastructure.Data;

public class MarcasAutosDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Marca> Marcas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarcasAutosDbContext).Assembly);
    }
}
