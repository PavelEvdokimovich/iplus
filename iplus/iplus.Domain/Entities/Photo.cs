using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iplus.Domain.Entities
{
	public class Photo
	{
		public int PhotoId { get; set; }

		public int ProductId { get; set; }

		public Product Product { get; set; }

		public byte[] ImageData { get; set; }

		public string ImageMimeType { get; set; }
	}
}
