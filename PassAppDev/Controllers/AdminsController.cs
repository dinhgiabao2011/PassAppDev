using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using PassAppDev.Data;

using PassAppDev.Models;
using PassAppDev.Utils;
using PassAppDev.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PassAppDev.Controllers
{
	[Authorize(Roles = Role.ADMIN)]
	public class AdminsController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly UserManager<ApplicationUser> _userManager;
		PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
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
			var notification = new Notification()
			{
				ApplicationUserId = categoryInDb.ApplicationUserId,
				CategoryId = categoryInDb.Id,
				CategoryName = categoryInDb.Name,
				Decision = "REJECTED"
			};
			if (categoryInDb.OldName == null)
			{
				notification.Action = "ADDING";
				_context.Categories.Remove(categoryInDb);
			}
			else
			{
				notification.Action = "EDITTING";
				categoryInDb.Name = categoryInDb.OldName;
				categoryInDb.OldName = null;
				categoryInDb.Status = Enums.CategoryStatus.Approved;
			}
			_context.Add(notification);
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
            var notification = new Notification()
            {
                ApplicationUserId = categoryInDb.ApplicationUserId,
                CategoryId = categoryInDb.Id,
                CategoryName = categoryInDb.Name,
				Decision = "APPROVED"
            };
			if (categoryInDb.OldName == null)
            {
				notification.Action = "ADDING";
            }
            else
            {
				notification.Action = "EDITTING";
			}
            categoryInDb.Status = Enums.CategoryStatus.Approved;
			categoryInDb.OldName = null;
			_context.Add(notification);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult ApprovedCategories()
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

		[HttpGet]
		public IActionResult Customers()
		{
			var customer = _userManager.GetUsersInRoleAsync(Role.CUSTOMER).Result;
			return View(customer);
		}

		[HttpGet]
		public IActionResult DeleteCustomer(string id) {
			var userInDb = _context.ApplicationUsers.SingleOrDefault(t => t.Id.Equals(id));
			if (userInDb is null)
			{
				return NotFound();
			}
			_context.ApplicationUsers.Remove(userInDb);
			_context.SaveChanges();
			return RedirectToAction("Customers");
		}

		[HttpGet]
		public IActionResult StoreOwners()
		{
			var storeOwner = _userManager.GetUsersInRoleAsync(Role.STOREOWNER).Result;
			return View(storeOwner);
		}

		[HttpGet]
		public IActionResult ChangeCustomerPassword(string id)
		{
			var userInDb = _context.ApplicationUsers.SingleOrDefault(t => t.Id == id);

			if (userInDb is null)
			{
				return NotFound();
			}
			
			return View(userInDb);
		}

		[HttpGet]
		public IActionResult ChangeStoreOwnerPassword(string id)
		{
			var userInDb = _context.ApplicationUsers.SingleOrDefault(t => t.Id == id);

			if (userInDb is null)
			{
				return NotFound();
			}

			return View(userInDb);
		}

		[HttpPost]
		public IActionResult ChangeCustomerPassword(ApplicationUser user)
		{
			var userInDb = _context.ApplicationUsers.SingleOrDefault(t => t.Id == user.Id);

			if (userInDb is null)
			{
				return BadRequest();
			}

			if (!ModelState.IsValid)
			{
				return View(userInDb);
			}
			
			userInDb.PasswordHash = passwordHasher.HashPassword(null, user.PasswordHash);
			_context.SaveChanges();

			return RedirectToAction("Customers");
		}

		[HttpPost]
		public IActionResult ChangeStoreOwnerPassword(ApplicationUser user)
		{
			var userInDb = _context.ApplicationUsers.SingleOrDefault(t => t.Id == user.Id);

			if (userInDb is null)
			{
				return BadRequest();
			}

			if (!ModelState.IsValid)
			{
				return View(userInDb);
			}

			if (user.PasswordHash != null)
			{
				userInDb.PasswordHash = passwordHasher.HashPassword(null, user.PasswordHash);
			}
			
			_context.SaveChanges();

			return RedirectToAction("StoreOwners");
		}
	}
}
