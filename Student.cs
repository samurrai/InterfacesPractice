using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractice
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }
        private int _size;

        public Student(int size)
        {
            _size = size;
            Grades = new int[_size];
        }

        public string GetName()
        {
            return Name;
        }
        public string GetFullName()
        {
            return FullName;
        }
        public double GetAvgGrade()
        {
            int sumOfAllGrades = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                sumOfAllGrades += Grades[i];
            }
            double avgGrade = sumOfAllGrades / Grades.Length;
            return avgGrade;
        }
    }
}
