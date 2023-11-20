using PIM_VIII.Data;
using PIM_VIII.Models;

namespace PIM_VIII.Repositories
{
    public static class ProdutoRepository
    {

        public static void Adicionar(Produto produto, ApplicationDbContext _context)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public static void Atualizar(Produto produto, ApplicationDbContext _context)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public static void Excluir(Produto produto, ApplicationDbContext _context)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public static Produto ObterPorId(int id, ApplicationDbContext _context)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }

        public static List<Produto> ObterTodos(ApplicationDbContext _context)
        {
            List<Produto> todosProdutos = (List<Produto>)_context.Produtos;

            return todosProdutos;
        }
    }
}