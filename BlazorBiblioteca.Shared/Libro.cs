using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorBiblioteca.Shared;

public class Libro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "Campo vacio, ingresa un nombre")]
    public  string NombreLibro { get; set; }
    [Required(ErrorMessage = "Campo vacio, ingresa un autor")]
    public  string Autor { get; set; }
    public int NumPaginas { get; set; }
    public DateTime FechaPublicacion { get; set; }
}