﻿namespace _02.MultipleImplementation
{
    public class Citizen : IPerson , IBirthable , IIdentifiable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Birthdate { get; }

        public string Id { get; }
       
        public Citizen(string name, int age , string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}
