namespace _04.BorderContrrol
{
    public class Robot : IIdentifiable
    {
        public string Id { get; }

        public string Model { get; set; }

        public Robot(string model, string id )
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
