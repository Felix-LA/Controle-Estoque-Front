using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Domain.Models.DataModel;
using ControleEstoque.Domain.Enums;

namespace Controle_Estoque_Front.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ProdutoViewModel produtoMelancia = new ProdutoViewModel();
            CategoriaViewModel categoriaComida = new CategoriaViewModel();

            categoriaComida.Name = "Comida";
            categoriaComida.Status = CategoryStatusEnum.Ativo;

            produtoMelancia.Name = "Melancia";
            produtoMelancia.Price = 10;
            produtoMelancia.Quantity = 20;
            produtoMelancia.Categoria = categoriaComida;
            produtoMelancia.Description = "Uma Fruta";


            ProdutoViewModel produtoCelular = new ProdutoViewModel();
            CategoriaViewModel categoriaEletronico = new CategoriaViewModel();

            categoriaEletronico.Name = "Eletronicos";
            categoriaEletronico.Status = CategoryStatusEnum.Ativo;

            produtoCelular.Name = "Celular";
            produtoCelular.Price = 1000;
            produtoCelular.Quantity = 9;
            produtoCelular.Categoria = categoriaEletronico;
            produtoCelular.Description = "Um Smartphone";

            List<ProdutoViewModel> listProdutos = new List<ProdutoViewModel>();
            listProdutos.Add(produtoMelancia);
            listProdutos.Add(produtoCelular);

            return View(listProdutos);
        }

        public IActionResult FormProduto()
        {
            return View();
        }
    }
}
