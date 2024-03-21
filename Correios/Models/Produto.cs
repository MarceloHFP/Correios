using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site.test.Models
{
    [Table("produto")]
    public class Produto
    {
        [Display(Name = "Codigo")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Marca")]
        [Column("Marca")]
        public string Marca { get; set; }

        [Display(Name = "Data")]
        [Column("Data")]
        public string Data { get; set; }

        [Display(Name = "Destinatario")]
        [Column("Destinatario")]
        public string Destinatario { get; set; }

        [Display(Name = "Destino")]
        [Column("Destino")]
        public string Destino { get; set; }
    }
}