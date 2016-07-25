using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iplus.Domain.Entities
{
	public class Product
	{
		public int ProductId { get; set; }

		public string Name { get; set; }

		public string VendorCode { get; set; }

		public string ShortDescription { get; set; }
		
		public string Description { get; set; }

		public int CategoryId { get; set; }

		public Category Category { get; set; }

		public decimal Price { get; set; }

		public byte[] ImageData { get; set; }

		public string ImageMimeType { get; set; }

		public ICollection<Photo> Photos { get; set; }

	}
}
