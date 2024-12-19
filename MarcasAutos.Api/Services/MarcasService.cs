using MarcasAutos.Api.Dtos;
using MarcasAutos.Api.Persistance;

namespace MarcasAutos.Api.Services;

public interface IMarcasService
{
    Task<IEnumerable<MarcaDto>> GetAll();
}

public class MarcasService(IMarcasRepository marcasRepository) : IMarcasService
{
    public async Task<IEnumerable<MarcaDto>> GetAll()
    {
        var records = await marcasRepository.GetAll();

        var response = records.Select(x => new MarcaDto(x.Id, x.Nombre ?? string.Empty));

        return response;
    }
}
