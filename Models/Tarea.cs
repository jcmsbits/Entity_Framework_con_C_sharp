using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Framework_con_C_sharp.Models;

public class Tarea
{
    // [Key] // Fluente ya lo está aplicando
    public Guid TareaId {get; set;}

    [ForeignKey("CategoriaId")]
    public Guid CategoriaId {get; set;}

    [Required]
    [MaxLength(200)]
    public string Titulo {get; set;}

    public string Descripcion {get; set;}

    public Prioridad PrioridadTara {get; set;}

    public DateTime FechaCreacion {get; set;}

    public virtual Categoria Categoria {get; set;}    

    [NotMapped] // Se crea en memoria y no en la BD
    public string Resumen {get; set;}
}   

public enum Prioridad
{
    Baja,
    Media,
    Alta
}