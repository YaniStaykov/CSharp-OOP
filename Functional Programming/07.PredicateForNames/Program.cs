namespace _07.PredicateForNames
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var nameLength = int.Parse(Console.ReadLine());
            Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Where(x => x.Length <= nameLength)
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
