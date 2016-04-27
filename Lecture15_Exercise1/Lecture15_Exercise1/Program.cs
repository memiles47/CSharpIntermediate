using System;

/*
 * The issues
 * 1) Duration calculation
 * 2) Duration display
 * 3) Exception throwing
 */

namespace Lecture15_Exercise1
{
    class Program
    {
        static void Main()
        {
            var input = "";

            while (input != "quit")
            {
                var stopWatch = new StopWatch();

                Console.Write("Enter Start/Stop to control Stopwatch 'Quit' to exit: ");
                input = Console.ReadLine() ?? "";

                Console.Clear();

                switch (input.ToLower())
                {
                    case "start":
                        stopWatch.Start();
                        break;
                    case "stop":
                        Console.WriteLine($"Duration: {stopWatch.Stop():G}");
                        break;
                    case "quit":
                        break;
                }
            }
        }
    }
}
