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
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PassAppDev.Controllers
{
  [Authorize(Roles = Role.STOREOWNER)]
  public class BooksController : Controller
    {
        private ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    public BooksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
      _userManager = userManager;
    }

        [HttpGet]
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

    [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new BookCategoriesVM()
            {
                Categories = _context.Categories
                .Where(t=>t.Status==Enums.CategoryStatus.Approved)             
                .ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(BookCategoriesVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel = new BookCategoriesVM
                {
                    Categories = _context.Categories
                    .Where(t => t.Status == Enums.CategoryStatus.Approved)
                    .ToList()
                };
                return View(viewModel);
            }

         using (var memoryStream = new MemoryStream())  
           {
              await viewModel.FormFile.CopyToAsync(memoryStream);

              var newBook = new Book
              {
                Title = viewModel.Book.Title,
                Author = viewModel.Book.Author,
                Price = viewModel.Book.Price,
                Description = viewModel.Book.Description,
                CategoryId = viewModel.Book.CategoryId,
                ImageData = memoryStream.ToArray()
              };

          _context.Add(newBook);
          await _context.SaveChangesAsync();
           }

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
                Categories = _context.Categories
                  .Where(t => t.Status == Enums.CategoryStatus.Approved).ToList()



              };

              string imageBase64 = Convert.ToBase64String(bookInDb.ImageData);

              string image = string.Format("data:image/jpg;base64, {0}", imageBase64);

              ViewBag.ImageData = image;

            return View(viewModel);

          }

        [HttpPost]
        public async Task<IActionResult> Edit(BookCategoriesVM viewModel)
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
                Categories = _context.Categories
                  .Where(t => t.Status == Enums.CategoryStatus.Approved).ToList()
              };
              return View(viewModel);
            }
            bookInDb.Title = viewModel.Book.Title;
            bookInDb.Author = viewModel.Book.Author;
            bookInDb.Price = viewModel.Book.Price;
            bookInDb.Description = viewModel.Book.Description;
            bookInDb.CategoryId = viewModel.Book.CategoryId;


      using (var memoryStream = new MemoryStream())
      
              {
                await viewModel.FormFile.CopyToAsync(memoryStream);

              
                bookInDb.ImageData = memoryStream.ToArray();

                
             }
  
              await _context.SaveChangesAsync();
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


            string imageBase64 = Convert.ToBase64String(bookInDb.ImageData);

            string image = string.Format("data:image/jpg;base64, {0}", imageBase64);

            ViewBag.ImageData = image;
      return View(bookInDb);
        }
    }
}
