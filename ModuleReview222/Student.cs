using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleReview222
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<double> Grades { get; set; } = new List<double>();
        public Student(string name, int id, params double[] grades)

        {
            Name = name;
            ID = id;
            Grades = new List<double>(grades);

        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            else
            {
                return Grades.Average();
            }


        }

    }
}
