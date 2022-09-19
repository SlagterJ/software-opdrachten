using static AutoDagwaarde.Types;

namespace AutoDagwaarde.Car
{
    public class Car
    {
        // kilometers ridden
        public int kilometers { get; private set; } = 0;
        public string licensePlate { get; private set; }
        public FuelType fuelType;

        public Car(string licensePlate, FuelType fuelType)
        {
            this.licensePlate = licensePlate;
            this.fuelType = fuelType;
        }

        public void Drive(int amountOfKilometers)
        {
            if (amountOfKilometers <= 0) return;
            this.kilometers += amountOfKilometers;
        }

        public int GetWorth()
        {
            int worth = (500000 / this.kilometers) * fuelType.GetHashCode();
            return worth;
        }

        public override string ToString()
        {
            int _worth = this.GetWorth();
            string worth = _worth.ToString();

            string output =
                $"{this.licensePlate} {this.fuelType} car {this.kilometers} km ridden with a worth of {worth}";

            return output;
        }
    }
}
