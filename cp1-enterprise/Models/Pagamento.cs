using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_enterprise.Models
{
    [Table("TB_PAGAMENTO")]
    public class Pagamento
    {
        [Key]
        public int IdPagamento { get; set; }

        [Required]
        public DateTime DataPagamento { get; set; }

        [Required]
        public float Valor { get; set; }

        [ForeignKey("Reserva")]
        public int IdReserva { get; set; }
        public virtual Reserva? Reserva { get; set; }
    }
}
