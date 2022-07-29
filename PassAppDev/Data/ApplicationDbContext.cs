using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PassAppDev.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PassAppDev.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
		{
		}
        public DbSet<Category> Categories { get; set; }
    }
}
