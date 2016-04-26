using System;

namespace Lecture15_Exercise1
{
    public class StopWatch
    {

        public bool TimerRunning { get; private set; } = false;
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }

        public void Start()
        {
            //Start Stopwatch code
            Console.WriteLine("Stopwatch running");
            this.StartTime = DateTime.Now;
            this.TimerRunning = true;
        }

        public TimeSpan Stop()
        {
            //Stop Stopwatch code
            Console.WriteLine("Stopwatch has stopped");
            this.TimerRunning = false;
            this.StopTime = DateTime.Now;

            return this.StopTime - this.StartTime;
        }
    }
}