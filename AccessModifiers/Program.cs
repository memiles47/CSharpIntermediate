using System;
using Amazon;

namespace AccessModifiers
{
    class Program
    {
        static void Main()
        {
            #region Private method modifier demonstration

            var customer = new Customer();
            customer.Promote();

            #endregion

            #region Protected method modifier demonstration

            var goldCustomer = new GoldCustomer();
            goldCustomer.OfferVouchar();

            #endregion

            #region internal method modifier demonstration

            //Cannot access Amazon.RateCalculator() because of its internal protection.
            var customer2 = new Customer();
            var customer3 = new Amazon.Customer();
            var rateCalculator = new Amazon.RateCalculator();

            #endregion
        }
    }
}
