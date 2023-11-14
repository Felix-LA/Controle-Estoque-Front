using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Domain.Models.DataModel;
using ControleEstoque.Domain.Enums;

namespace Controle_Estoque_Front.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View(GetListProdutos());
        }

        public IActionResult FormProduto()
        {
            return View();
        }

        [HttpGet]
        [Route("/Products/View/{Id:Int}", Name = "ViewProduto")]

        public IActionResult View(int Id)
        {
            var listaProdutos = GetListProdutos();

            var produto = listaProdutos.Where(p => p.Id.Equals(Id)).FirstOrDefault();

            return View(produto);
        }

        private List<ProdutoViewModel> GetListProdutos()
        {

            ProdutoViewModel produtoMelancia = new ProdutoViewModel();
            CategoriaViewModel categoriaComida = new CategoriaViewModel();

            categoriaComida.Name = "Comida";
            categoriaComida.Status = StatusEnum.Ativo;

            produtoMelancia.Id = 1;
            produtoMelancia.Name = "Melancia";
            produtoMelancia.Price = 10;
            produtoMelancia.Quantity = 20;
            produtoMelancia.Categoria = categoriaComida;
            produtoMelancia.Description = "Uma Fruta";


            ProdutoViewModel produtoCelular = new ProdutoViewModel();
            CategoriaViewModel categoriaEletronico = new CategoriaViewModel();

            categoriaEletronico.Name = "Eletronicos";
            categoriaEletronico.Status = StatusEnum.Ativo;

            produtoCelular.Id = 2;
            produtoCelular.Name = "Celular";
            produtoCelular.Price = 1000;
            produtoCelular.Quantity = 9;
            produtoCelular.Categoria = categoriaEletronico;
            produtoCelular.Description = "Um Smartphone";

            List<ProdutoViewModel> listProdutos = new List<ProdutoViewModel>();
            listProdutos.Add(produtoMelancia);
            listProdutos.Add(produtoCelular);

            return listProdutos;

        }
    }
}
