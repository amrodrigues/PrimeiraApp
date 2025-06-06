using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Antonieta",
                Email ="antonieta",
                EmailConfirmacao ="antonieta.com"
            };

            if ( TryValidateModel(aluno) )
            {
                return View(aluno);
            }
            var ms = ModelState;

            var erros = ModelState.Select(x => x.Value.Errors)
                .Where(y => y.Count >0)
                .ToList();

            erros.ForEach(x => Console.WriteLine(x.First().ErrorMessage));
            return View();
        }
    }
}
