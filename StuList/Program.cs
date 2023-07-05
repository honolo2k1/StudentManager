using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuList
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentManager studentManager = new StudentManager();
            int choice;

            do
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Tai danh sach hoc sinh");
                Console.WriteLine("2. Them hoc sinh");
                Console.WriteLine("3. Sua thong tin hoc sinh");
                Console.WriteLine("4. Xoa hoc sinh");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("");
                Console.Write("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        studentManager.LoadStudents();
                        break;
                    case 2:
                        studentManager.AddStudent();
                        break;
                    case 3:
                        studentManager.EditStudent();
                        break;
                    case 4:
                        studentManager.DeleteStudent();
                        break;
                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai");
                        break;
                }
            } while (choice != 0);
        }
    }
}
