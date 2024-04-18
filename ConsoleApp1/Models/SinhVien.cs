using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	[Table("SinhVien")]
	internal class SinhVien
	{
		[Key]
		public int MaSinhVien { get; set; }
		[MaxLength(100)]
		public string? HoTen { get; set; }
		public DateTime NgaySinh { get; set; }

		[MaxLength(10)]
		public string? MaLop { get; set; }
		public Lop? Lop { get; set; }
	}
}
