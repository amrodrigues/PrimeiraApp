using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class TestesController : Controller

    {

        public AppDbContext Db { get; set; }

        public TestesController(AppDbContext db)
        {
            Db = db;
        }

        // GET: TestesController
        public ActionResult Index()
        {
            var alunos = new Aluno()
            {
                Nome = "Joana da Silva",
                Email= "joana@teste.com",
                DataNascimento = new DateTime(1990, 5, 20),
                Avaliacao = 8,
                Ativo = true    

            };
            Db.Alunos.Add(alunos);
            Db.SaveChanges();


            return View();
        }

        // GET: TestesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
