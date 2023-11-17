namespace PIM_VIII.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        //void Adicionar(Offer offer);
        void Adicionar(T dado);

        void Atualizar(T dado);

        void Excluir(T dado);

        //Offer ObterPorId(int id);
        T ObterPorId(int id);

        //List<Offer> ObterTodos();
        List<T> ObterTodos();
    }
}
