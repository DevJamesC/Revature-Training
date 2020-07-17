using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    public class Startup
    {

        public Order CreateOrder(User user, Store store)
        {
            try
            {
                var ord = new Order();
                user.Order.Add(ord);
                store.Orders.Add(ord);
                return ord;
            }
            catch
            {
                throw new System.Exception("we messed up");
            }
            finally
            {
                
                GC.Collect();
            }
        }

        internal static void PrintMenu()
        {
            System.Console.WriteLine("Please select an option");
            System.Console.WriteLine("1 for Cheese Pizza");
            System.Console.WriteLine("2 for Pepperoni Pizza");
            System.Console.WriteLine("3 for Hawaiian Pizza");
            System.Console.WriteLine("4 for Custom Pizza");
            System.Console.WriteLine("5 to Display Cart");
            System.Console.WriteLine("6 for Exit");
            System.Console.WriteLine("7 to load last order");
            System.Console.WriteLine();

        }
    }
}