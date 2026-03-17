using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Subject
    {
        public string SubjectName;
        public string SubjectID;

        public List<Student> students = new List<Student>();

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void ShowAll()
        {
            foreach (Student s in students)
            {
                s.ShowStudent();
            }
        }
    }
}