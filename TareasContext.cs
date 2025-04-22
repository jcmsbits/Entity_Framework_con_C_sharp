using Entity_Framework_con_C_sharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_con_C_sharp;


public class TareasContext: DbContext
{
    public DbSet<Categoria> Categorias {get; set;}
    public DbSet<Tarea> Tareas {get; set;}

    public TareasContext(DbContextOptions<TareasContext> options) : base(options) {}


}
