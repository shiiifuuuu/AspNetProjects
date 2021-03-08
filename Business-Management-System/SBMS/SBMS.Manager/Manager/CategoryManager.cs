using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model.Model;
using SBMS.Repository.Repository;

namespace SBMS.Manager.Manager
{
	public class CategoryManager
	{
		CategoryRepo _categoryRepo = new CategoryRepo();

		public bool Add(Category category)
		{
			return _categoryRepo.Add(category);
		}

		public List<Category> GetAll()
		{
			return _categoryRepo.GetAll();
		}
	}
}
