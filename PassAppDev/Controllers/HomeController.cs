using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PassAppDev.Data;
using PassAppDev.Models;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PassAppDev.Controllers
{
	public class HomeController : Controller
	{
		private ApplicationDbContext _context;
		private readonly ILogger<HomeController> _logger;

		public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
		{
			_context = context;
			_logger = logger;
		}

		public IActionResult Index(string keyWord)
		{

			if (!string.IsNullOrWhiteSpace(keyWord))
			{
				var result = _context.Books
					.Include(t => t.Category)
					.Where(t => t.Category.Name.Contains(keyWord)
							|| t.Title.Contains(keyWord)
					)
					.ToList();

				return View(result);
			}

			IEnumerable<Book> books = _context.Books
				.Include(t => t.Category)
				.ToList();

			return View(books);
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

		[HttpGet]
		public IActionResult BookDetails(int id)
		{
			var bookInDb = _context.Books.Include(t => t.Category)
					.SingleOrDefault(t => t.Id == id);
			if (bookInDb is null)
			{
				return NotFound();
			}

			return View(bookInDb);
		}
	}
}
