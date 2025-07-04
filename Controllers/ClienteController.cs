using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebZasylogic.Models;

namespace WebZasylogic.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Informe()
        {
            return View();
        }

    }
}
