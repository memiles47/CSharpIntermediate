using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculate = new RateCalculator();
            var rating = calculate.Calculate(this);

            Console.WriteLine("Promote logic changes.");
        }
    }
}