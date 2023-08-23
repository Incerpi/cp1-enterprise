using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cp1_enterprise.Models
{
    [Table("TB_TIPOQUARTO")]
    public class TipoQuarto
    {
        [Key]
        public int IdTipoQuarto { get; set; }

        [Required]
        public string Descricao { get; set; }

    }
}
