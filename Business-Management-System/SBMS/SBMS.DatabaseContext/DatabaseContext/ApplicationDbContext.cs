using Microsoft.AspNet.Identity.EntityFramework;
using SBMS.Model.IdentityModel;

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
	}
}
