using System;

/*
 * Rules: Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
 * provide two methods: Start and Stop. We call the start method first, and the stop method next.
 * The we ask the stopwatch about the duration between start and stop. Duration should be a
 * value in TimeSpan. Display the duration on the console.
 * We should also be able to use a stopwatch multiple times. So we may start and stop it and then
 * start and stop it again. Make sure the duration value each time is calculated properly.
 * We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
 * start time). So the class should throw an InvalidOperationException if it is started twice without
 * a stop between.
/*
 * The issues:
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

                //I like better than if/then statments (easier to read)
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
