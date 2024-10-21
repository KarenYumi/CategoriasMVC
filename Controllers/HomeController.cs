using CategoriasMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CategoriasMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
