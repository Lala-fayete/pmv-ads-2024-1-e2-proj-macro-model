using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Macro_Model.Controllers
{
	
	public class ProdutoController : Controller
	{
		private readonly AppDbContext _context;

		public ProdutoController(AppDbContext context)
		{
			_context = context;
		}

        public async Task<IActionResult> Lista()
        {
            var dados = await _context.Produto.ToListAsync();

            return View(dados);
        }

        
        public IActionResult Produto()
		{
		
			return View();
		}

        [HttpPost]
        public async Task<IActionResult> Produto(Produto produto)
        {

            if (ModelState.IsValid)
            {
                _context.Produto.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Lista");
            }
            return View(produto);
        }

        public async Task<IActionResult> Editar(string? id)
        {

            if (id == null)
                return NotFound();

            var dados = await _context.Produto.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(string id, Produto produto)
        {
            if (id != produto.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Produto.Update(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Lista");
            }
            return View();
        }

        public async Task<IActionResult> Detalhe(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Produto.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);

        }

        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Produto.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Produto.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Produto.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Lista");

        }
    }
}
