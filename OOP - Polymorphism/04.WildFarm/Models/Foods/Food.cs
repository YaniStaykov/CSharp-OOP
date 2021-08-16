namespace _04.WildFarm.Models.Foods
{
    using _04.WildFarm.Models.Foods.Contracts;

    public abstract class Food : IFood
    {
        public int Quantity { get; }

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
