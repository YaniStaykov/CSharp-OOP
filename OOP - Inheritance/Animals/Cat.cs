namespace Animals
{
    public class Cat : Animal, IProduceSound
    {
        public Cat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public string ProduceSound()
        {
            return "Meow meow";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }
}
