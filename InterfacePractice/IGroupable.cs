using System;
namespace InterfacePractice
{
    public interface IGroupable <Person> 
    {
        void AddMember(Person person);
        void RemoveMember(Person person);
        void ListMembers();
    }
}
