using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Truck : Vehicle
    {
        private string vehicles;


        public string Vehicles
        {
            get
            {
                return vehicles;
            }

            set
            {
                vehicles = value;
            }
        }
        public override string ToString()
        {
            return $"Truck Colour: {colour}, Number of doors: {numOfDoors}";
        }
    }
}
