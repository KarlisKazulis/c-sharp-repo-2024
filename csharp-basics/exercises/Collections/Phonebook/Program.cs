using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneDictionary = new PhoneDirectory();

            phoneDictionary.PutNumber("Juris", "90901001");
            phoneDictionary.PutNumber("Ātrie", "112");

            Console.WriteLine($"Juris number: {phoneDictionary.GetNumber("Juris")}");
            Console.WriteLine($"If you want to call Ātrie, use: {phoneDictionary.GetNumber("Ātrie")}");
        }
    }
}
