using PIM_VIII.Models;
using PIM_VIII.Repositories.Interfaces;

namespace PIM_VIII.Repositories
{
    public class CarrinhoRepository<T> : IRepository<T>
    {
        private readonly ApplicationDbContext _context;
        private T carrinho;

        public CarrinhoRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void Adicionar(T carrinho)
        {
            _context.Carrinhos.Add(carrinho);
            _context.SaveChanges();
        }

        public void Atualizar(T carrinho)
        {
            _context.Carrinhos.Update(carrinho);
            _context.SaveChanges();
        }

        public void Excluir(T carrinho)
        {
            _context.Carrinhos.Remove(carrinho);
            _context.SaveChanges();
        }

        public T ObterPorId(int id)
        {
            return _context.Carrinhos.FirstOrDefault(x => x.Id == id);
        }

        public List<T> ObterTodos()
        {
            List<T> todosCarrinhos = (List<Carrinho>)_context.Carrinhos;

            return todosCarrinhos;
        }
    }
}