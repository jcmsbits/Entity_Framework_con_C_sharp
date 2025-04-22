using System.ComponentModel.DataAnnotations;

namespace Entity_Framework_con_C_sharp.Models;

public class Categoria
{
    [Key]
    public Guid CategoriaId {get; set;}

    [Required]
    [MaxLength(150)]
    public string Nombre {get; set;}
    
    public string Decripcion {get; set;}

    public virtual ICollection<Tarea> Tareas {get; set;}

    
}