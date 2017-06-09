using System;

namespace Properties
{
    class Program
    {
        static void Main()
        {
            var person = new Person(new DateTime(1962, 8, 10), "Michael");
            Console.WriteLine($"Hi, my name is {person.Name} and I am {person.Age} years old.");
        }
    }
}
