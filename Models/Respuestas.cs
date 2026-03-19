using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial_IngWeb.Models
{
    public class Respuestas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdRespuesta { get; set; }
        [Required]
        public Guid IdPregunta { get; set; }

        [ForeignKey("IdPregunta")]
        public Preguntas? Pregunta { get; set; }

        [MinLength(2)]
        [MaxLength(500)]
        public string Contenido { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
