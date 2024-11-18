using System.ComponentModel.DataAnnotations;

namespace MandrilAPI.Models
{
    public class MandrilInsert
    {
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
    }
}
