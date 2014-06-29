namespace EventTask
{
    using System;

    public class TimeEventsArgs : EventArgs
    {
        public TimeEventsArgs(int tickCount)
        {
            this.TickCount = tickCount;
        }

        public int TickCount { get; private set; }
    }
}