using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PassAppDev.Data;
using PassAppDev.Models;
using System.Collections.Generic;
using System.Linq;

namespace PassAppDev.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
           
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var newCategory = new Category
            {
                Name = category.Name
            };

            _context.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categoryInDb = _context.Categories.SingleOrDefault(t => t.Id == id);
            if (categoryInDb is null)
            {
                return NotFound();
            }

            return View(categoryInDb);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var categoryInDb = _context.Categories.SingleOrDefault(t => t.Id == category.Id);
            if (categoryInDb is null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(categoryInDb);
            }

            categoryInDb.Name = category.Name;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
