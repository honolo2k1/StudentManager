using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuList
{
    class StudentManager : IStudentManager
    {
        private List<Student> students = new List<Student>();

        public void LoadStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach hoc sinh trong.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Danh sach:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.ID}, Ten: {student.Name}");
                    Console.WriteLine("");
                }
            }
        }

        public void AddStudent()
        {
            Console.Write("Nhap ID hoc sinh: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();

            students.Add(new Student(id, name));
            Console.WriteLine("Thanh cong.");
            Console.WriteLine("");
        }

        public void EditStudent()
        {
            Console.Write("Nhap ID hoc sinh can chinh sua: ");
            int id = int.Parse(Console.ReadLine());

            Student student = students.Find(s => s.ID == id);
            if (student != null)
            {
                Console.Write("Nhap ten moi cho hoc sinh: ");
                string newName = Console.ReadLine();

                student.Name = newName;
                Console.WriteLine("Thanh cong.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh co ID da nhap.");
                Console.WriteLine("");
            }
        }

        public void DeleteStudent()
        {
            Console.Write("Nhap ID hoc sinh can xoa: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = students.Find(s => s.ID == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Thanh cong.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh co ID da nhap.");
                Console.WriteLine("");
            }
        }
    }
}
