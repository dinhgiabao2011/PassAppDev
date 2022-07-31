using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PassAppDev.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string FullName { get; set; }

		public string Address { get; set; }

		public List<Category> Categories { get; set; }
	}
}
