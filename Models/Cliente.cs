using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace PIM_VIII.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [StringLength(256)]
        public string Nome { get; set; }

        public BigInteger CPF { get; set; }

        [StringLength(70)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Senha { get; set; }

        public virtual int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}