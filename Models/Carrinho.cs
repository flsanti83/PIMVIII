using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM_VIII.Models
{
    [Table("Carrinho")]
    public class Carrinho
    {
        [Key]
        public int Id { get; set; }

        public DateOnly DataPedido { get; set; }

        [Column(TypeName = "float(7, 2)")]
        public float ValorTotal { get; set; }

        public virtual int StatusPedidoId { get; set; }
        public virtual StatusPedido StatusPedido { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}