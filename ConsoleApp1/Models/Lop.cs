using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	[Table("Lop")]
	internal class Lop
	{
		[Key]
		[MaxLength(10)]
		public string? MaLop { get; set; }

		[MaxLength(100)]
		public string? Nganh { get; set; }

		[MaxLength(10)]
		public string? MaKhoa { get; set; }
		public Khoa? Khoa { get; set; }

		public ICollection<SinhVien> SinhViens { get; set; }
	}
}
