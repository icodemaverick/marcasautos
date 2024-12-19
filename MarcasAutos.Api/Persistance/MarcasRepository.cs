using MarcasAutos.Infrastructure.Data;
using MarcasAutos.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarcasAutos.Api.Persistance;

public interface IMarcasRepository
{
    Task<IEnumerable<Marca>> GetAll();
}

public class MarcasRepository(MarcasAutosDbContext context) : IMarcasRepository
{
    public async Task<IEnumerable<Marca>> GetAll() => await context.Marcas.ToListAsync();
}