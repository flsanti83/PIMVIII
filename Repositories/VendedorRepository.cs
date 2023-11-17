using PIM_VIII.Models;
using PIM_VIII.Repositories.Interfaces;

namespace PIM_VIII.Repositories
{
    public class VendedorRepository<T> : IRepository<T>
    {
        private readonly ApplicationDbContext _context;
        private T vendedor;

        public VendedorRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void Adicionar(T vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
        }

        public void Atualizar(T vendedor)
        {
            _context.Vendedores.Update(vendedor);
            _context.SaveChanges();
        }

        public void Excluir(T vendedor)
        {
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
        }

        public T ObterPorId(int id)
        {
            return _context.Vendedores.FirstOrDefault(x => x.Id == id);
        }

        public List<T> ObterTodos()
        {
            List<T> todosVendedores = (List<Vendedor>)_context.Vendedores;

            return todosVendedores;
        }
    }
}
