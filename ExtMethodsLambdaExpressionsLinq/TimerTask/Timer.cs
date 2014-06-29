namespace TimerTask
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void MethodsToExecute();
        public MethodsToExecute TimerMethods;

        private readonly int interval;
        private readonly int totalTime;

        // constructors
        public Timer(int interval, int totalTime)
        {
            this.interval = interval;
            this.totalTime = totalTime;
        }

        public Timer() : this(0, 25) { }

        // define the timer start
        public void Start()
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(totalTime);

            while (start != end)
            {
                TimerMethods();
                Thread.Sleep(interval*500);
            }
        }
    }
}
