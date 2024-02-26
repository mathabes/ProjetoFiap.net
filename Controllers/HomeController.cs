using Microsoft.AspNetCore.Mvc;
using RM98502.Models;
using System.Diagnostics;

namespace RM98502.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Aluno()
        {
            string nomeAluno = "Matheus";
            
            Aluno aluno = new Aluno();
            aluno.SetNome(nomeAluno);
            aluno.Rm = 12345;
            aluno.Email = "12345@fiap.com.br";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
