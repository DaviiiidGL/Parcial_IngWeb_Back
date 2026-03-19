using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial_IngWeb.Models
{
    public class Preguntas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPregunta { get; set; }

        [MinLength(5)]
        [MaxLength(100)]
        public string Enunciado { get; set; }
        [MinLength(2)]
        [MaxLength(30)]
        public string Categoria { get; set; }

        public bool isAnswered { get; set; }
    }
}
