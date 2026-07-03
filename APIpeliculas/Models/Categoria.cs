using System.ComponentModel.DataAnnotations;

namespace APIpeliculas.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Fecha de Creacion: ")]
        public DateTime FechaCreacion {  get; set; }

    }
}
