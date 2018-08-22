using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace InterfacePractice
{
    public class Student : Person
    {
        //fields:
        private string _name;
        private List<double> grades;
        //end of fields^

        //constructors:

        //new Student must have name, ident and Birthdate
        public Student(string name, Date birthday, int ident) : base(name, birthday){
            _name = name;
            Ident = ident;

            grades = new List<double>();
        }
        //end of constructors^

        //properties:
        public int Ident { get; }
        //end of properties^

        //methods:

        //prints out a list of current grades
        public void ListGrades()
        {
            foreach (double grade in grades){
                Console.WriteLine("Score: " + grade);
            }
        }

        public string GetCurrLetterGrade() 
        {
            double numGrade = GetCurrNumGrade();
            if (numGrade >= 90)
            {
                return "A";
            }
            else if (numGrade >= 80)
            {
                return "B";
            }
            else if (numGrade >= 70)
            {
                return "C";
            }
            else if (numGrade >= 60)
            {
                return "D";
            }
            else 
            {
                return "F";
            }
        }

        public double GetCurrNumGrade()
        {
            //assumes all grades are weighted evenly
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            //check to make sure there are some grades so won't divide by 0
            return grades.Count == 0 ? 0 : sum / grades.Count;
        }

        //adds single grade to Student object
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        //if you want to add multiple grades at one time
        public void AddGrades(params double[] grades)
        {
            foreach (double grade in grades)
            {
                AddGrade(grade);
            }
        }

        //overrides ToString method to include all relevant data about student
        public override string ToString()
        {
            return Name;
        }

        //end of methods^
    }
}
