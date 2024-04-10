using System.Diagnostics;
using Macro_Model.Interfaces;
using Macro_Model.Models;
using Macro_Model.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Macro_Model.Controllers
{

	public class CadastroController : Controller
	{
		private readonly AppDbContext _context;

		public CadastroController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Usuario()
		{
			var dados = await _context.Cadastro.ToListAsync();

			return View(dados);
		}


		public IActionResult Cadastro()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Cadastro(Cadastro cadastro)
		{

			if (ModelState.IsValid)
			{
				_context.Cadastro.Add(cadastro);
				await _context.SaveChangesAsync();
				return RedirectToAction("Usuario");
			}
			return View(cadastro);
		}


		public async Task<IActionResult> Edit(string? id)
		{

			if (id == null)
				return NotFound();

			var dados = await _context.Cadastro.FindAsync(id);

			if (dados == null)
				return NotFound();

			return View(dados);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(string id, Cadastro cadastro)
		{
			if (id != cadastro.Cpf)
				return NotFound();

			if (ModelState.IsValid)
			{
				_context.Cadastro.Update(cadastro);
				await _context.SaveChangesAsync();
				return RedirectToAction("Usuario");
			}
			return View();
		}

		public async Task<IActionResult> Detalhe(string? id)
		{
			if (id == null)
				return NotFound();

			var dados = await _context.Cadastro.FindAsync(id);

			if (dados == null)
				return NotFound();

			return View(dados);

		}

        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cadastro.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);

        }

		[HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cadastro.FindAsync(id);

            if (dados == null)
                return NotFound();

			_context.Cadastro.Remove(dados);
			await _context.SaveChangesAsync();

            return RedirectToAction("Usuario");

        }
    }
}

