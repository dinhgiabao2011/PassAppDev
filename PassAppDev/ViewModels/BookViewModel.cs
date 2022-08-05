using PassAppDev.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PassAppDev.ViewModels
{
	public class BookViewModel
	{

    public int Id { get; set; } 

    public string Title { get; set; }

    public string Author { get; set; }

    public float Price { get; set; }

    public Category Category { get; set; }

    public string ImageUrl { get; set; }
  }
}
