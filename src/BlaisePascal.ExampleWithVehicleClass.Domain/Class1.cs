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
                if (value == null)
                {
                    throw new ArgumentNullException("The license cant be null");
                }

                if (value.Length != 7)
                {
                    throw new ArgumentException("The license plate should be long 7 characters");
                }

                string validLetters = "ABCDEFGHJKLMNPRSTVWXYZ"; // lettere valide, tranne la I, O, Q e U
                string validNumbers = "0123456789";

                for (int i = 0; i < 2; i++)
                {
                    string character = value[i].ToString();
                    if (!validLetters.Contains(character))
                    {
                        throw new ArgumentException("The letters of the first two positions should be valid");
                    }
                }

                for (int i = 2; i <= 4; i++)
                {
                    string carattere = value[i].ToString();
                    if (!validNumbers.Contains(carattere))
                    {
                        throw new ArgumentException("Those positions should have numbers from 0 to 9");
                    }
                }

                for (int i = 5; i <= 6; i++)
                {
                    string carattere = value[i].ToString();
                    if (!validLetters.Contains(carattere))
                    {
                        throw new ArgumentException("The last two letters should be valid");
                    }
                }

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
