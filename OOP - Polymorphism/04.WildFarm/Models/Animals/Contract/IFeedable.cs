namespace _04.WildFarm.Models.Animals.Contract
{
    using System;
    using System.Collections.Generic;
    using _04.WildFarm.Models.Foods.Contracts;

    public interface IFeedable
    {
        void Feed(IFood food);

        int FoodEaten { get; }

        double WeightMultiplier { get; }

        ICollection<Type> PreferedFoods { get; }
    }
}
