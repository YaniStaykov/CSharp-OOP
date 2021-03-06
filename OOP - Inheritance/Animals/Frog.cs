namespace Animals
{
    public class Frog : Animal, IProduceSound
    {
        public Frog(string name, int age, string gender) 
            : base(name, age, gender)
        {
            base.Name = name;
        }

        public string ProduceSound()
        {
            return "Ribbit";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }
}
