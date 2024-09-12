using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Aigars", "Kalvitis", "Caka iela", 1337, 3.0);
            Employee employee = new Employee("Karlis", "Kalnins", "Valdemara iela", 420, "Bus driver");

            student.Display();
            Console.WriteLine();
            employee.Display();
        }
    }
}