using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM_VIII.Models
{
    [Table("ItemCarrinho")]
    public class ItemCarrinho
    {
        [StringLength(45)]
        public string Quantidade { get; set; }

        [Column(TypeName = "float(7, 2)")]
        public float Total { get; set; }

        public virtual int CarrinhoId { get; set; }
        public virtual Carrinho Carrinho { get; set; }
        public virtual int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}