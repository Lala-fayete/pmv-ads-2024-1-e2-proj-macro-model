using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macro_Model.Controllers
{
	[Route("Produto")]
	public class ProdutoController : Controller
	{
		private readonly AppDbContext _context;

		public ProdutoController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Produto()
		{
		
			return View();
		}
	}
}
