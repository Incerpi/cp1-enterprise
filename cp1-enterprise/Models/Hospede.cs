using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_enterprise.Models
{
    [Table("TB_HOSPEDE")]
    public class Hospede
    {
        [Key]
        public int HospedeId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required] [EmailAddress]
        public string Email {  get; set; }

        [Required] [Phone]
        public string Telefone { get; set; }

    }
}
