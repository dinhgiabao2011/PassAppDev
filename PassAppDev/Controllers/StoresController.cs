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
using System.Threading.Tasks;

using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using static System.Net.Mime.MediaTypeNames;

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

		//public IActionResult GetNotification()
		//{
		//	var notiVMList = new List<NotificationVM>();

		//	IEnumerable<Notification> notifications = _context.Notifications.ToList();

		//	foreach (var noti in notifications)

		//	{
		//		var notificationViewModel = new NotificationVM()
		//		{
		//			CategoryName = noti.CategoryName,
		//			Decision = noti.Decision,
		//			Action = noti.Action,
		//			NotifiedAt = noti.NotifiedAt,
		//	};
		//		notiVMList.Add(notificationViewModel);
		//	}

		//	return View("~/Views/Stores/Index.cshtml", notiVMList);

		//}
	}
}
