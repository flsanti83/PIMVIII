namespace PIM_VIII.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void Adicionar(T dado);

        void Atualizar(T dado);

        void Excluir(T dado);

        T ObterPorId(int id);

        List<T> ObterTodos();
    }
}
