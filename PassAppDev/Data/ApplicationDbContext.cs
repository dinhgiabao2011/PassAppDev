using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PassAppDev.Models;
using PassAppDev.Utils;

using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace PassAppDev.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
		{
		}
    public DbSet<Category> Categories { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<CartBook> CartBooks { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderedBook> OrderedBooks { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      this.SeedRoles(builder);
      this.SeedUsers(builder);
			this.SeedUserRoles(builder);
		}

    private void SeedRoles(ModelBuilder builder)
    {
      builder.Entity<IdentityRole>().HasData(
          new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = Role.ADMIN, ConcurrencyStamp = "1", NormalizedName = Role.ADMIN },
          new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = Role.STOREOWNER, ConcurrencyStamp = "2", NormalizedName = Role.STOREOWNER },
					new IdentityRole() { Id = "e644b1a2-248f-4479-a7df-596aaebb9766", Name = Role.CUSTOMER, ConcurrencyStamp = "3", NormalizedName = Role.CUSTOMER }
					);

    }

    private void SeedUsers(ModelBuilder builder)
    {
			PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
			ApplicationUser user = new ApplicationUser()
			{
				Id = "b74ddd14-6340-4840-95c2-db12554843e5",
				UserName = "admin@gmail.com",
				Email = "admin@gmail.com",
				LockoutEnabled = false,
				PhoneNumber = "1234567890",
				PasswordHash = passwordHasher.HashPassword(null, "Admin@123")
			},
      storeOwner = new ApplicationUser()
			{
				Id = "a0554bfd-1d4d-4a61-97d4-d827530e6883",
				UserName = "store@gmail.com",
				Email = "store@gmail.com",
				LockoutEnabled = false,
				PhoneNumber = "1234567890",
				PasswordHash = passwordHasher.HashPassword(null, "Store@123")
			};
			builder.Entity<ApplicationUser>().HasData(user);
			builder.Entity<ApplicationUser>().HasData(storeOwner);

		}

    private void SeedUserRoles(ModelBuilder builder)
    {
      builder.Entity<IdentityUserRole<string>>().HasData(
          new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" }
          );
			builder.Entity<IdentityUserRole<string>>().HasData(
					new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "a0554bfd-1d4d-4a61-97d4-d827530e6883" }
					);
		}
  }
}
