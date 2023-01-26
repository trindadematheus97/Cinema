using Cinema.Application.Repositories.Implementations;
using Cinema.Application.Repositories.Interfaces;
using Cinema.Application.Services.Implementations;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.Repositories;
using Cinema.Infrastructure.Persistence;
using Cinema.Infrastructure.Persistence.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CinemaDbContext>(options=> options.UseSqlServer(builder.Configuration.GetConnectionString("CinemaConnection")));

builder.Services.AddScoped<IEspectadorRepository, EspectadorRepository>();
builder.Services.AddScoped<IEspectadorService, EspectadorService>();


builder.Services.AddScoped<IIngresoRepository, IngressoRepository>();
builder.Services.AddScoped<IIngressoService, IngressoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
