using System;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            var stopWatch = new StopWatch();
            var running = true;

            while (running)
            {
                Console.Write("Enter 'Start', 'Stop' or 'Quit': ");
                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "start":
                        try
                        {
                            stopWatch.Start();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Exception {e} thrown");
                        }
                        break;

                    case "stop":
                        Console.WriteLine(stopWatch.Stop() + "\n\n");
                        break;

                    case "quit":
                        running = false;
                        break;
                }
            }
        }
    }
}
