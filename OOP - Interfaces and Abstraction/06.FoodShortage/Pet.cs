﻿namespace _06.FoodShortage
{
    public class Pet : IBirthdate
    {
        public string Name { get; set; }

        public string Birthdate { get; set; }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
