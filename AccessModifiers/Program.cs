using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.SetBirthdate(new DateTime(1962, 8, 10));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
