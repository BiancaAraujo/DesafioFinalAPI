using DesafioFinalAPI.Data;
using DesafioFinalAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinalAPI.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
       private readonly ConnectionContext _context = new ConnectionContext();

        public void Create(Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
        }

        public void Update(Produto produto)
        {
            _context.Produto.Update(produto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Produto.Where(p => p.id == id).ExecuteDelete();
        }

        public int Count()
        {
            return _context.Produto.Count();
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.ToList();
        }

        public Produto FindById(int id)
        {
            return _context.Produto.Find(id);
        }

        public Produto FindByName(string name)
        {
            return _context.Produto.Where(p => p.nome == name).FirstOrDefault();
        }
    }
}
