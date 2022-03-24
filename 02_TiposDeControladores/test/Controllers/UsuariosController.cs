using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test.Models;

namespace test.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsuariosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ContentResult Registro(bool Encontrado)
        {
            if (Encontrado)
                return Content("<h3>Registro usuarios encontrado...</h3>");
            else
                return Content("<h3>Registro usuarios no encontrado...</h3>");
        }

        public IActionResult Registro(bool Encontrado)
        {
            if (Encontrado)
                return Content("Registro encontrado");
            else
                return StatusCode(404);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
