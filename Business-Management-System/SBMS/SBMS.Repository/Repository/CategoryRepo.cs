using System;
using System.Collections.Generic;
using System.Linq;
using SBMS.DatabaseContext.DatabaseContext;
using SBMS.Model.Model;

namespace SBMS.Repository.Repository
{
	public class CategoryRepo
	{
		ApplicationDbContext _dbContext = new ApplicationDbContext();

		public bool Add(Category category)
		{
			try
			{
				_dbContext.Categories.Add(category);
				return _dbContext.SaveChanges() > 0;
			}
			catch(Exception e)
			{
				string m = e.Message;
				return false;
			}
		}

		public List<Category> GetAll()
		{
			return _dbContext.Categories.ToList();
		}
	}
}
