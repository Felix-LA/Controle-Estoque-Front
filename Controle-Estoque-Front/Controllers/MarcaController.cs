using ControleEstoque.Domain.Models.DataModel;
using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Domain.Enums;

namespace Controle_Estoque_Front.Controllers
{
    public class MarcaController : Controller
    {
        public IActionResult Index()
        {
            return View(GetListMarca());
        }

        public IActionResult FormMarca()
        {
            return View();
        }

        [HttpGet]
        [Route("/Marca/View/{Id:Int}", Name = "ViewMarca")]

        public IActionResult View(int Id)
        {
            var listaMarca = GetListMarca();

            var marca = listaMarca.Where(m => m.Id.Equals(Id)).FirstOrDefault();

            return View(marca);
        }

        private List<MarcaViewModel> GetListMarca()
        {
            MarcaViewModel marcaSamsung = new MarcaViewModel();

            marcaSamsung.Id = 1;
            marcaSamsung.Name = "Samsung";
            marcaSamsung.Status = StatusEnum.Ativo;
            
            List<MarcaViewModel> listMarcas = new List<MarcaViewModel>();
            listMarcas.Add(marcaSamsung);

            return listMarcas;

        }
    }
}
