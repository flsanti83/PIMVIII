using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM_VIII.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(45)]
        public string Descricao { get; set; }

        [Column(TypeName = "float(7, 2)")]
        public float Preco { get; set; }

        [StringLength(200)]
        public string Imagem { get; set; }

        public bool Status { get; set; }

        public virtual int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
