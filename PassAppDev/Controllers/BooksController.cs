using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PassAppDev.Data;
using PassAppDev.Models;
using PassAppDev.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PassAppDev.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;
        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string category)
        {
            if (!string.IsNullOrWhiteSpace(category))
            {
                var result = _context.Books
                  .Include(t => t.Category)
                  .Where(t => t.Category.Name.Equals(category))
                  .ToList();

                return View(result);
            }
            IEnumerable<Book> books = _context.Books
                .Include(t => t.Category)
                .ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new BookCategoriesVM()
            {
                Categories = _context.Categories.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(BookCategoriesVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel = new BookCategoriesVM
                {
                    Categories = _context.Categories.ToList()
                };
                return View(viewModel);
            }
            var newBook = new Book
            {
                Title = viewModel.Book.Title,
                Author = viewModel.Book.Author,
                Price = viewModel.Book.Price,
                Description = viewModel.Book.Description,
                Quantity = viewModel.Book.Quantity,
                CategoryId = viewModel.Book.CategoryId
            };

            _context.Add(newBook);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(t => t.Id == id);
            if (bookInDb is null)
            {
                return NotFound();
            }

            _context.Books.Remove(bookInDb);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(t => t.Id == id);
            if (bookInDb is null)
            {
                return NotFound();
            }

            var viewModel = new BookCategoriesVM
            {
                Book = bookInDb,
                Categories = _context.Categories.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(BookCategoriesVM viewModel)
        {
            var bookInDb = _context.Books.SingleOrDefault(t => t.Id == viewModel.Book.Id);
            if (bookInDb is null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                viewModel = new BookCategoriesVM
                {
                    Book = viewModel.Book,
                    Categories = _context.Categories.ToList()
                };
                return View(viewModel);
            }

            bookInDb.Title = viewModel.Book.Title;
            bookInDb.Author = viewModel.Book.Author;
            bookInDb.Price = viewModel.Book.Price;
            bookInDb.Description = viewModel.Book.Description;
            bookInDb.Quantity = viewModel.Book.Quantity;
            bookInDb.CategoryId = viewModel.Book.CategoryId;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
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
