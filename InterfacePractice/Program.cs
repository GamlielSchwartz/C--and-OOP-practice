using System;
using System.Collections.Generic;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student joe = new Student("Joe", new Date("10", "13", "1991"), 1234);
            Student james = new Student("James", new Date("23", "05", "1989"), 1235);
            Classroom classroom = new Classroom();
            classroom.AddMember(joe);
            classroom.AddMember(james);

            //joe.AddGrades(78, 98, 90, 85);
            //james.AddGrades(56, 58, 59, 63);


            //Console.WriteLine(classroom.ToString());
            //classroom.RemoveMember(joe);
            //classroom.ListMembers();
            IGroupable<Person> troop = new BoyScoutTroop(34);

            List<IGroupable<Person>> listOfGroups = new List<IGroupable<Person>>();
            listOfGroups.Add(classroom);

            listOfGroups.Add(troop);
            troop.AddMember(joe);
            troop.AddMember(james);

            foreach (IGroupable<Person> g in listOfGroups)
            {
                g.ListMembers();
            }

        }
    }
}
