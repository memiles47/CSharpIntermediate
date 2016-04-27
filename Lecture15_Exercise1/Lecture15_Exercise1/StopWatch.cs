using System;

namespace Lecture15_Exercise1
{
    public class StopWatch
    {
        public bool TimerRunning { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }

        public void Start()
        {
            try
            {
                if (!TimerRunning)
                {
                    //Start Stopwatch code
                    StartTime = DateTime.Now;
                    TimerRunning = true;
                }
                else
                    throw new InvalidOperationException("Timer is currently running");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
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