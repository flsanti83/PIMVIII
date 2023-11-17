using PIM_VIII.Models;

namespace PIM_VIII.Repositories
{
    public class CarrinhoRepository
    {
        private readonly ApplicationDbContext _context;

        public CarrinhoRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void Adicionar(Carrinho carrinho)
        {
            _context.Carrinhos.Add(carrinho);
            _context.SaveChanges();
        }

        public void Atualizar(Carrinho carrinho)
        {
            _context.Carrinhos.Update(carrinho);
            _context.SaveChanges();
        }

        public void Excluir(Carrinho carrinho)
        {
            _context.Carrinhos.Remove(carrinho);
            _context.SaveChanges();
        }

        public Vendedor ObterPorId(int id)
        {
            return _context.Carrinhos.FirstOrDefault(x => x.Id == id);
        }

        public List<Carrinho> ObterTodos()
        {
            List<Carrinho> todosCarrinhos = (List<Carrinho>)_context.Carrinhos;

            return todosCarrinhos;
        }
    }
}