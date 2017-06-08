using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(290203, "Michael Miles");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
