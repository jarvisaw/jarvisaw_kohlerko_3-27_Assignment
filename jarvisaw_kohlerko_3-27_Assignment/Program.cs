using System;

namespace jarvisaw_kohlerko_3_27_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseballTicket myBaseballTicket = new BaseballTicket(); // Corrected class name
            myBaseballTicket.Price = 75.00;  // Invoke the setter
            Console.WriteLine("Price of my ticket is " + myBaseballTicket.Price); // getter
            Console.WriteLine("Kolton Kohler");
        }
    }

    internal class BaseballTicket // Renamed to match PascalCase
    {
        private double _price;

        // Getter and setter for the price property
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
