using System;


namespace Persons
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        } 
        
        public virtual void Display()
        {
            Console.WriteLine($"Firstname: {_firstName}");
            Console.WriteLine($"Lastname: {_lastName}");
            Console.WriteLine($"Address: {_address}");
            Console.WriteLine($"ID: {_id}");
        }
    }
}
