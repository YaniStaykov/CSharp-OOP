using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const decimal DeffaultCakePrice = 5m;
        private const double DeffaultGrams = 250;
        private const double DeffaultCalories = 1000;
        public Cake(string name) 
            : base(name, DeffaultCakePrice, DeffaultGrams, DeffaultCalories)
        {
        }
    }
}
