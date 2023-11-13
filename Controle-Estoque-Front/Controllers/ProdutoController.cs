using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Domain.Models.DataModel;
using ControleEstoque.Domain.Enums;

namespace Controle_Estoque_Front.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            CategoriaViewModel categoriaViewModel = new CategoriaViewModel();

            categoriaViewModel.Name = "Comida";
            categoriaViewModel.Status = CategoryStatusEnum.Ativo;

            produtoViewModel.Name = "Melancia";
            produtoViewModel.Price = 10;
            produtoViewModel.Quantity = 20;
            produtoViewModel.Categoria = categoriaViewModel;
            produtoViewModel.Description = "Uma Fruta";



            List<ProdutoViewModel> listProdutos = new List<ProdutoViewModel>();
            listProdutos.Add(produtoViewModel);

            return View(listProdutos);
        }

        public IActionResult FormProduto()
        {
            return View();
        }
    }
}
