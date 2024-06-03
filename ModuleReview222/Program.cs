using ModuleReview222;
using System.ComponentModel;



var Students = new List<Student>();


Student studentOne = new Student("William Summe", 85, 96.2);
Student studentTwo = new Student("Lauren Summe", 18, 97.5);
Student studentThree = new Student("Peaches Peach", 34, 45.2);
Student studentFour = new Student("Mario Mario", 123, 56.2);

Students.Add(studentOne);
Students.Add(studentTwo);
Students.Add(studentThree);
Students.Add(studentFour);


studentOne.AddGrade(94.3);
studentOne.AddGrade(56.6, 65.6);

studentTwo.AddGrade(56.2, 56.3);
studentTwo.AddGrade(45.2);

studentThree.AddGrade(56.9, 45.1);
studentThree.AddGrade(44.3);

studentFour.AddGrade(56.7, 41.1);
studentFour.AddGrade(24.3);



foreach (var student in Students)
{
    Console.WriteLine($"Name: {student.Name}\nID: {student.ID}");

    foreach(var grade in student.Grades)
    {
        Console.WriteLine($"Grades: {grade}");
    }
    
    var gradeAverage = student.CalculateAverageGrade();
    Console.WriteLine($"Grade Average: {gradeAverage}");

    
}


var courseOne = new Course();
courseOne.CourseName = "History";
courseOne.CourseCode = "CS101";

courseOne.EnrollStudent(studentOne);
courseOne.EnrollStudent(studentTwo);


Console.WriteLine($"Course Name: {courseOne.CourseName}");
Console.WriteLine($"Course Code: {courseOne.CourseCode}");
foreach(var student in courseOne._EnrolledStudents)
{
    Console.WriteLine($"Name: {student.Name} ID: {student.ID}");
}







