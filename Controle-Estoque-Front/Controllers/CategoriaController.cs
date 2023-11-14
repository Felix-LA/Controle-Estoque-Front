using ControleEstoque.Domain.Models.DataModel;
using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Domain.Enums;

namespace Controle_Estoque_Front.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View(GetListCategorias());
        }

        public IActionResult FormCategoria()
        {
            return View();
        }

        [HttpGet]
        [Route("/Category/View/{Id:Int}", Name = "ViewCategoria")]

        public IActionResult View(int Id)
        {
            var listaCategorias = GetListCategorias();

            var categoria = listaCategorias.Where(c => c.Id.Equals(Id)).FirstOrDefault();

            return View(categoria);
        }

        private List<CategoriaViewModel> GetListCategorias()
        {
            CategoriaViewModel categoriaComida = new CategoriaViewModel();

            categoriaComida.Id = 1;
            categoriaComida.Name = "Comida";
            categoriaComida.Status = StatusEnum.Ativo;

            CategoriaViewModel categoriaEletronico = new CategoriaViewModel();

            categoriaEletronico.Id = 2;
            categoriaEletronico.Name = "Eletronico";
            categoriaEletronico.Status = StatusEnum.Ativo;

            List<CategoriaViewModel> listCategorias = new List<CategoriaViewModel>();
            listCategorias.Add(categoriaComida);
            listCategorias.Add(@categoriaEletronico);

            return listCategorias;

        }
    }
}
