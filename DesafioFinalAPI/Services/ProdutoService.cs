using DesafioFinalAPI.Model;
using DesafioFinalAPI.Repository;

namespace DesafioFinalAPI.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Create(Produto produto)
        {
            _produtoRepository.Create(produto);
        }

        public void Update(Produto produto, int id)
        {
            _produtoRepository.Update(produto);
        }

        public void Delete(int id)
        {
            _produtoRepository.Delete(id);
        }

        public int Count()
        {
            return _produtoRepository.Count();
        }

        public List<Produto> FindAll()
        {
            return _produtoRepository.FindAll();
        }

        public Produto FindById(int id)
        {
            return _produtoRepository.FindById(id);
        }

        public Produto FindByName(string name)
        {
            return _produtoRepository.FindByName(name);
        }

    }
}