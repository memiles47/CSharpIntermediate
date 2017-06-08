using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            UseTryParseOut();
            UseParams();
            UsePoints();
        }

        //Demonstrates the use of keyword out in method parameters
        static void UseTryParseOut()
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion Failed");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Failed");
        }

        //Demonstrates the use of params for multiple parameters via list<t>
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        //Demonstrates the use of multiple overloads for a Method
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at {point.X}, {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
