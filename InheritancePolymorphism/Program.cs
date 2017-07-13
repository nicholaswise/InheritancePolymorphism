using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new Boat(2, 500, "White and yellow", 70.0d, .78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled());

            Automobile car1 = new Automobile(4, 20, 4, 5, 50, "Black", 260);
            car1.Move();

            car1.Color = "Gold";
            Console.WriteLine("Automobile " + car1.GetDistanceTraveled());

            Aircraft plane1 = new Aircraft(100, 1000, "Orange", 600);
            plane1.Move();
            plane1.Move();
            Console.WriteLine("Aircraft " + plane1.GetDistanceTraveled());


        }
    }
}
