namespace _12.TriFunction
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Console.ReadLine()
                .Split()
                .FirstOrDefault(x => x.ToCharArray().Select(y => (int)y).Sum() >= n));
        }
    }
}
