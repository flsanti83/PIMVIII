using PIM_VIII.Data;
using PIM_VIII.Models;

namespace PIM_VIII.Repositories
{
    public static class CarrinhoRepository
    {

        public static void Adicionar(Carrinho carrinho, ApplicationDbContext _context)
        {
            _context.Carrinhos.Add(carrinho);
            _context.SaveChanges();
        }

        public static void Atualizar(Carrinho carrinho, ApplicationDbContext _context)
        {
            _context.Carrinhos.Update(carrinho);
            _context.SaveChanges();
        }

        public static void Excluir(Carrinho carrinho, ApplicationDbContext _context)
        {
            _context.Carrinhos.Remove(carrinho);
            _context.SaveChanges();
        }

        public static Carrinho ObterPorId(int id, ApplicationDbContext _context)
        {
            return _context.Carrinhos.FirstOrDefault(x => x.Id == id);
        }

        public static List<Carrinho> ObterTodos(ApplicationDbContext _context)
        {
            List<Carrinho> todosCarrinhos = (List<Carrinho>)_context.Carrinhos;

            return todosCarrinhos;
        }
    }
}