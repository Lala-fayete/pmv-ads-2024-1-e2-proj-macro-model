using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macro_Model.Controllers
{
	[Route("Login")]
	public class LoginController : Controller
	{
		private readonly AppDbContext _context;

		public LoginController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Login()
		{
		
			return View();
		}
	}
}
