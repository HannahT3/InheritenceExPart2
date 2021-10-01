using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorbike m1 = new Motorbike();
            Truck t1 = new Truck();
            Car c1 = new Car();

            m1.colour = "black";
            m1.numOfDoors = 5;

            t1.colour = "red";
            t1.numOfDoors = 2;

            c1.colour = "white";
            c1.numOfDoors = 3;

            Console.WriteLine(m1); 
            Console.WriteLine(t1);
            Console.WriteLine(c1);
        }
    }
}
