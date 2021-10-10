using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using PorjetoPortfolios.Models;

namespace PorjetoPortfolios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _contexto;

        public HomeController(ApplicationContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {            
            return View();
        }

        public IActionResult Contact()
        {            
            return View();
        }

        public IActionResult Estudy()
        {            
            var links = _contexto.ImagemDosCursos.ToList();
            return View(links);
        }

        public IActionResult ErroEmail()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }                
    }
}
