// 7.Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace TimerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Test
    {
        static void Main()
        {
            Timer testTimer = new Timer(1,10);

            // adding methods to the delegate
            testTimer.TimerMethods = delegate()
            {
                Console.WriteLine("Hello,world!");
            };


            testTimer.Start();
        }
    }
}
