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
            if(TimerRunning)
            {
                InvalidOperationException timerIsRunning = new InvalidOperationException("Timer currently running");
                throw timerIsRunning;
            }
            //Start Stopwatch code
            Console.WriteLine("Stopwatch running");
            StartTime = DateTime.Now;
            TimerRunning = true;
        }

        public TimeSpan Stop()
        {
            //Stop Stopwatch code
            Console.WriteLine("Stopwatch has stopped");
            TimerRunning = false;
            StopTime = DateTime.Now;

            return this.StopTime - this.StartTime;
        }
    }
}