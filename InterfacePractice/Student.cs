using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace InterfacePractice
{
    public class Student
    {
        //fields:
        private string _name;
        private List<double> grades;
        //end of fields^

        //constructors:

        //new Student must have name, ident and Birthdate
        public Student(string name, Date birthday, int ident){
            _name = name;
            Birthday = birthday;
            Ident = ident;

            grades = new List<double>();
        }
        //end of constructors^

        //properties:
        protected string Name 
        { 
            get
            {
                return _name;
            } 
            set{
                //name can only be letters
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    _name = value;
                }
            }
        }

        public Date Birthday {get; set;}
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

        public override string ToString()
        {
            return "Student name: " + Name + ", id#: " + Ident + ", Birthday: " + Birthday + ", Current Grade: " + GetCurrLetterGrade() + ".";
        }

        //end of methods^
    }
}
