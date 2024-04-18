using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	internal class DaiHocDBContext : DbContext
	{
		public DbSet<SinhVien> SinhViens { get; set; }
		public DbSet<Lop> Lops { get; set; }
		public DbSet<Khoa> Khoas { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
				.UseSqlServer("Data Source=.;Initial Catalog=dbCodeFirst;Integrated Security=True;Trust Server Certificate=True");
		}
	}
}
