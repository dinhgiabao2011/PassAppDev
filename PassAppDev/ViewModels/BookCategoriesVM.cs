using PassAppDev.Models;
using System.Collections.Generic;

namespace PassAppDev.ViewModels
{
    public class BookCategoriesVM
    {
        public Book Book { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
