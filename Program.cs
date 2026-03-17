using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject();
            Console.WriteLine("Subject name: ");
            sub.SubjectName = Console.ReadLine();

            Console.WriteLine("Subject ID: ");
            sub.SubjectName = Console.ReadLine();

            int menu = 0;

            while (menu != 4)
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Show student");
                Console.WriteLine("3. Exit");
                Console.WriteLine(" choose: ");

                Console.Write("Choose: ");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    Student s = new Student();

                    Console.Write("Name: ");
                    s.name = Console.ReadLine();

                    Console.Write("ID: ");
                    s.id = Console.ReadLine();

                    Console.Write("Score: ");
                    s.score = Convert.ToInt32(Console.ReadLine());

                    s.CalGrade();

                    sub.AddStudent(s);
                }
                else if (menu == 2)
                {
                    sub.ShowAll();
                }
                else if (menu == 3)
                {
                    break;
                }
            }
        }
    }
}