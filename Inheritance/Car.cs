namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            System.Console.WriteLine("Car {0}", registrationNumber);
        }
    }
}