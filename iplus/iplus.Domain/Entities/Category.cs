﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iplus.Domain.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }

		public string Name { get; set; }

		public int ParentCategoryId { get; set; }

		public ICollection<Product> Products { get; set; }
	}
}
