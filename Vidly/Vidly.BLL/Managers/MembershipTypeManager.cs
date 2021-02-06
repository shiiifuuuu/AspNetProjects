using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.DAL.Repos;
using Vidly.MODEL.Models;

namespace Vidly.BLL.Managers
{
	public class MembershipTypeManager
	{
		MembershipTypeRepository _membershipTypeRepository = new MembershipTypeRepository();

		public IEnumerable<MembershipType> GetAll()
		{
			return _membershipTypeRepository.GetAll();
		}
	}
}
