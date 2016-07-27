using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iplus.Domain.Entities
{
	public class Banner
	{
		public int BannerId { get; set; }

		public string Name { get; set; }

		public string Text { get; set; }

		public byte[] ImageData { get; set; }

		public string ImageMimeType { get; set; }
	}
}
