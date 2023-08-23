using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_enterprise.Models
{
    [Table("TB_RESERVA")]
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public DateTime DataEntrada { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public DateTime DataSaida { get; set; }

        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public float ValorTotal { get; set; }

        [ForeignKey("Hospede")]
        public int IdHospede { get; set; }
        public virtual Hospede? Hospede { get; set; }

        [ForeignKey("Pagamento")]
        public int IdPagamento { get; set; }
        public virtual Pagamento? Pagamento { get; set; }

    }
}
