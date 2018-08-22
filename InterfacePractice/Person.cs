using System;
using System.Text.RegularExpressions;

namespace InterfacePractice
{
    public abstract class Person
    {

        //fields:
        string _name;
        //end of fields^

        //constructors:
        protected Person (string name, Date birthday)
        {
            _name = name;
            Birthday = birthday;
        }
        //end of constructors^

        //properties:
        public Date Birthday { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //name can only be letters
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    _name = value;
                }
            }
        }
        //end ofproperties^
    }
}
