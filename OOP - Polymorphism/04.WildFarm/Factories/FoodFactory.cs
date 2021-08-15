namespace _04.WildFarm.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using _04.WildFarm.Exeptions;
    using _04.WildFarm.Models.Foods;

    public class FoodFactory
    {
        public Food CreateFood(string strType, int quantity)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly.GetTypes().FirstOrDefault(t => t.Name == strType);

            if (type == null)
            {
                throw new InvalidOperationException(ExeptionMessages.InvaliAnimalType);
            }

            object[] ctorParams = new object[] { quantity };

            Food food = (Food)Activator.CreateInstance(type, ctorParams);

            return food;
        }
    }
}
