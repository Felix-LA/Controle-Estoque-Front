using ControleEstoque.Domain.Models.DataModel;
using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Domain.Enums;

namespace Controle_Estoque_Front.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            CategoriaViewModel categoriaViewModel = new CategoriaViewModel();

            categoriaViewModel.Name = "Comida";
            categoriaViewModel.Status = CategoryStatusEnum.Ativo;

            List<CategoriaViewModel> listCategorias = new List<CategoriaViewModel>();
            listCategorias.Add(categoriaViewModel);

            return View(listCategorias);
        }

        public IActionResult FormCategoria()
        {
            return View();
        }
    }
}
