﻿namespace _06.FoodShortage
{
    public class Citizen : IIdentifiable, IBirthdate, IBuyer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public string Birthdate { get; }

        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
