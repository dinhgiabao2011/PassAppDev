using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PassAppDev.Data;
using PassAppDev.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassAppDev.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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


        public async Task<IActionResult> Order()
        {
            var currentUserId = _userManager.GetUserId(HttpContext.User);
            var booksInCart = _context.CartBooks.Where(t => t.ApplicationUserId == currentUserId).ToList();
            if (!booksInCart.Any())
            {
                return RedirectToAction("Index");
            }
            var newOrder = new Order
            {
                ApplicationUserId = currentUserId,
            };
            _context.Add(newOrder);
            await _context.SaveChangesAsync();
            var orderInDb = _context.Orders.OrderByDescending(t => t.Id).First();
            var booksInOrder = new List<OrderedBook>();
            foreach (var item in booksInCart)
            {
                var newOrderedBook = new OrderedBook
                {
                    OrderId = orderInDb.Id,
                    BookId = item.BookId,
                    Quantity = item.Quatity,
                    Price = item.Price,
                };
                booksInOrder.Add(newOrderedBook);
            }

            _context.OrderedBooks.AddRange(booksInOrder);
            _context.RemoveRange(booksInCart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
