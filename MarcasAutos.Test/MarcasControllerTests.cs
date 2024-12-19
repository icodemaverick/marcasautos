using MarcasAutos.Api.Controllers;
using MarcasAutos.Api.Dtos;
using MarcasAutos.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MarcasAutos.Test;

public class MarcasControllerTests
{
    private readonly Mock<IMarcasService> _mockMarcasService;
    private readonly MarcasController _marcasController;

    public MarcasControllerTests()
    {
        _mockMarcasService = new Mock<IMarcasService>();
        _marcasController = new MarcasController(_mockMarcasService.Object);
    }

    [Fact]
    public async Task Get_ReturnsOkWithListOfMarcas()
    {
        var expectedDataList = new List<MarcaDto>
        {
            new (1, "Toyota"),
            new (2, "Kia"),
            new (3, "Hyundai"),
            new (4, "Nissan"),
            new (5, "Ford")
        };

        _mockMarcasService.Setup(h => h.GetAll()).ReturnsAsync(expectedDataList);

        var result = await _marcasController.Get();

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(expectedDataList, okResult.Value);
    }
}
