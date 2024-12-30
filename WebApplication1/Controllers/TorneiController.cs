using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TorneiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Tornei/Tornei")]
        public IActionResult Tornei()

        {
            return View();
        }
     
        
    }
}
