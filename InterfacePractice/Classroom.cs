using System;
using System.Collections.Generic;
namespace InterfacePractice
{
    public class Classroom : IGroupable<Person>
    {
        //fields:
        List<Person> _classroom;
        //end of fields^

        //constructors:
        public Classroom() : this(new List<Person>()){}

        public Classroom(List<Person> classroom)
        {
            this._classroom = classroom;
        }
        //end of constructors^

        //methods:
        public double GetClassAverage()
        {
            double sum = 0;
            foreach (Student s in _classroom)
            {
                sum += s.GetCurrNumGrade();
            }
            return _classroom.Count == 0 ? 0 : sum / _classroom.Count;
        }

        public void AddMember(Person student)
        {
            _classroom.Add(student);
        }

        public override string ToString()
        {
            string returnString = "Classroom information:\n";
            foreach(Student s in _classroom){
                returnString += s.ToString() + "\n";
            }
            return returnString;
        }

        public void RemoveMember(Person person)
        {
            foreach (Person p in _classroom)
            {
                if (p.Name == person.Name) //should probably do a more serious check, may be duplicate names
                {
                    _classroom.Remove(p);
                    break;
                }
            }
        }

        public void ListMembers()
        {
            string printString = "Classroom members: ";
            for (int i = 0; i < _classroom.Count; i++)
            {
                printString += (_classroom[i] + (i == _classroom.Count - 1 ? "" : ", ")); //no comma on last
            }
            Console.WriteLine(printString + (_classroom.Count == 0 ? "" : "."));
        }

        //end of methods^
    }
}
