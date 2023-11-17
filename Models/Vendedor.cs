using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM_VIII.Models
{
    [Table("Vendedor")]
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string RazaoSocial { get; set; }

        [StringLength(70)]
        public string NomeFantasia { get; set; }

        [StringLength(70)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Senha { get; set; }

        [StringLength(18)]
        public string Cnpj { get; set; }

        public int Comissao { get; set; }

        public virtual int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}