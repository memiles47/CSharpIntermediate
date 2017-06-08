using System;

namespace Properties
{
    public class Person
    {
        //Declare auto implemented properties at the top
        public string Name { get; private set; }
        public DateTime Birthdate { get; private set; }

        //Horizontal seperator and then the constructor(s)
        public Person(DateTime birthdate, string name)
        {
            Birthdate = birthdate;
            Name = name;
        }

        //Horizontal seperator and then calculated properties
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = Convert.ToInt32(Math.Floor(timeSpan.TotalDays / 365));
                return years;
            }
        }

    }
}