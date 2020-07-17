using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class User
    {
        public List<Order> Order{get; set;}

        public User()
        {
            Order=new List<Order>();
        }
    }
}