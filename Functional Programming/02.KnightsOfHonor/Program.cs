namespace _02.KnightsOfHonor
{
    using System;
    using System.Linq;

    class Program
    {
            static void Main(string[] args)
            {
                Action<string> appendSir = x => Console.WriteLine($"Sir {x}");

                Console.ReadLine()
                    .Split()
                    .ToList()
                    .ForEach(appendSir);
            }
    }
}
