using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Motorbike:Vehicle
    {
        private string motorbikes;


        public string Motorbikes
        {
            get
            {
                return motorbikes;
            }

            set
            {
                motorbikes = value;
            }
        }

        public override string ToString()
        {
            return $"Motorbike Colour: {colour}, Number of doors: {numOfDoors}";
        }
    }
}
