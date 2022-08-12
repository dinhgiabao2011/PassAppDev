using Microsoft.AspNetCore.Http;

using PassAppDev.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PassAppDev.ViewModels
{
    public class BookCategoriesViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
