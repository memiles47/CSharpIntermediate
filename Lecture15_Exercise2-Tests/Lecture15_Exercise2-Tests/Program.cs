using System;

namespace Lecture15_Exercise2_Tests
{
    class Program
    {
        static void Main()
        {
            var start = DateTime.Now;
            var end = DateTime.Now;
            var duration = end - start;

            Console.WriteLine($"Duration: {duration}");
        }
    }
}
