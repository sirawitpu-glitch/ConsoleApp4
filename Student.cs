using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Student : Person
    {
        public string id;
        public int score;
        public string grade;

        public void CalGrade()
        {
            if (score >= 80)
                grade = "A";
            else if (score >= 75)
                grade = "B+";
            else if (score >= 70)
                grade = "B";
            else if (score >= 65)
                grade = "C+";
            else if (score >= 60)
                grade = "C";
            else if (score >= 55)
                grade = "D+";
            else if (score >= 50)
                grade = "D";
            else
                grade = "F";
        }
        public void ShowStudent()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Grade: " + grade);
        }
    }
}