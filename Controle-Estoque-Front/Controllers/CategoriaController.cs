using ControleEstoque.Domain.Models.DataModel;
using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Domain.Enums;

namespace Controle_Estoque_Front.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            CategoriaViewModel categoriaComida = new CategoriaViewModel();

            categoriaComida.Name = "Comida";
            categoriaComida.Status = CategoryStatusEnum.Ativo;

            CategoriaViewModel categoriaEletronico= new CategoriaViewModel();

            categoriaEletronico.Name = "Eletronico";
            categoriaEletronico.Status = CategoryStatusEnum.Ativo;

            List<CategoriaViewModel> listCategorias = new List<CategoriaViewModel>();
            listCategorias.Add(categoriaComida);
            listCategorias.Add(@categoriaEletronico);

            return View(listCategorias);
        }

        public IActionResult FormCategoria()
        {
            return View();
        }
    }
}
