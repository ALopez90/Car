using System;

namespace HW5_29
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car Vroom1 = new Car("Tesla Model X", 2019, 72000, 5, 155, "Long Range", "Performance");
            Vroom1.CarColor("space grey");
            Vroom1.CarType("SUV");
            Vroom1.Start("started");

            Car Vroom2 = new Car("VW Beetle", 2004, 5, 40, 60, "Super", "Extreme");
            Vroom2.CarColor("Hot pink");
            Vroom2.CarType("smaller car");
            Vroom2.Start("crashed");
        }
    }

    public class Car
    {
        public string _model { set; get; }
        public int _year { set; get; }
        public int _cost { set; get; }
        public int _acc { set; get; }
        public int _speed { set; get; }
        public string _range { set; get; }
        public string _perf { set; get; }

        public Car(string model, int year, int cost, int acc, int speed, string range, string perf)
        {
            _model = model;
            _year = year;
            _cost = cost;
            _acc = acc;
            _speed = speed;
            _range = range;
            _perf = perf;

            Console.WriteLine("Car has been assembled!");
            Console.WriteLine("The car created is the {1} {0}. The average cost of this car is typically around ${2}.", model, year, cost);
            Console.WriteLine("Congrats! Here are a few details about the {0}{1}:", year, model);
            Console.WriteLine("It goes 0-60 in around {0} seconds and it's top speed is {1}mph. While this one is the standard range, there's" +
                "also the {2} and {3}. This one, unfortunately is the only one we have available.", acc, speed, range, perf);
        }

        public void CarColor(string color)
        {
            Console.WriteLine("This car is the color {0}", color);
        }

        public void CarType(string type)
        {
            Console.WriteLine("This is more of a {0}, as you can see.", type);
        }

        public void Start(string start)
        {
            Console.WriteLine("Now that we've {0} it, you can fully experience the beauty of this car.", start);
        }
    }
}