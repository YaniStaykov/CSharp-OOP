namespace _03.Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();

            string[] sites = Console.ReadLine().Split();

            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (phoneNumbers[i].Length == 7)
                {
                    if (!phoneNumbers[i].All(x => char.IsDigit(x)))
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    else
                    {
                        Console.WriteLine(stationaryPhone.Call(phoneNumbers[i]));
                    }

                }
                else if (phoneNumbers[i].Length == 10)
                {
                    if (!phoneNumbers[i].All(x => char.IsDigit(x)))
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    else
                    {
                        Console.WriteLine(smartphone.Call(phoneNumbers[i]));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            for (int i = 0; i < sites.Length; i++)
            {
                if (sites[i].Any(x => char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine(smartphone.Browse(sites[i]));
                }
            }

        }
    }
}
