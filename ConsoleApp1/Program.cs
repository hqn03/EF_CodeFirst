using ConsoleApp1.Migrations;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
	internal class Program
	{
		static DaiHocDBContext db = new DaiHocDBContext();
		static int getAge(DateTime birthday)
		{
			int age = DateTime.Now.Year - birthday.Year;
			if (birthday.Date < DateTime.Now.Date)
				age--;
			return age;
		}
		static void initDB()
		{
			//insert
			var khoa1 = new Khoa { MaKhoa = "CNS", TenKhoa = "Công nghệ số" };
			var khoa2 = new Khoa { MaKhoa = "DDT", TenKhoa = "Điện - Điện tử" };
			var khoa3 = new Khoa { MaKhoa = "CK", TenKhoa = "Cơ khí" };
			db.Khoas.Add(khoa1);
			db.Khoas.Add(khoa2);
			db.Khoas.Add(khoa3);


			var lop23t1 = new Lop { MaLop = "23T1", Nganh = "Công nghệ thông tin", MaKhoa = "CNS", Khoa = khoa1 };
			var lop23t2 = new Lop { MaLop = "23T2", Nganh = "Công nghệ thông tin", MaKhoa = "CNS", Khoa = khoa2 };
			var lop23d1 = new Lop { MaLop = "23D1", Nganh = "Tự động hóa", MaKhoa = "DDT" };
			var lop23d2 = new Lop { MaLop = "23D3", Nganh = "Tự động hóa", MaKhoa = "DDT" };
			db.Lops.Add(lop23t2);
			db.Lops.Add(lop23t2);
			db.Lops.Add(lop23d1);
			db.Lops.Add(lop23d2);

			db.SinhViens.Add(new SinhVien { HoTen = "Nguyen Van A", NgaySinh = DateTime.Parse("3-20-2005"), MaLop = "23T1", Lop = lop23t1 });
			db.SinhViens.Add(new SinhVien { HoTen = "Nguyen Quang B", NgaySinh = DateTime.Parse("3-20-2004"), MaLop = "23T2", Lop = lop23t2 });
			db.SinhViens.Add(new SinhVien { HoTen = "Nguyen Van C", NgaySinh = DateTime.Parse("3-20-2003"), MaLop = "23T1", Lop = lop23t1 });
			db.SinhViens.Add(new SinhVien { HoTen = "Nguyen Van D", NgaySinh = DateTime.Parse("3-20-2004"), MaLop = "23T2", Lop = lop23t2 });
			db.SinhViens.Add(new SinhVien { HoTen = "Nguyen Van E", NgaySinh = DateTime.Parse("3-20-2005"), MaLop = "23D1", Lop = lop23d1 });
			db.SinhViens.Add(new SinhVien { HoTen = "Nguyen Van F", NgaySinh = DateTime.Parse("3-20-2005"), MaLop = "23D1", Lop = lop23d1 });

			db.SaveChanges();
		}
		static void Main(string[] args)
		{
			initDB();

			var locSinhVien = from sv in db.SinhViens
							  join l in db.Lops on sv.MaLop equals l.MaLop
							  join k in db.Khoas on l.MaKhoa equals k.MaKhoa
							  where k.TenKhoa == "Công nghệ số" && DateTime.Now.Year-sv.NgaySinh.Year >=18 && DateTime.Now.Year - sv.NgaySinh.Year <= 20
							  select new {sv.HoTen,sv.NgaySinh,sv.MaLop};

			
			foreach(var x in locSinhVien)
			{
				Console.WriteLine(x.HoTen + "\t" + x.NgaySinh + "\t" + x.MaLop);
			}


		}
	}
}
