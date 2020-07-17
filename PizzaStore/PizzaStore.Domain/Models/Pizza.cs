using System.Collections.Generic;
using System.Text;
namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        //STATE
        //fields (camelCasing)
        string imageUrl = "";
        double diameter = 0;
        //string Size = "";
         List<string> Toppings = new List<string>();
        public List<string> GetToppings(){
             return Toppings;
         }

        // string Crust = "";
        //properties (PascelCasing)
         public string SizeP { get;}
        public string CrustP {get;}


        //BEHAVIOR
        //methods
        public void AddToppings(string topping)
        {
            Toppings.Add(topping);
        }
        //outputs pizza fields as a string
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var top in Toppings)
            {
                sb.Append($"{top}, ");
            }
            sb.Remove(sb.Length - 2, 1);
            return $"Size: \"{SizeP}\" Crust: \"{CrustP}\" Toppings: \"{sb.ToString()}\"";
        }
        //constructors
        public Pizza(string _size, string _crust, List<string> _toppings)
        {
            SizeP = _size;
            CrustP = _crust;
            Toppings.AddRange(_toppings);
        }
        //finalizers or destructors
    }
}