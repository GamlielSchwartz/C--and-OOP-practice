using System;
using System.Collections.Generic;

namespace InterfacePractice
{
    public class BoyScoutTroop : IGroupable<Person>
    {
        //fields:
        private List<Person> _group;
        int _troopNumber;
        //end of fields^

        //constructors:
        public BoyScoutTroop(int troopNum)
        {
            _group = new List<Person>();
            _troopNumber = troopNum;
        }
        //end of constructors^

        //methods:
        public void AddMember(Person person)
        {
            _group.Add(person);
        }

        public void ListMembers()
        {
            string printString = "Troop members: ";
            for (int i = 0; i < _group.Count; i++)
            {
                printString += (_group[i].Name + (i == _group.Count - 1 ? "" : ", ")); //no comma on last
            }
            Console.WriteLine(printString + (_group.Count == 0 ? "" :"."));
        }

        public void RemoveMember(Person person)
        {
            foreach (Person p in _group)
            {
                if (p.Name == person.Name) //should probably do a more serious check, may be duplicate names
                {
                    _group.Remove(p);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return "Troop number: " + _troopNumber + ".";
        }

        public int GetTroupNumber()
        {
            return _troopNumber;
        }
        //end of methods^
    }
}
