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
            var store = new Store();
            var order = startup.CreateOrder(user, store);
            try
            {
                MainMenu(order);
            }
            catch (Exception ex)
            {
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
                Startup.PrintMenu();

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

                        SelectOption("Hawaiian", cart, "L", "Stuffed", new List<string> { "Pineapples", "Ham" });
                        break;

                    case 4:

                        SelectOption("Custom", cart, "L", "Stuffed", new List<string> { "It's a Mystery", "Might be History" });
                        break;

                    case 5:
                        DisplayCart(cart);
                        break;

                    case 6:
                        var fmw = new FileManager();
                        fmw.Write(cart);
                        System.Console.WriteLine("Thank you, Goodbye");
                        exit = true;
                        break;
                    case 7:
                        var fmr = new FileManager();
                        cart=fmr.Read();
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
