using MarcasAutos.Api.Dtos;

namespace MarcasAutos.Api.Services;

public interface IMarcasService
{
    Task<IEnumerable<MarcaDto>> GetAll();
}

public class MarcasService : IMarcasService
{
    public Task<IEnumerable<MarcaDto>> GetAll()
    {
        throw new NotImplementedException();
    }
}
