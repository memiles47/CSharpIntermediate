using System;

namespace Lecture15_Exercise1
{
    public class StopWatch
    {
        private bool _timerRunning;
        private DateTime _startTime;
        private DateTime _stopTime;

        public void Start()
        {
            try
            {
                if (!_timerRunning)
                {
                    //Start Stopwatch code
                    _startTime = DateTime.Now;
                    _timerRunning = true;
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
                _timerRunning = false;
                _stopTime = DateTime.Now;

                return _stopTime - _startTime;
        }
    }
}