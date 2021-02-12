﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.MODEL.Models
{
	public class Genre
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
