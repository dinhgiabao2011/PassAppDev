using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassAppDev.Models
{
	public class CartBook
	{
		public string ApplicationUserId { get; set; }
		public ApplicationUser ApplicationUser { get; set; }

		public int BookId { get; set; }
		public Book Book { get; set; }

		public int Quatity { get; set; }
	}
}
