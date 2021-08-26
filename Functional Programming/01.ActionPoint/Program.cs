namespace _01.ActionPoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var peoples = new Queue<string>(Console.ReadLine().Split());

            void PrintAction(string x) => Console.WriteLine(x);

            while (peoples.Any())
            {
                PrintAction(peoples.Dequeue());
            }
        }
    }
}
