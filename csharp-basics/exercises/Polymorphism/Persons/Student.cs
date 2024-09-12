using System;


namespace Persons
{
    public class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string address, int id, double gpa)
            : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"GPA: {_gpa}");
        }
    }
}
