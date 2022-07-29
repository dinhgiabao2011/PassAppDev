﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PassAppDev.Models;
using PassAppDev.Utils;

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
		public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      this.SeedRoles(builder);
    }

    private void SeedRoles(ModelBuilder builder)
    {
      builder.Entity<IdentityRole>().HasData(
          new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = Role.ADMIN, ConcurrencyStamp = "1", NormalizedName = Role.ADMIN },
          new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = Role.STOREOWNER, ConcurrencyStamp = "2", NormalizedName = Role.STOREOWNER }
          );
    }
  }
}
