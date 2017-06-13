
using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _timerRunning;
        private TimeSpan _elapsedTime;

        public void Start()
        {
            if (!_timerRunning)
            {
                _startTime = DateTime.Now;
                _timerRunning = true;
            }
            else
            {
                //Throw exception when stopwatch is running and start is selected
                throw new InvalidOperationException();
            }
        }

        public string Stop()
        {
            if (_timerRunning)
            {
                _stopTime = DateTime.Now;
                _timerRunning = false;
                _elapsedTime = _stopTime - _startTime;
                return _elapsedTime.ToString();
            }
            else
            {
                return "Stopwatch is not currently running.\n\n";
            }
        }
    }
}