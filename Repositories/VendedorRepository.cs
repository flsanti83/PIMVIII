using PIM_VIII.Models;

namespace PIM_VIII.Repositories
{
    public class VendedorRepository
    {
        private readonly ApplicationDbContext _context;

        public VendedorRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void Adicionar(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
        }

        public void Atualizar(Vendedor vendedor)
        {
            _context.Vendedores.Update(vendedor);
            _context.SaveChanges();
        }

        public void Excluir(Vendedor vendedor)
        {
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
        }

        public Vendedor ObterPorId(int id)
        {
            return _context.Vendedores.FirstOrDefault(x => x.Id == id);
        }

        public List<Vendedor> ObterTodos()
        {
            List<Vendedor> todosVendedores = (List<Vendedor>)_context.Vendedores;

            return todosVendedores;
        }
    }
}
