using Microsoft.AspNetCore.Mvc;

namespace MinhaMVC.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View;
        }



        private IActionResult View { get; }
    }
    }

