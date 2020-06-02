namespace Inheritance
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;

            System.Console.WriteLine("Vehicle {0}", registrationNumber);
        }
    }
}