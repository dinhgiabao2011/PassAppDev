using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PassAppDev.Data;
using PassAppDev.Models;
using PassAppDev.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace PassAppDev.Controllers
{
    [Authorize(Roles = Role.CUSTOMER)]
    public class CartBooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public CartBooksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var currentUserId = _userManager.GetUserId(HttpContext.User);
           IEnumerable<CartBook> booksInCart = _context.CartBooks
                .Include(t => t.Book)
                .Where(t => t.ApplicationUserId == currentUserId)
                .ToList();
            return View(booksInCart);
        }
        
        public async Task<IActionResult> AddToCart(int id)
        {
            var bookInStore = _context.Books.SingleOrDefault(t => t.Id == id);
            var currentUserId = _userManager.GetUserId(HttpContext.User);
            
            var bookInCart = _context.CartBooks.SingleOrDefault(
                t => t.ApplicationUserId == currentUserId && 
                t.BookId == id);
            if (bookInCart == null)
            {
                var cartBook = new CartBook()
                {
                    ApplicationUserId = currentUserId,
                    BookId = id,
                    Quatity = 1,
                    Price = bookInStore.Price
                };
                _context.Add(cartBook);
            }
            else
            {
                bookInCart.Quatity++;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            
            var bookInCart = await _context.CartBooks.SingleOrDefaultAsync(t=>t.Id==id);
            if (bookInCart == null)
            {
                return NotFound();
            }

            _context.CartBooks.Remove(bookInCart);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        
    }
}
