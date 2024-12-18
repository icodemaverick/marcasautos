using MarcasAutos.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarcasAutos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MarcasController(IMarcasService marcasService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var resp = await marcasService.GetAll();
        return Ok(resp);
    }
}
