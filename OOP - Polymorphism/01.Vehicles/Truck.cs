namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double additionalConsumptionPerKm = 1.6;
        private const double refuelingCoefficient = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        protected override double AdditionalConsumption => additionalConsumptionPerKm;

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * refuelingCoefficient);
        }
    }
}