using CapaDatos;
using CapaNegocio.Clases;
using CapaNegocio.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Habilitar los CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("*");
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configurar el acceso a datos
var conn = builder.Configuration.GetConnectionString("AppConnection"); //crea una variable con la cadena de conexion
builder.Services.AddDbContext<P2Context>(x => x.UseSqlServer(conn));//construye el contexto

//Configurar las interfaces para que el controlador las puedad usar
builder.Services.AddScoped<IPersona,LogicaPersona>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Usar los CORS
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
