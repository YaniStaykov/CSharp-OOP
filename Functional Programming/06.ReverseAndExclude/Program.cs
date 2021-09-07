namespace _06.ReverseAndExclude
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Reverse()
                 .ToList();
            var n = int.Parse(Console.ReadLine());
            bool Filter(int x) => x % n != 0;

            Console.WriteLine(string.Join(" ", numbers.Where(Filter)));
        }
    }
}
