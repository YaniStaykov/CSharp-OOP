namespace _04.BorderContrrol
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> allId = new List<IIdentifiable>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }

                if (command.Length == 3)
                {
                    allId.Add(new Citizen(command[0], int.Parse(command[1]), command[2]));
                }
                if (command.Length == 2)
                {
                    allId.Add(new Robot(command[0], command[1]));
                }
            }

            string lastDigits = Console.ReadLine();

            allId.Where(c => c.Id.EndsWith(lastDigits))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
