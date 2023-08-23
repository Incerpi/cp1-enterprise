using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_enterprise.Models
{
    [Table("TB_QUARTO")]
    public class Quarto
    {
        [Key]
        public int QuartoId { get; set; }

        [Required]
        public string NumeroQuarto { get; set; }

        [Required]
        public float PrecoPorNoite { get; set; }

        [ForeignKey("TipoQuarto")]
        public int IdTipoQuarto { get; set; }
        public virtual TipoQuarto? TipoQuarto { get; set; }


    }
}
