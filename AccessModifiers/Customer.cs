using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excluedOrders: true);
            if (rating == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");

        }

        private int CalculateRating(bool excluedOrders)
        {
            return 0;
        }

        protected string GoodShoutOut()
        {
            return "I am a GOLD Customer!";
        }
    }
}