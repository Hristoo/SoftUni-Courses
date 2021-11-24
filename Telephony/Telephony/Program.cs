using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Nokia");
            StationaryPhone stationaryphone = new StationaryPhone("Nokia");
            string[] phones = Console.ReadLine().Split();
            foreach (var phone in phones)
            {
                if (phone.Length == 7)
                {
                    Console.WriteLine(stationaryphone.Call(phone));
                }
                else 
                {
                    Console.WriteLine(smartphone.Call(phone));
                }
                
            }
            string[] websites = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var website in websites)
            {
                Console.WriteLine(smartphone.Browse(website));
            }
        }
    }
}
