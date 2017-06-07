using System;

namespace Classes
{
    class Person
    {
        public int Id;
        public string Name;

        public Person()
        {
        }

        public Person(int id)
            :this()
        {
            this.Id = id;
        }

        public Person(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Introduce(int id, string name)
        {
            Console.WriteLine($"Hi, {name}, I'm \"Mosh\"");
        }
    }
}