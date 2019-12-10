using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PGP.Models;

namespace PGP.Controllers
{
    public class HomeController : Controller
    {
        public static string nome;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Termos()
        {
            return View();
        }

        public IActionResult Selecao()
        {
            return View();
        }

        public IActionResult Desempenho(string name)
        {
            nome = name;
            ViewData["Nome"] = nome;
            return View();
        }

        public IActionResult Habilidades()
        {
            ViewData["Nome"] = nome;
            return View();
        }

        public IActionResult Comportamento()
        {
            ViewData["Nome"] = nome;
            return View();
        }

        public IActionResult AspectosLegais()
        {
            ViewData["Nome"] = nome;
            return View();
        }

        public IActionResult FeedbackGeral()
        {
            ViewData["Nome"] = nome;
            return View();
        }

        public IActionResult UltimaEtapa()
        {
            ViewData["Nome"] = nome;
            return View();
        }

        public IActionResult Final()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
