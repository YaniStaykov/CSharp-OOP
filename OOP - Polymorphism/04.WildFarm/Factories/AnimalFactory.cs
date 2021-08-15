namespace _04.WildFarm.Factories
{
    using _04.WildFarm.Exeptions;
    using _04.WildFarm.Models.Animals;
    using System;

    public class AnimalFactory
    {
        public Animal Create(string type, string name, double weight, string[] args)
        {
            Animal animal = null;

            if (args.Length == 1)
            {
                bool isBird = double.TryParse(args[0],out double wingSize);

                if (isBird)
                {
                    if (type == "Hen")
                    {
                        animal = new Hen(name, weight, wingSize);
                    }
                    else if (type == "Owl")
                    {
                        animal = new Owl(name, weight, wingSize);
                    }
                    else
                    {
                        throw new InvalidOperationException(ExeptionMessages.InvaliAnimalType);
                    }
                }
                else
                {
                    string livingRegion = args[0];
                    if (type == "Mouse")
                    {
                        animal = new Mouse(name, weight, livingRegion);
                    }
                    else if (type == "Dog")
                    {
                        animal = new Dog(name, weight, livingRegion);
                    }
                    else
                    {
                        throw new InvalidOperationException(ExeptionMessages.InvaliAnimalType);
                    }
                }                

            }
            else if (args.Length == 2)
            {
                string livingRegion = args[0];
                string breed = args[1];
                if (type == "Cat")
                {
                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else if (type == "Tiger")
                {
                    animal = new Tiger(name, weight, livingRegion, breed);
                }
            }
            else
            {
                throw new InvalidOperationException(ExeptionMessages.InvaliAnimalType);
            }

            return animal;
        }
    }
}
