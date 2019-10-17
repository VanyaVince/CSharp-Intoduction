using System;

namespace Exercise1StopWatch
{
    class StopWatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        private bool _flag;

        public void Start()
        {
            if (_flag)
                throw new InvalidOperationException("The method start has been called twice in a row. It's only allowed to invoke this method in a pair with the method stop");

            this.StartTime = DateTime.Now;
            _flag = true;
        }

        public void End()
        {
            if (_flag)
            {
                this.EndTime = DateTime.Now;
                _flag = false;
            }
        }

        public TimeSpan GetDuration()
        {
            return EndTime.Subtract(StartTime);
        }
    }
}