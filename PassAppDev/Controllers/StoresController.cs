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

using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace PassAppDev.Controllers
{
	[Authorize(Roles = Role.STOREOWNER)]
	public class StoresController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly UserManager<ApplicationUser> _userManager;
		public StoresController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
		{
			_context = context;
			_userManager = userManager;

		}
		public IActionResult Index()
		{

			IEnumerable<Order> orders = _context.Orders
								.Include(t => t.ApplicationUser)
								.ToList();
			return View(orders);
		}
		[HttpGet]
		public IActionResult Details(int id)
		{
			IEnumerable<OrderedBook> orderedBooks = _context.OrderedBooks
																							.Include(t => t.Order)
																							.Where(t => t.OrderId == id)
																							.ToList();
			return View(orderedBooks);
		}

		public async Task<IActionResult> SearchUser(string email)
		{
			var customer = _userManager.GetUsersInRoleAsync(Role.CUSTOMER).Result;

			//await (from user in _context.ApplicationUsers
			//										join userRole in _context.UserRoles
			//										on user.Id equals userRole.UserId
			//										join role in _context.Roles on userRole.RoleId
			//										equals role.Id where role.Name == "customer" select user).ToListAsync();

			if (!string.IsNullOrWhiteSpace(email))
			{

				var result = customer
									.Where(t => t.Email.Contains(email)
							)
									.ToList();

				return View(result);
			}


			return View(customer);

		}
	}
}
