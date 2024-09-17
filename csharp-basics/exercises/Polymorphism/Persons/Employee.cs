using System;


namespace Persons
{
    public class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobTitle)
            : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Job title: {_jobTitle}");
        }
    }
}
