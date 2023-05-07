using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
       
        public static IVehicle GetVehicle (int numTires)
        {
            switch (numTires)
            {
                case 2:
                    return new MotorCycle();
                
                case 3:
                    return new Car();
               
                case 4: return new SUV();
                
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
