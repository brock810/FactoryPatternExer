﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SUV : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building new SUV");
            }

    }
}
