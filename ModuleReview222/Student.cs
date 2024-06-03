using System;
using System.Collections.Generic;
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
        public Student(string name, int id) 

        {
            Name = name;
            ID = id;
            
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
    }
}
