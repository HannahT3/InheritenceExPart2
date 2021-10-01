using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        public string colour;
        public int numOfDoors;

        public virtual void setColour(string col) 
        {
            colour = col;
        }

        public virtual void setDoors(int doors)
        {
            numOfDoors = doors;
        }



    }
}




