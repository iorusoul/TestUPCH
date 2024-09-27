using upch.test.Aplication.Handlers;
using upch.test.Domain.Interfaces;
using upch.test.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//mediator para el CQRS
builder.Services.AddMediatR(x =>
{
    x.RegisterServicesFromAssembly(typeof(CrearAutoHandler).Assembly);
});

//servicios
var conn = builder.Configuration.GetConnectionString("PosgreSQLConnString");
builder.Services.AddTransient<IContainerCadenaConexion>(x=> new ContainerCadenaConexion(conn));
builder.Services.AddScoped<IAutoRepositorio, AutoRepositorio>(); // inyectamos el repositorio para no tener que instanciarlo
//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
