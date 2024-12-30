using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ScuolaController : Controller
    {
        [Route("/Scuola/Scuola")]
        public IActionResult Scuola()
        {
            return View();
        }
    }
}
