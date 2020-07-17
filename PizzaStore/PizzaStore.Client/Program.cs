using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
            WelocmeBanner();

        }
        //WelcomeBanner displays startup text and calls the MainMenu function
        static void WelocmeBanner()
        {
            System.Console.WriteLine("Welcome to PizzaWorld");
            System.Console.WriteLine("Best Pizza this side of Alpha Centuri");
            System.Console.WriteLine();

            //List<Pizza> cart = new List<Pizza>();

            var startup = new PizzaStore.Client.Startup();
            var user = new User();
            var store= new Store();
            var order =startup.CreateOrder(user,store);
            try
            {
            MainMenu(order);
            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }

        }
        //MainMenu handles user input, adding to cart, and displaying user options and selections
        static void MainMenu(Order cart)
        {
            bool exit = false;
            
            //int numPizza = 0;
            do
            {
                //display menu options
                System.Console.WriteLine("Please select an option");
                System.Console.WriteLine("1 for Cheese Pizza");
                System.Console.WriteLine("2 for Pepperoni Pizza");
                System.Console.WriteLine("3 for Hawaiian Pizza");
                System.Console.WriteLine("4 for Custom Pizza");
                System.Console.WriteLine("5 to Display Cart");
                System.Console.WriteLine("6 for Exit");
                System.Console.WriteLine();

                int select;
                int.TryParse(Console.ReadLine(), out select);
                //perform action dependent updon what option is selected
                switch (select)
                {
                    case 1:

                        SelectOption("Cheese", cart, "L", "Stuffed", new List<string> { "Cheese" });
                        break;

                    case 2:

                        SelectOption("Pepperoni", cart, "L", "Stuffed", new List<string> { "Pepperoni" });
                        break;

                    case 3:

                        SelectOption("Hawaiian", cart, "L", "Stuffed", new List<string> { "Pineapples","Ham" });
                        break;

                    case 4:

                        SelectOption("Custom", cart, "L", "Stuffed", new List<string> { "It's a Mystery", "Might be History" });
                        break;

                    case 5:
                        DisplayCart(cart);
                        break;

                    case 6:
                        System.Console.WriteLine("Thank you, Goodbye");
                        exit = true;
                        break;
                }




                System.Console.WriteLine();
            } while (!exit);

        }//end MainMenu
        //SelectOption adds the selected option to cart, and outputs it to console
        static void SelectOption(string option, Order cart, string size, string crust, List<string> toppings)
        {
            cart.CreatePizza(size, crust, toppings);
            
            System.Console.WriteLine($"{option} Pizza Added");
        }

        static void DisplayCart(Order cart)
        {
            foreach (var pizza in cart.Pizzas)
            {
                System.Console.WriteLine(pizza.ToString());
            }
        }
        
    }//end Program
}//end namespace
