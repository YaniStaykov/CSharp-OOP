namespace _3._Raiding.Core
{
    using _3.Raiding.Factory;
    using _3.Raiding.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private ICollection<BaseHero> heroes;

        public Engine()
        {
            heroes = new List<BaseHero>();
        }        

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            while (n != counter)
            {
                string name = Console.ReadLine();
                string typeHero = Console.ReadLine();

                try
                {
                    BaseHero hero = FactoryHeroes.CreateHero(typeHero, name);

                    heroes.Add(hero);

                    counter++;
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            double bossPower = double.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int sum = heroes.Sum(h => h.Power);

            if (sum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
