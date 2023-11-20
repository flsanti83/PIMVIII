using PIM_VIII.Data;
using PIM_VIII.Models;

namespace PIM_VIII.Repositories
{
    public static class ClienteRepository
    {

        public static void Adicionar(Cliente cliente, ApplicationDbContext _context)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public static void Atualizar(Cliente cliente, ApplicationDbContext _context)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public static void Excluir(Cliente cliente, ApplicationDbContext _context)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public static Cliente ObterPorId(int id, ApplicationDbContext _context)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public static List<Cliente> ObterTodos(ApplicationDbContext _context)
        {
            List<Cliente> todosClientes = (List<Cliente>)_context.Clientes;

            return todosClientes;
        }
    }
}