using PIM_VIII.Data;
using PIM_VIII.Models;

namespace PIM_VIII.Repositories
{
    public static class VendedorRepository
    {

        public static void Adicionar(Vendedor vendedor, ApplicationDbContext _context)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
        }

        public static void Atualizar(Vendedor vendedor, ApplicationDbContext _context)
        {
            _context.Vendedores.Update(vendedor);
            _context.SaveChanges();
        }

        public static void Excluir(Vendedor vendedor, ApplicationDbContext _context)
        {
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
        }

        public static Vendedor ObterPorId(int id, ApplicationDbContext _context)
        {
            return _context.Vendedores.FirstOrDefault(x => x.Id == id);
        }

        public static List<Vendedor> ObterTodos(ApplicationDbContext _context)
        {
            List<Vendedor> todosVendedores = (List<Vendedor>)_context.Vendedores;

            return todosVendedores;
        }
    }
}