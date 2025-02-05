using DesafioFinalAPI.Model;
using DesafioFinalAPI.Repository;
using DesafioFinalAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinalAPI.Controllers
{
    [ApiController]
    [Route("api/v1/produto")]
    public class ProdutoController : ControllerBase
    {

        //private readonly IProdutoRepository _produtoRepository;
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public IActionResult Create([Bind("id,nome,descricao,preco,estoque")] Produto produto)
        {
            if (produto.id == 0 || produto.nome == null)
            {
                return BadRequest();
            }

            _produtoService.Create(produto);

            return Ok(produto);
        }

        [HttpPatch]
        public IActionResult Update([Bind("id, nome,descricao,preco,estoque")] Produto produto, int id)
        {
            if (id != produto.id)
            {
                return NotFound();
            }

            _produtoService.Update(produto, id);

              return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            var produto = _produtoService.FindById(id);

            if (produto == null)
            {
                return NotFound();
            }

            _produtoService.Delete(id);

              return Ok();
        }


        [HttpGet]
        [Route("Count")]
        public IActionResult Count()
        {
            var count = _produtoService.Count();


            return Ok(count);
        }

        [HttpGet]
        [Route("FindAll")]
        public IActionResult FindAll()
        {
            var produtos = _produtoService.FindAll();

            return Ok(produtos);
        }
        
        [HttpGet]
        [Route("FindById")]
        public IActionResult FindById(int id)
        {
            var produto = _produtoService.FindById(id);

            return produto == null ? NotFound() : Ok(produto);
        }

        [HttpGet]
        [Route("FindByName")]
        public IActionResult FindByName(string name)
        {
            var produto = _produtoService.FindByName(name);

            return produto == null ? NotFound() : Ok(produto);
        }

    }
}
