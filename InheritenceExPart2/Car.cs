using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle
    {
        private string car;


        public string Cars
        {
            get
            {
                return car;
            }

            set
            {
                car = value;
            }

        }
        public override string ToString()
        {
            return $"Car Colour: {colour}, Number of doors: {numOfDoors}";
        }
    }
}
