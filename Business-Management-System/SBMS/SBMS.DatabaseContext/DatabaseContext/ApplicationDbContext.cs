using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using SBMS.Model.IdentityModel;
using SBMS.Model.Model;

namespace SBMS.DatabaseContext.DatabaseContext
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext()
			: base("ApplicationDbContext", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		public DbSet<Category> Categories { set; get; }
	}
}
