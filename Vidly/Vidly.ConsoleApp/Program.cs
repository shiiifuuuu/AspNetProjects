using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.BLL.Managers;
using Vidly.ConsoleApp.Models;
using Vidly.MODEL.Models;

namespace Vidly.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
//			MovieCrudOperation.MovieAdd();
//			MovieCrudOperation.MovieGetAll();

//			CustomerCrudOperation.CustomerAdd();

			CustomerCrudOperation.CustomerGetAll();
			Console.ReadKey();
		}
	}
}
