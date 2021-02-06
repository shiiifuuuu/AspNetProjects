using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.MODEL.Models;

namespace Vidly.DatabaseContext.DatabaseContext
{
	public class ProjectDbContext:DbContext
	{
		public DbSet<Movie> Movies { set; get; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<MembershipType> MembershipTypes { get; set; }
	}
}
