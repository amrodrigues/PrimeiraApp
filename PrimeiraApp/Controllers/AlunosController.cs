﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao,Ativo")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
               
                _context.Alunos.Add(aluno); 
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(aluno);
        }

        public async Task<IActionResult> Details(int id)
		{
			var aluno = await _context.Alunos.FindAsync(id);
            //var aluno = await _context.Alunos.FirstOrDefaultAsync(a => a.Id == id);

			if (aluno == null)
			{
				return NotFound();
			}
			return View(aluno);
		}

		public async Task<IActionResult> Edit(int id)
		{
			var aluno = await _context.Alunos.FindAsync(id);
			//var aluno = await _context.Alunos.FirstOrDefaultAsync(a => a.Id == id);

			if (aluno == null)
			{
				return NotFound();
			}
			return View(aluno);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNascimento,Email,Avaliacao,Ativo")] Aluno aluno)
		{
			if (id != aluno.Id)
			{
				return NotFound();
			}

			ModelState.Remove("EmailConfirmacao");

			if (ModelState.IsValid)
			{

				_context.Alunos.Update(aluno);
				await _context.SaveChangesAsync();

				return RedirectToAction(nameof(Index));
			}

			return View(aluno);
		}


	}
}
