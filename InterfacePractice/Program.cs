using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student joe = new Student("Joe", new Date("10", "13", "1991"), 1234);
            Student james = new Student("James", new Date("23", "05", "1989"), 1235);
            Classroom classroom = new Classroom();
            classroom.AddStudent(joe);
            classroom.AddStudent(james);

            joe.AddGrades(78, 98, 90, 85);
            james.AddGrades(56, 58, 59, 63);

            Console.WriteLine(joe.GetCurrNumGrade());
            Console.WriteLine(james.GetCurrNumGrade());

            Console.WriteLine(classroom.GetClassAverage());
            Console.WriteLine(joe);

            Console.WriteLine(classroom.ToString());
        }
    }
}
