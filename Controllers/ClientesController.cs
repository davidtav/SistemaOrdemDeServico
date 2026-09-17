using Microsoft.AspNetCore.Mvc;

namespace GestorOrdemDeServico.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
