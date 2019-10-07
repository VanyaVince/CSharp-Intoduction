using System;

namespace Exercise1StopWatch
{
    class StopWatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        private bool _flag = false;

        public void Start(DateTime start)
        {
            if (!_flag)
            {
                this.StartTime = start;
                _flag = true;
            }
            else 
                throw new InvalidOperationException("The method start has been called twice in a row. It's only allowed to invoke this method in a pair with the method stop");
        }

        public void End(DateTime end)
        {
            if (_flag)
            {
                this.EndTime = end;
                _flag = false;
            }
        }

        public TimeSpan GetDuration()
        {
            return EndTime.Subtract(StartTime);
        }
    }
}