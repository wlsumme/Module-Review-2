using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleReview222
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode    { get; set; }

        public List<Student> _EnrolledStudents { get; set; }

        public Course()
        {
            _EnrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if(!_EnrolledStudents.Any(s => s.ID == student.ID))
            {
                _EnrolledStudents.Add(student);
                Console.WriteLine($"{student.Name}, ID# {student.ID} was enrolled");
            }
            else
            {
                Console.WriteLine($"{student.Name}, ID# {student.ID} was already enrolled");
            }
        }
           
        
    }
}
