﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PassAppDev.Data;
using PassAppDev.Models;
using PassAppDev.ViewModels;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
			var bookVMList = new List<BookViewModel>();
			if (!string.IsNullOrWhiteSpace(keyWord))
			{
				var result = _context.Books
					.Include(t => t.Category)
					.Where(t => t.Category.Name.Contains(keyWord)
							|| t.Title.Contains(keyWord)
					)
					.ToList();

				foreach (var book in result)
				{
					string imageBase64 = Convert.ToBase64String(book.ImageData);

					string image = string.Format("data:image/jpg;base64,{0}", imageBase64);

					var newbookVM = new BookViewModel()
					{
						Title = book.Title,
						Author = book.Author,
						Price = book.Price,
						Id = book.Id,
						ImageUrl = image
					};
					bookVMList.Add(newbookVM);
				}
				return View(bookVMList);
			}

			IEnumerable<Book> books = _context.Books
				.Include(t => t.Category)
				.ToList();

			foreach (var book in books)
			{
				string imageBase64 = Convert.ToBase64String(book.ImageData);

				string image = string.Format("data:image/jpg;base64,{0}", imageBase64);
		
				var newbookVM = new BookViewModel()
				{
					Title = book.Title,
					Author = book.Author,
					Price = book.Price,
					Id = book.Id,
					ImageUrl = image
				};
				bookVMList.Add(newbookVM);
			}
			return View("~/Views/Home/Index.cshtml", bookVMList);
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

		[HttpGet]
		public IActionResult GetImage(int id)
		{
			var bookInDb = _context.Books.SingleOrDefault(t => t.Id == id);

			string imageBase64 = Convert.ToBase64String(bookInDb.ImageData);

			string image = string.Format("data:image/jpg;base64, {0}", imageBase64);

			ViewBag.ImageData = image;

			return File(image, "image/jpg");
			
		}
	}
}
