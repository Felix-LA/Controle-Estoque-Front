using Microsoft.AspNetCore.Mvc;

namespace Controle_Estoque_Front.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
