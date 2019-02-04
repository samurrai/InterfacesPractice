using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(5);
            student.Name = "Ruslan";
            student.FullName = "Ruslan Shadikyan";
            student.Grades[0] = 1;
            student.Grades[1] = 2;
            student.Grades[2] = 3;
            student.Grades[3] = 4;
            student.Grades[4] = 5;

            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetFullName());
            Console.WriteLine(student.GetAvgGrade());

            Console.ReadLine();
        }
    }
}
