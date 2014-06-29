namespace EventTask
{
    using System.Threading;

    public class Timer
    {
        public event TimeChangedEventHandler TimeChanged;

        private readonly int interval;
        private readonly int totalTime;

        // constructors
        public Timer(int interval, int totalTime)
        {
            this.interval = interval;
            this.totalTime = totalTime;
        }

        public Timer() : this(0, 25) { }

        protected void OnTimeChanged(int tick)
        {
            if (TimeChanged != null)
            {
                TimeChanged(this,new TimeEventsArgs(tick));
            }
        }

        // define the timer start
        public void Start()
        {
            int tick = this.totalTime;

            Thread newThread = new Thread(() =>
            {
                while (tick > 0)
                {
                    Thread.Sleep(this.interval * 1000);
                    tick--;
                    OnTimeChanged(tick);
                }
            });

            newThread.Start();
        }
    }
}
