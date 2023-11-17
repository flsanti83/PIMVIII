using PIM_VIII.Data;
using PIM_VIII.Models;
using PIM_VIII.Repositories.Interfaces;

namespace PIM_VIII.Repositories
{
    public class ProdutoRepository<T> : IRepository<T>
    {
        private readonly ApplicationDbContext _context;
        private T produto;

        public ProdutoRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void Adicionar(T produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Atualizar(T produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void Excluir(T produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public T ObterPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }

        public List<T> ObterTodos()
        {
            List<T> todosProdutos = (List<Produto>)_context.Produtos;

            return todosProdutos;
        }
    }
}