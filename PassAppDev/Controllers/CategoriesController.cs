using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using PassAppDev.Data;
using PassAppDev.Models;
using PassAppDev.Utils;

using System.Collections.Generic;
using System.Linq;

namespace PassAppDev.Controllers
{

  [Authorize(Roles = Role.STOREOWNER)]
  public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
        public CategoriesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
           
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories
                                                .Include(t=>t.ApplicationUser)
                                                .ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

    public IActionResult Create(Category category)
        {
      var currentUserId = _userManager.GetUserId(HttpContext.User);
      if (!ModelState.IsValid)
            {
                return View();
            }
            
            var newCategory = new Category
            {
                Name = category.Name,
                ApplicationUserId = currentUserId
            };

            _context.Add(newCategory);
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

            categoryInDb.OldName = categoryInDb.Name;
            categoryInDb.Name = category.Name;
            categoryInDb.Status = Enums.CategoryStatus.Pending;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
  }
}
