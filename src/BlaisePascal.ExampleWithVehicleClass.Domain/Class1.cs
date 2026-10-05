namespace BlaisePascal.ExampleWithVehicleClass.Domain
{
    public class Vehicle
    {

        private string _licensePlate;
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        public string LicensePlate
        {
            get
            { return _licensePlate; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The plate should have characters");
                _licensePlate = value;
            }
        }

        public int OdometerKm
        {
            get
            { return _odometerKm; }
            private set
            {
                if (value < 0) throw new ArgumentException("The number of km should not be negative");
                _odometerKm = value;
            }
        }

        public double DailyRate
        {
            get
            { return _dailyRate; }
            private set
            {
                if (value <= 0) throw new ArgumentException("The daily rate should be positive");
                _dailyRate = value;
            }
        }

        public double FuelLevelPercentage
        {
            get
            { return _fuelLevelPercentage; }
            private set
            {
                if (value < 0 && value > 100) throw new ArgumentException("The fuel level percentage should be from 0 to 100");
                _fuelLevelPercentage = value;
            }
        }

        public Vehicle(string licensePlate)
        { 
            LicensePlate = licensePlate; 
        }

        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLevelPercentage)
        { LicensePlate = licensePlate; 
          OdometerKm = odometerKm; 
          DailyRate = dailyRate; 
          FuelLevelPercentage = fuelLevelPercentage;
        }

    }
}
