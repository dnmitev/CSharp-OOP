// 8. Read in MSDN about the keyword event in C# and how to publish events. Re-implement 
// the above using .NET events and following the best practices.

namespace EventTask
{
    using System;
    using System.Linq;

    public class Test
    {
        public static void Timer_TimeChanged(object sender, TimeEventsArgs e)
        {
            Console.WriteLine("Change No:" + e.TickCount);
        }

        public static void Main()
        {
            Timer newTimer = new Timer(1, 10);
            newTimer.TimeChanged += Timer_TimeChanged;
            newTimer.Start();
        }
    }
}