namespace _04.WildFarm.Models.Animals
{
    using _04.WildFarm.Models.Foods;
    using System;
    using System.Collections.Generic;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => 0.40;

        public override ICollection<Type> PreferedFoods => new List<Type>() {typeof(Meat) };

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
