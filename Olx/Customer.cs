using System;

namespace Olx
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            if (CalculateRating(excludeOrders: true) == 1)
                Console.WriteLine("Promoted");

            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 1;
        }
    }
}