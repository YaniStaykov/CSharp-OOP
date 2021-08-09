namespace _05.BirthDayCelebration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> allId = new List<IIdentifiable>();
            List<IBirthdate> allDates = new List<IBirthdate>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }
                if (command[0] == "Citizen")
                {
                    allDates.Add(new Citizen(command[1], int.Parse(command[2]), command[3], command[4]));
                }
                else if (command[0] == "Robot")
                {
                    allId.Add(new Robot(command[1], command[2]));
                }
                else if (command[0] == "Pet")
                {
                    allDates.Add(new Pet(command[1], command[2]));
                }
            }

            string year = Console.ReadLine();

            allDates.Where(c => c.Birthdate.EndsWith(year))
            .Select(c => c.Birthdate)
            .ToList()
            .ForEach(Console.WriteLine);
        }
    }
}
