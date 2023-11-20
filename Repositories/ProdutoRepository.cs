using PIM_VIII.Data;
using PIM_VIII.Models;

namespace PIM_VIII.Repositories
{
    public class ProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public static void Adicionar(Produto produto, ApplicationDbContext _context)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void Excluir(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public Produto ObterPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }

        public List<Produto> ObterTodos()
        {
            List<Produto> todosProdutos = (List<Produto>)_context.Produtos;

            return todosProdutos;
        }
    }
}