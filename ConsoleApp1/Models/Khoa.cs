using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	[Table("Khoa")]
	internal class Khoa
	{
		[Key]
		[MaxLength(10)]
		public string MaKhoa { get; set; }

		[MaxLength(100)]
		public string TenKhoa { get; set; }

		public ICollection<Lop> Lops { get; set; }
	}
}
