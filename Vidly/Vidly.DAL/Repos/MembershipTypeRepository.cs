using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.DatabaseContext.DatabaseContext;
using Vidly.MODEL.Models;

namespace Vidly.DAL.Repos
{
	public class MembershipTypeRepository
	{
		ProjectDbContext _dbContext = new ProjectDbContext();

		public IEnumerable<MembershipType> GetAll()
		{
			return _dbContext.MembershipTypes.ToList();
		}
	}
}
