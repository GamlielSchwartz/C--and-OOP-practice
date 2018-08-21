using System;
using System.Collections.Generic;
namespace InterfacePractice
{
    public class Classroom
    {
        //fields:
        List<Student> classroom;
        //end of fields^

        //constructors:
        public Classroom() : this(new List<Student>()){}

        public Classroom(List<Student> classroom)
        {
            this.classroom = classroom;
        }
        //end of constructors^

        //methods:
        public double GetClassAverage()
        {
            double sum = 0;
            foreach (Student s in classroom)
            {
                sum += s.GetCurrNumGrade();
            }
            return classroom.Count == 0 ? 0 : sum / classroom.Count;
        }

        public void AddStudent(Student student)
        {
            classroom.Add(student);
        }

        public override string ToString()
        {
            string returnString = "Classroom information:\n";
            foreach(Student s in classroom){
                returnString += s.ToString() + "\n";
            }
            return returnString;
        }
        //end of methods^
    }
}
