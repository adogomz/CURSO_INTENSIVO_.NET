// usings
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        // buscando soluciones di con esta en la doc .net
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } 
    }
}
