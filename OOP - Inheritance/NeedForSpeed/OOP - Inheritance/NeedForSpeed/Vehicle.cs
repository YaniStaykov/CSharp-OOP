using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public virtual double FuelConsuption
        { 
            get
            {
                return DefaultFuelConsumption;
            }
        }

        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }

        public virtual void Drive(double kilometers)
        {
            if (Fuel > 0)
            {
            this.Fuel -= kilometers * this.FuelConsuption;
            }

        }
    }
}
