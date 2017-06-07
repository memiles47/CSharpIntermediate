using System.Collections.Generic;

namespace Classes
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(int id) //These are redundant constructors
            :this() // ':this' used in this was can be confusing to others when reading
        {
            this.Id = id;
        }

        public Customer(int id, string name)  //These are redundant constructors
            : this(id) // ':this' used in this was can be confusing to others when reading
        {
            this.Name = name;
        }
    }
}