using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using PassAppDev.Data;

using PassAppDev.Models;
using PassAppDev.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassAppDev.Controllers
{
	[Authorize(Roles = Role.ADMIN)]
	public class AdminsController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly UserManager<ApplicationUser> _userManager;
		public AdminsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
		{
			_context = context;
			_userManager = userManager;

		}
		public IActionResult Index()
		{
			IEnumerable<Category> categories = _context.Categories
				.Where(t=>t.Status==Enums.CategoryStatus.Pending)
					.Include(t => t.ApplicationUser)
					.ToList();
			return View(categories);
		}

		[HttpGet]
		public IActionResult Reject(int id)
		{
			var categoryInDb = _context.Categories.SingleOrDefault(t => t.Id == id);
			if (categoryInDb is null)
			{
				return NotFound();
			}
			if(categoryInDb.OldName=="")
			{
				_context.Categories.Remove(categoryInDb);
			}
			else
			{
				categoryInDb.Name = categoryInDb.OldName;
				categoryInDb.OldName = "";
				categoryInDb.Status = Enums.CategoryStatus.Approved;
			}
			
			_context.SaveChanges();
			return RedirectToAction("Index");
		}


		[HttpGet]
		public IActionResult Approve(int id)
		{
			var categoryInDb = _context.Categories.SingleOrDefault(t => t.Id == id);

			if(categoryInDb==null)
			{
				return NotFound();
			}
			categoryInDb.Status = Enums.CategoryStatus.Approved;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult ApprovedCategories(int id)
		{
			IEnumerable<Category> categories = _context.Categories
				.Where(t => t.Status == Enums.CategoryStatus.Approved)
					.Include(t => t.ApplicationUser)
					.ToList();
			return View(categories);
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var categoryInDb = _context.Categories.SingleOrDefault(t => t.Id == id);
			if (categoryInDb is null)
			{
				return NotFound();
			}
			_context.Categories.Remove(categoryInDb);
			_context.SaveChanges();
			return RedirectToAction("ApprovedCategories");
		}
	}
}
