using System;

/*
 * The issues
 * 1) Duration calculation: Fixed (I was instantiating a new stopwatch each time through the while loop
 * 2) Duration display: Fixed (Google is your friend "C# TimeSpan format strings"
 * 3) Exception throwing: Fixed when stopwatch instantiation was move above while loop and added Try Catch.
 */

namespace Lecture15_Exercise1
{
    class Program
    {
        static void Main()
        {
            var input = "";
            var stopWatch = new StopWatch();

            while (input != "quit")
            {
                Console.Write("Enter Start/Stop to control Stopwatch 'Quit': ");
                input = Console.ReadLine() ?? "";

                Console.Clear();

                switch (input.ToLower())
                {
                    case "start":
                        stopWatch.Start();
                        break;
                    case "stop":
                        Console.WriteLine($"Duration: {stopWatch.Stop()}\n");
                        break;
                    case "quit":
                        break;
                }
            }
        }
    }
}
