namespace _04.WildFarm.Models.Animals
{
    using _04.WildFarm.Models.Animals.Contract;
    using _04.WildFarm.Models.Foods.Contracts;
    using System;
    using System.Collections.Generic;

    public abstract class Animal : IAnimal, IFeedable, ISoundProducable
    {
        private const string INV_FOOD_TYPE = "{0} does not eat {1}!";
        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PreferedFoods { get; }

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        
        public void Feed(IFood food)
        {
            if (!this.PreferedFoods.Contains(food.GetType()))
            {
                throw new InvalidOperationException(string.Format(INV_FOOD_TYPE, this.GetType().Name, food.GetType().Name));
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightMultiplier;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
