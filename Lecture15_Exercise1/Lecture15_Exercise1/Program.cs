using System;

namespace Lecture15_Exercise1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var stopWatch = new StopWatch();

                Console.Write("Enter Start/Stop to control Stopwatch: ");
                var input = Console.ReadLine() ?? "";

                if (input.ToLower() == "start")
                    stopWatch.Start();
            }
        }
    }
}
