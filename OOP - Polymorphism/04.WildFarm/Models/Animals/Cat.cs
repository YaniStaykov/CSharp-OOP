﻿namespace _04.WildFarm.Models.Animals
{
    using _04.WildFarm.Models.Foods;
    using System;
    using System.Collections.Generic;

    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => 0.30;

        public override ICollection<Type> PreferedFoods => new List<Type>() {typeof(Vegetable),typeof(Meat) };

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
