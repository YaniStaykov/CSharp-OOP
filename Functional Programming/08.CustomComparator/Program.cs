namespace _08.CustomComparator
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;

            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .GroupBy(n => isEven(n))
                .OrderByDescending(g => g.Key)
                .ToDictionary(g => g.Key, g => g.OrderBy(n => n).ToList());

            foreach (var groupNumbers in numbers)
            {
                Console.Write(string.Join(" ", groupNumbers.Value) + " ");
            }
        }
    }
}
