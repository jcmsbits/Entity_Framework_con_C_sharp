using Entity_Framework_con_C_sharp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
// builder.Services.AddNpgsql<TareasContext>("Host=MININT-Q8O0E6H;Username=postgres;Password=58362592;Database=TareasDb");
builder.Services.AddDbContext<TareasContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("postgres")));
                //MININT-Q8O0E6H nombre de la pc

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());

});

app.Run();
