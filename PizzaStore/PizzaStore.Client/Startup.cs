using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    internal class Startup
    {

       internal Order CreateOrder(User user, Store store)
       {
           try{
            var ord= new Order();
            user.Order.Add(ord);
            store.Orders.Add(ord);
           return ord;
           }catch
           {
               throw new System.Exception("we messed up");
           }
       }
    }
}