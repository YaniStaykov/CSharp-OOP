﻿namespace Person
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {

        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child must be less than 15 years old");
                }

                base.Age = value;
            }
        }
    }
}
