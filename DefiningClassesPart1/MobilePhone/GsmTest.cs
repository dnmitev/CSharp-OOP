namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GsmTest
    {
        public static void Main()
        {
            GSM phone1 = new GSM("Galaxy S4 mini", "Samsung");
            GSM phone2 = new GSM("Ascend G700", "Huawei", 339.00m);
            GSM phone3 =
                new GSM(
                    "Galaxy Grand",
                    "Samsung",
                    639.00m,
                    "Bai Ivan",
                new Battery("BP-4L", 420.0, 8.5, BatteryType.LiPol),
                new Display(6.3, 16000000));

            GSM[] phones = new GSM[] { phone1, phone2, phone3 };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine(new string('-', 60));
            }

            Console.WriteLine(GSM.Iphone4S);
            Console.WriteLine(new string('-', 60));

            GSM anotherGsm = phone3;

            anotherGsm.AddCall(new Call(DateTime.Now, "+359885123321", 150));
            anotherGsm.AddCall(new Call(new DateTime(2014, 01, 31, 22, 13, 01), "+359898788756", 90));
            anotherGsm.AddCall(new Call(new DateTime(2014, 02, 21, 10, 31, 01), "+359898788756", 124));

            // printing info about the calls
            Console.WriteLine("Dialed number logs: ");

            foreach (var call in anotherGsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            // get the total cost of all calls
            decimal pricePerMinute = 0.37m;

            decimal totalCost = anotherGsm.CalculatePrice(pricePerMinute);

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Total cost of the calls: {0}", totalCost);

            // find the longest call
            int longest = int.MinValue;
            Call targetCall = null;

            foreach (var call in anotherGsm.CallHistory)
            {
                if (call.Duration > longest)
                {
                    longest = call.Duration;
                    targetCall = call;
                }
            }

            anotherGsm.DeleteCall(targetCall);

            totalCost = anotherGsm.CalculatePrice(pricePerMinute);

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Total cost of the calls after removing longest one: {0}", totalCost);

            // clear and print the call history
            List<Call> deleted = anotherGsm.ClearCallHistory();

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("After deleting:");

            foreach (var call in deleted)
            {
                Console.WriteLine(call);
            }
        }
    }
}
