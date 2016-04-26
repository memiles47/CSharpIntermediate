using System;

namespace Lecture15_Exercise1
{
    public class StopWatch
    {

        public bool TimerRunning { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }

        public void StartTimer()
        {
            //Start Stopwatch code
            Console.WriteLine("Stopwatch running");

        }

        public TimeSpan StopTimer()
        {
            //Stop Stopwatch code
            Console.WriteLine("Stopwatch has stopped");

        }
    }
}