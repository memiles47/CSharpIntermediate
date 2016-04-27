using System;

namespace Lecture15_Exercise1
{
    public class StopWatch
    {

        public bool TimerRunning { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }
        public InvalidOperationException TimerIsRunningException { get; } = new InvalidOperationException("Timer is currently running");


        public void Start()
        {
            if(TimerRunning)
            {
                throw TimerIsRunningException;
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

            return StopTime - StartTime;
        }
    }
}