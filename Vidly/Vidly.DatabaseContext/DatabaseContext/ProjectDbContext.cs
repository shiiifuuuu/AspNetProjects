using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Vidly.MODEL.IdentityModels;
using Vidly.MODEL.Models;

namespace Vidly.DatabaseContext.DatabaseContext
{
	public class ProjectDbContext : IdentityDbContext<ApplicationUser>
	{

		public ProjectDbContext() : base("ProjectDbContext", throwIfV1Schema: false)
		{
			Configuration.LazyLoadingEnabled = false;
		}

		public static ProjectDbContext Create()
		{
			return new ProjectDbContext();
		}

		public DbSet<Movie> Movies { set; get; }
		public DbSet<Genre> Genres { set; get; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<MembershipType> MembershipTypes { get; set; }
	}
}
