using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHocSinh
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>
            {
                new Student{Id = 1, Name = "Võ Văn Tâm", Age = 17},
                new Student{Id = 2, Name = "Trần Trọng Nghĩa", Age = 21},
                new Student{Id = 3, Name = "Phạm Hồ Quốc Nghĩa", Age = 18},
                new Student{Id = 4, Name = "Nguyễn Duy Anh", Age = 22},
                new Student{Id = 5, Name = "Võ Văn Kiệt", Age = 25},

            };
            Console.WriteLine("Danh Sách Học Sinh:");
            foreach (var student in students)
            {
                Console.WriteLine("Id:{0} , Tên:{1} , Tuổi:{2}", student.Id, student.Name, student.Age);
            }
            Console.WriteLine();
            Console.WriteLine("Danh sách học sinh từ 15 đến 18 tuổi:");
            var studentAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in studentAge15To18)
            {
                Console.WriteLine("Id:{0} , Tên:{1} , Tuổi:{2}", student.Id, student.Name, student.Age);
            }
            Console.WriteLine();
            Console.WriteLine("Học sinh có tên bắt đầu bằng chữ A:");
            var studentsWithNameA = students.Where(s =>
            {
                string[] nameParts = s.Name.Split(' ');
                string firtsName = nameParts.Last();
                return firtsName.StartsWith("A");
            });
            foreach (var student in studentsWithNameA)
            {
                Console.WriteLine("Id:{0} , Tên:{1} , Tuổi:{2}", student.Id, student.Name, student.Age);
            }
            Console.WriteLine();
            var tongAge = students.Sum(s => s.Age);
            Console.WriteLine("Tổng tuổi là:" + tongAge);

            Console.WriteLine();
            int maxAge = students.Max(s => s.Age);
            var oldestStudent = students.FirstOrDefault(s => s.Age == maxAge);
            Console.WriteLine("Học sinh có tuổi lớn nhất là: Id:{0} , Tên:{1} , Tuổi:{2}", oldestStudent.Id, oldestStudent.Name, oldestStudent.Age);


            Console.WriteLine();
            Console.WriteLine("Danh sách học sinh tăng dần theo tuổi: ");
            var tangDanAge = students.OrderBy(s => s.Age);
            foreach (var student in tangDanAge)
            {
                Console.WriteLine("Id:{0} , Tên:{1} , Tuổi:{2}", student.Id, student.Name, student.Age);
            }
            Console.ReadLine();
        }
    }
}
