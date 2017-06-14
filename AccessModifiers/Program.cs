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

            #endregion        }
    }
}
