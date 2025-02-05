using DesafioFinalAPI.Model;

namespace DesafioFinalAPI.Repository
{
    public interface IProdutoRepository
    {
        void Create(Produto produto);
        void Delete(int id);
        void Update(Produto produto);
        int Count();
        List<Produto> FindAll();
        Produto FindById(int id);
        Produto FindByName(string name);

    }
}
