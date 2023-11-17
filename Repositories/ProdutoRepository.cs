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

        //public void Adicionar(Produto produto)
        public void Adicionar(T produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        //public void Atualizar(Produto produto)
        public void Atualizar(T produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        //public void Excluir(Produto produto)
        public void Excluir(T produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        //public Vendedor ObterPorId(int id)
        public T ObterPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }

        //public List<Produto> ObterTodos()
        public List<T> ObterTodos()
        {
            //List<Produto> todosProdutos = (List<Produto>)_context.Produtos;
            List<T> todosProdutos = (List<Produto>)_context.Produtos;

            return todosProdutos;
        }
    }
}