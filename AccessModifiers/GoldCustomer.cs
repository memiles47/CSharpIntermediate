using System;

namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            //Accessing protected method
            Console.WriteLine(this.GoodShoutOut());
        }
    }
}