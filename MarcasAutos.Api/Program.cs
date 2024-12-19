using MarcasAutos.Api;
using MarcasAutos.Infrastructure;
using MarcasAutos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddApi()
    .AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using var scope = app.Services.CreateScope();

    var dbContextInfraestructure = scope.ServiceProvider.GetRequiredService<MarcasAutosDbContext>();

    if (dbContextInfraestructure.Database.GetPendingMigrations().Any())
    {
        dbContextInfraestructure.Database.Migrate();
    }
}

app.UseAuthorization();

app.MapControllers();

app.Run();