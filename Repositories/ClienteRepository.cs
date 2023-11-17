using PIM_VIII.Data;
using PIM_VIII.Models;
using PIM_VIII.Repositories.Interfaces;

namespace PIM_VIII.Repositories
{
    public class ClienteRepository<T> : IRepository<T>
    {
        private readonly ApplicationDbContext _context;
        private T cliente;

        public ClienteRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void Adicionar(T cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Atualizar(T cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void Excluir(T cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public T ObterPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public List<T> ObterTodos()
        {
            List<T> todosClientes = (List<Cliente>)_context.Clientes;

            return todosClientes;
        }
    }
}
